using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace riftMAN.Mods;

internal class ModInfo
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? ModVersion { get; set; }
    public string? AuthorName { get; set; }
    public string[] GameVersions { get; set; }
    public PatchInfo[]? Patches { get; set; }

    [JsonIgnore]
    public string ModFolderPath { get; set; } // used for loading patches/scripts from disk

    private static Dictionary<PatchInfo, byte[]> defaultGameCode = new();

    public class PatchInfo
    {
        public string FilePath { get; set; }
        public ulong Address { get; set; }
    }

    public static void EnableMod(ModInfo mInfo)
    {
        if (mInfo.Patches != null)
        {
            foreach (PatchInfo patch in mInfo.Patches)
            {
                byte[] patchBytes = File.ReadAllBytes($"{mInfo.ModFolderPath}\\{patch.FilePath}");
                defaultGameCode.Add(patch, Memory.Read((uint)patchBytes.Length, patch.Address + RiftMANState.Instance.GameCodeBaseAddr));
                Memory.Write(patchBytes, patch.Address + RiftMANState.Instance.GameCodeBaseAddr);
            }
        }
    }

    public static void DisableMod(ModInfo mInfo)
    {
        if (mInfo.Patches != null)
        {
            foreach (PatchInfo patch in mInfo.Patches)
            {
                Memory.Write(defaultGameCode[patch], patch.Address + RiftMANState.Instance.GameCodeBaseAddr);
                defaultGameCode.Remove(patch);
            }
        }
    }
}
