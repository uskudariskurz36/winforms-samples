using System.Text.Json;

namespace WinFormsApp6_AracKiralama
{
    public partial class frmBrands : Form
    {
        public frmBrands()
        {
            InitializeComponent();
        }

        private List<string> brands = new List<string>();
        public static string path = Application.StartupPath + "brands.json";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            brands.Add(txtName.Text);

            BindDataToListbox();
            SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz.");
                return;
            }

            brands[lstNames.SelectedIndex] = txtName.Text;
            BindDataToListbox();
            SaveData();
        }

        private void BindDataToListbox()
        {
            lstNames.DataSource = null;
            lstNames.DataSource = brands;
        }

        private void SaveData()
        {
            //JsonSerializerOptions options = CreateJsonSerializerOptions();
            //JsonSerializer.Serialize(brands, options);

            string json = JsonSerializer.Serialize(brands, CreateJsonSerializerOptions());
            File.WriteAllText(path, json);
        }

        private static JsonSerializerOptions CreateJsonSerializerOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;
            return options;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz.");
                return;
            }

            brands.RemoveAt(lstNames.SelectedIndex);

            BindDataToListbox();
            SaveData();
        }

        private void frmBrands_Load(object sender, EventArgs e)
        {
            List<string> list = ReadData();

            brands = list;
            BindDataToListbox();
        }

        public static List<string> ReadData()
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                List<string> list =
                    JsonSerializer.Deserialize<List<string>>(json, CreateJsonSerializerOptions());

                return list;
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
