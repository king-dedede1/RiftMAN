using riftMAN.Mods;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace riftMAN;

public partial class Form1 : Form
{

    Timer timer;

    public Form1()
    {
        InitializeComponent();

        // Set window title
        Text = $"RiftMAN - Connected to Rift Apart v{RiftMANState.Instance.GameVersion}";

        // For updating the LEVELID label. This is temporary and will be removed later
        timer = new Timer();
        timer.Tick += Timer_Tick;
        timer.Interval = 16;
        timer.Start();

        if (Memory.ReadByte(RiftMANState.Instance.GameCodeBaseAddr + 0x51501B1) == 1)
        {
            infiniteAmmoCheckbox.Checked = true;
        }
        if (Memory.ReadByte(RiftMANState.Instance.GameCodeBaseAddr + 0x51501B0) == 1)
        {
            infiniteHealthCheckbox.Checked = true;
        }

        RefreshModList();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        label2.Text = $"LEVELID: {Memory.ReadInt(0x5150298 + RiftMANState.Instance.GameCodeBaseAddr)}";
    }

    private void gameSpeedTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (float.TryParse(gameSpeedTextBox.Text, out float speed))
            {
                Memory.WriteFloat(speed, RiftMANState.Instance.GameCodeBaseAddr + 0x548F3A0);
            }
            else
            {
                MessageBox.Show("Couldn't parse number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void infiniteHealthCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        if (infiniteHealthCheckbox.Checked)
        {
            Memory.WriteByte(1, RiftMANState.Instance.GameCodeBaseAddr + 0x51501B0);
        }
        else
        {
            Memory.WriteByte(0, RiftMANState.Instance.GameCodeBaseAddr + 0x51501B0);
        }
    }

    private void infiniteAmmoCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        if (infiniteAmmoCheckbox.Checked)
        {
            Memory.WriteByte(1, RiftMANState.Instance.GameCodeBaseAddr + 0x51501B1);
        }
        else
        {
            Memory.WriteByte(0, RiftMANState.Instance.GameCodeBaseAddr + 0x51501B1);
        }
    }

    private void boltCountTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (int.TryParse(boltCountTextBox.Text, out var boltCount))
            {
                Memory.WriteInt(boltCount, RiftMANState.Instance.GameCodeBaseAddr + 0x52DA338, 0x910, 0x50, 0x298, 0x80);
            }
            else
            {
                MessageBox.Show("Couldn't parse number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    void RefreshModList()
    {
        label6.Text = @"Name: 
Description: 
Mod Version: 
Author: 
Game Version(s): 
";
        RiftMANState.Instance.LoadModInfos();
        modListBox.Items.Clear();
        foreach (ModInfo mInfo in RiftMANState.Instance.Mods)
        {
            modListBox.Items.Add(mInfo.Name);
        }
    }

    private void refreshButton_Click(object sender, EventArgs e)
    {
        RefreshModList();
    }

    private void modListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (modListBox.SelectedIndex < 0) return;
        ModInfo mInfo = RiftMANState.Instance.Mods[modListBox.SelectedIndex];
        label6.Text = $"Name: {mInfo.Name}\nDescription: {mInfo.Description}\nMod Version: {mInfo.ModVersion}\nAuthor: {mInfo.AuthorName}\nGame Version(s): {mInfo.GameVersions.ToCSVString()}";
    }

    private void openFolderButton_Click(object sender, EventArgs e)
    {
        Process.Start("explorer.exe", Path.GetFullPath("Mods"));
    }

    private void modListBox_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        ModInfo mInfo = RiftMANState.Instance.Mods[modListBox.SelectedIndex];

        if (e.NewValue == CheckState.Checked)
        {
            ModInfo.EnableMod(mInfo);
        }
        else
        {
            ModInfo.DisableMod(mInfo);
        }
    }
}