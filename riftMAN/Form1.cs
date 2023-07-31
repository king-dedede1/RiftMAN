namespace riftMAN;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
        RiftMANState.Construct();
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            Memory.Write(BitConverter.GetBytes(uint.Parse(textBox1.Text)), 0x123456789);
        }
    }
}