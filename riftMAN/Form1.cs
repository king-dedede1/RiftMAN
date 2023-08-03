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

        if (Memory.Read(1, RiftMANState.Instance.GameCodeBaseAddr + 0x51501B1)[0] == 1)
        {
            infiniteAmmoCheckbox.Checked = true;
        }
        if (Memory.Read(1, RiftMANState.Instance.GameCodeBaseAddr + 0x51501B0)[0] == 1)
        {
            infiniteHealthCheckbox.Checked = true;
        }
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        label2.Text = $"LEVELID: {Memory.ReadInt(0x5150298 + RiftMANState.Instance.GameCodeBaseAddr)}";
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            Memory.Write(BitConverter.GetBytes(uint.Parse(boltCountTextBox.Text)), 0x5150298 + RiftMANState.Instance.GameCodeBaseAddr);
        }
    }

    private void textBox2_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            Memory.WriteInt(int.Parse(rariTextBox.Text), RiftMANState.Instance.GameCodeBaseAddr + 0x640F210, 0xF50, 0xC78, 0x88, 0x10, 0x3D8, 0x380, 0x488);
        }
    }

    private void gameSpeedTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (float.TryParse(gameSpeedTextBox.Text, out float speed))
            {
                Memory.Write(BitConverter.GetBytes(speed), RiftMANState.Instance.GameCodeBaseAddr + 0x548F3A0);
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
            Memory.Write(new byte[] { 1 }, RiftMANState.Instance.GameCodeBaseAddr + 0x51501B0);
        }
        else
        {
            Memory.Write(new byte[] { 0 }, RiftMANState.Instance.GameCodeBaseAddr + 0x51501B0);
        }
    }

    private void infiniteAmmoCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        if (infiniteAmmoCheckbox.Checked)
        {
            Memory.Write(new byte[] { 1 }, RiftMANState.Instance.GameCodeBaseAddr + 0x51501B1);
        }
        else
        {
            Memory.Write(new byte[] { 0 }, RiftMANState.Instance.GameCodeBaseAddr + 0x51501B1);
        }
    }
}