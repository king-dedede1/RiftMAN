namespace riftMAN
{
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
                Memory.WriteGameMemory(0x1BE5FE4EA20, BitConverter.GetBytes(uint.Parse(textBox1.Text)));
            }
        }
    }
}