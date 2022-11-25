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
        private string pathVehicles = Application.StartupPath + "vehicles.json";

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
            string json = 
                JsonSerializer.Serialize(vehicles, new JsonSerializerOptions() { WriteIndented= true });

            File.WriteAllText(pathVehicles, json);
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
    }
}