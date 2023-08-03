using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace riftMAN;

internal class RiftMANState
{
    private static RiftMANState? instance;
    public static RiftMANState Instance => instance ??= new RiftMANState();

    public Process GameProcess { get; private set; }
    public ulong GameCodeBaseAddr { get; private set; }
    public string GameVersion { get; private set; }

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
    }
}
