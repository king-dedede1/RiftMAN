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
    public static RiftMANState Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new RiftMANState();
            }
            return instance;
        }
    }

    public Process GameProcess { get; private set; }
    public ulong GameCodeBaseAddr { get; private set; }
    public string GameVersion { get; private set; }

    // Connect to game
    private RiftMANState()
    {
        var processes = Process.GetProcessesByName("RiftApart");
        if (processes.Length == 0)
        {
            MessageBox.Show("You need to start the game first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
        GameProcess = processes[0];

        // GameProcess is never going to be null, chill out visual studio
        GameCodeBaseAddr = (ulong) GameProcess.MainModule.BaseAddress;
        GameVersion = GameProcess.MainModule.FileVersionInfo.FileVersion;
        MessageBox.Show("Attached!");
    }

    public static void Construct()
    {
        if (instance == null)
        {
            instance = new RiftMANState();
        }
    }
}
