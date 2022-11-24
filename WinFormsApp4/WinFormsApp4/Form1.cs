namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        User user = null;

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            user = new User
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                BirthDate = dtpBirthdate.Value,
                Email = txtEmail.Text,
                TcNo = txtTcNo.Text,
                Phone = txtPhone.Text,
                Male = chkMale.Checked,
                Addresses = new List<Address>(),
                Experiences = new List<Experience>()
            };

            //User user1 = new User();
            //user1.Name = txtName.Text;
            //user1.Surname= txtSurname.Text;
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            Address address = new Address
            {
                City = txtCity.Text,
                Street = txtStreet.Text,
                District = txtDistrict.Text,
                PostalCode = int.Parse(txtPostalCode.Text),
                Country = new Country
                {
                    Name = txtCountryName.Text,
                    RegionCode = txtCountryRegionCode.Text,
                }
            };

            //address.Country = new Country
            //{
            //    Name = txtCountryName.Text,
            //    RegionCode = txtCountryRegionCode.Text,
            //};


            //Country country = new Country
            //{
            //    Name = txtCountryName.Text,
            //    RegionCode = txtCountryRegionCode.Text,
            //};

            //address.Country = country;


            lstAddresses.Items.Add(address);
            user.Addresses.Add(address);
        }
    }
}