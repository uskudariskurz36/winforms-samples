namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(100, 40);

            flowLayoutPanel1.Controls.Add(btn);
        }
    }
}