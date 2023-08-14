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
                Memory.Write(patchBytes, patch.Address);
            }
        }
    }

    public static void DisableMod(ModInfo mInfo)
    {
        // Restore original game code
        // I'll do it later
    }
}
