using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.Json;
using riftMAN.Mods;

namespace riftMAN;

internal class RiftMANState
{
    private static RiftMANState? instance;
    public static RiftMANState Instance => instance ??= new RiftMANState();

    public Process GameProcess { get; private set; }
    public ulong GameCodeBaseAddr { get; private set; }
    public string GameVersion { get; private set; }
    public List<ModInfo> Mods { get; private set; }

    // Connect to game
    private RiftMANState()
    {
        var processes = Process.GetProcessesByName("RiftApart");
        if (processes.Length == 0)
        {
            MessageBox.Show("Couldn't locate game process. Did you start the game yet?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
        GameProcess = processes[0];
        if (GameProcess.MainModule == null)
        {
            MessageBox.Show("Couldn't locate game module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
        GameCodeBaseAddr = (ulong) GameProcess.MainModule.BaseAddress;
        if (GameProcess.MainModule.FileVersionInfo.FileVersion == null)
        {
            MessageBox.Show("Couldn't locate game module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
        GameVersion = GameProcess.MainModule.FileVersionInfo.FileVersion;

        Mods = new List<ModInfo>();
    }

    public void LoadModInfos()
    {
        Mods.Clear();
        Directory.CreateDirectory("Mods");
        foreach (string modDir in Directory.GetDirectories("Mods"))
        {
            string pInfo = $"{modDir}\\mod.json";
            if (!File.Exists(pInfo)) continue;
            string fInfo = File.ReadAllText(pInfo);
            ModInfo? mInfo = JsonSerializer.Deserialize<ModInfo?>(fInfo);
            if (mInfo == null)
            {
                MessageBox.Show($"Warning: Error deserializing mod at {pInfo}");
            }
            else
            {
                mInfo.ModFolderPath = modDir;
                Mods.Add(mInfo);
            }
        }
    }
}
