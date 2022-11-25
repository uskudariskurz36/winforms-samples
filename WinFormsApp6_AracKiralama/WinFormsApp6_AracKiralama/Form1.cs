using System.Text.Json;

namespace WinFormsApp6_AracKiralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Vehicle> vehicles = new List<Vehicle>();
        private List<Rent> rents = new List<Rent>();

        private string pathVehicles = Application.StartupPath + "vehicles.json";
        private string pathRents = Application.StartupPath + "rents.json";

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
            // save vehicles..
            string jsonVehicles = 
                JsonSerializer.Serialize(vehicles, new JsonSerializerOptions() { WriteIndented= true });

            File.WriteAllText(pathVehicles, jsonVehicles);


            // save rents..
            string jsonRents =
                JsonSerializer.Serialize(rents, new JsonSerializerOptions() { WriteIndented = true });

            File.WriteAllText(pathRents, jsonRents);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBrand.DataSource = null;
            cmbBrand.DataSource = frmBrands.ReadData();

            cmbModel.DataSource = null;
            cmbModel.DataSource = frmModels.ReadData();

            if (File.Exists(pathVehicles))
            {
                string json = File.ReadAllText(pathVehicles);
                vehicles = JsonSerializer.Deserialize<List<Vehicle>>(json);

                lstVehicles.DataSource = null;
                lstVehicles.DataSource = vehicles;
            }


            if (File.Exists(pathRents))
            {
                string json = File.ReadAllText(pathRents);
                rents = JsonSerializer.Deserialize<List<Rent>>(json);

                lstCustomerRents.DataSource = null;
                lstCustomerRents.DataSource = rents;
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            openFileDialog.Title = "Resim Seç";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); ;
            openFileDialog.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picVehicle.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            Vehicle vehicle= new Vehicle();
            vehicle.Brand = cmbBrand.Text;
            vehicle.Model = cmbModel.Text;
            vehicle.KM = (int)nudKM.Value;
            vehicle.Year = (int)nudYear.Value;
            vehicle.DailyPrice = nudDailyPrice.Value;
            vehicle.IsRent = chkIsRent.Checked;
            vehicle.ImagePath = picVehicle.ImageLocation;

            vehicles.Add(vehicle);

            lstVehicles.DataSource = null;
            lstVehicles.DataSource = vehicles;
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (lstVehicles.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kayýt seçiniz..");
                return;
            }

            vehicles.RemoveAt(lstVehicles.SelectedIndex);

            lstVehicles.DataSource = null;
            lstVehicles.DataSource = vehicles;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (lstVehicles.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir araç seçiniz..");
                return;
            }


            Rent rent = new Rent();
            rent.NameSurname = txtCustomerName.Text;
            rent.TCNo = txtCustomerTCNo.Text;
            rent.StartDate = dtpStartDate.Value.Date;
            rent.EndDate = dtpEndDate.Value.Date;
            rent.DownPayment = nudDownPayment.Value;

            Vehicle selectedVehicle = lstVehicles.SelectedItem as Vehicle;

            rent.Vehicle = selectedVehicle;

            rents.Add(rent);

            lstCustomerRents.DataSource = null;
            lstCustomerRents.DataSource = rents;
        }

        private void btnDeleteRent_Click(object sender, EventArgs e)
        {
            if (lstCustomerRents.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kayýt seçiniz..");
                return;
            }

            rents.RemoveAt(lstCustomerRents.SelectedIndex);

            lstCustomerRents.DataSource = null;
            lstCustomerRents.DataSource = rents;
        }
    }
}