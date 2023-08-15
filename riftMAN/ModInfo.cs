﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Security;
using Timer = System.Windows.Forms.Timer;

namespace riftMAN.Mods;

public class ModInfo
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? ModVersion { get; set; }
    public string? AuthorName { get; set; }
    public string[] GameVersions { get; set; }
    public PatchInfo[]? Patches { get; set; }
    public ScriptInfo[]? Scripts { get; set; }

    [JsonIgnore]
    public string ModFolderPath { get; set; } // used for loading patches/scripts from disk

    private static Dictionary<PatchInfo, byte[]> defaultGameCode = new();
    private static Dictionary<ScriptInfo, (Script script, Timer timer)> scripts = new();

    public class PatchInfo
    {
        public string FilePath { get; set; }
        public ulong Address { get; set; }
    }

    public class ScriptInfo
    {
        public string FilePath { get; set; }
        public string? ClassName { get; set; }
    }

    public static void EnableMod(ModInfo mInfo)
    {
        if (mInfo.Patches != null)
        {
            foreach (PatchInfo patch in mInfo.Patches)
            {
                byte[] patchBytes = File.ReadAllBytes($"{mInfo.ModFolderPath}\\{patch.FilePath}");
                defaultGameCode.Add(patch, Memory.Read((uint)patchBytes.Length, patch.Address));
                Memory.Write(patchBytes, patch.Address);
            }
        }
        if (mInfo.Scripts != null)
        {
            foreach (ScriptInfo sInfo in mInfo.Scripts)
            {
                if (sInfo.ClassName == null)
                {
                    sInfo.ClassName = Path.GetFileNameWithoutExtension(sInfo.FilePath);
                }
                var sSource = File.ReadAllText($"{mInfo.ModFolderPath}\\{sInfo.FilePath}");
                Script script = ScriptCompiler.Compile(sSource, sInfo.ClassName);
                Timer scriptTimer = new()
                {
                    Interval = script.Interval,
                    Tag = script
                };
                scriptTimer.Tick += Timer_Tick;
                scripts.Add(sInfo, (script, scriptTimer));
                script.Start(RiftMANState.Instance);
                scriptTimer.Start();
            }
        }
    }

    public static void DisableMod(ModInfo mInfo)
    {
        if (mInfo.Patches != null)
        {
            foreach (PatchInfo patch in mInfo.Patches)
            {
                Memory.Write(defaultGameCode[patch], patch.Address);
                defaultGameCode.Remove(patch);
            }
        }
        if (mInfo.Scripts != null)
        {
            foreach (ScriptInfo sInfo in mInfo.Scripts)
            {
                scripts[sInfo].timer.Stop();
                var script = scripts[sInfo].script;
                script.Stop(RiftMANState.Instance);
                scripts.Remove(sInfo);
            }
        }
    }

    private static void Timer_Tick(object? sender, EventArgs e)
    {
        Script script = (sender as Timer).Tag as Script;
        script.Update(RiftMANState.Instance);
    }

}
