namespace WinFormsApp6_AracKiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            frmBrands frm = new frmBrands();
            frm.ShowDialog();
        }

        private void btnModels_Click(object sender, EventArgs e)
        {
            frmModels frm = new frmModels();
            frm.ShowDialog();
        }
    }
}