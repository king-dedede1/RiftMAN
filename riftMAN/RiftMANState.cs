﻿using System;
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

    private RiftMANState()
    {
        var processes = Process.GetProcessesByName("RiftApart");
        if (processes.Length == 0)
        {
            MessageBox.Show("You need to start the game first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        GameProcess = processes[0];
        GameCodeBaseAddr = (ulong) GameProcess.MainModule.BaseAddress; // Surely this won't cause a problem?
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
