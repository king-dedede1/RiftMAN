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
        label2.Text = $"Handle = 0x{RiftMANState.Instance.GameProcess.Handle:X}";
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            Memory.Write(BitConverter.GetBytes(uint.Parse(textBox1.Text)), 0x123456789);
        }
    }
}