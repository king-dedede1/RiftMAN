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
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        label2.Text = $"LEVELID: {Memory.ReadInt(0x5150298 + RiftMANState.Instance.GameCodeBaseAddr)}";
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        
    }

    private void textBox2_KeyDown(object sender, KeyEventArgs e)
    {
        
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
}