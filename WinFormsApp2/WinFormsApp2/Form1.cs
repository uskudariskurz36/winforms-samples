


using System.Diagnostics;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuInfo_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FullName = txtFullName.Text;
            user.Username = txtUsername.Text;
            user.PhoneNumber = txtPhoneNumber.Text;
            user.Email = txtEmail.Text;
            user.Category = cmbCategory.Text;
            //user.Category = cmbCategory.SelectedText;
            //user.Category = cmbCategory.SelectedValue.ToString();

            if (rdbElementry.Checked)
            {
                user.EnglishLevel = "elementry";
            }
            else if (rdbIntermediate.Checked)
            {
                user.EnglishLevel = "intermediate";
            }
            else if (rdbUpper.Checked)
            {
                user.EnglishLevel = "upper";
            }
            else
            {
                user.EnglishLevel = "native";
            }

            user.SSCSharp = chkCSharp.Checked;
            user.SSSql = chkSql.Checked;
            user.SSWinform = chkWinforms.Checked;
            user.SSAspnet = chkAspnet.Checked;

            user.SocialUrl1 = txtSocialUrl1.Text;
            user.SocialUrl2 = txtSocialUrl2.Text;
            user.SocialUrl3 = txtSocialUrl3.Text;

            lstUsers.Items.Add(user);
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {

            // 15551234567
            string phone = txtPhoneNumber.Text;
            string url = "https://wa.me/" + phone;
            //string url = $"whatsapp://send?phone={phone}&text=hello";

            //ProcessStartInfo processStartInfo = new ProcessStartInfo(url);
            //processStartInfo.UseShellExecute = false;


            Process.Start("explorer.exe", url);
        }
    }
}