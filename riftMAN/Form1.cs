using Timer = System.Windows.Forms.Timer;

namespace riftMAN;

public partial class Form1 : Form
{

    Timer timer;

    public Form1()
    {
        InitializeComponent();
        RiftMANState.Construct();

        timer = new Timer();
        timer.Tick += Timer_Tick;
        timer.Interval = 16;
        timer.Start();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        label2.Text = $"LEVELID: {Memory.ReadInt(0x5150298 + RiftMANState.Instance.GameCodeBaseAddr)}";
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            Memory.Write(BitConverter.GetBytes(uint.Parse(textBox1.Text)), 0x5150298 + RiftMANState.Instance.GameCodeBaseAddr);
        }
    }

    private void textBox2_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            Memory.WriteInt(int.Parse(textBox2.Text), RiftMANState.Instance.GameCodeBaseAddr + 0x640F210, 0xF50, 0xC78, 0x88, 0x10, 0x3D8, 0x380, 0x488);
        }
    }
}