using System.Text.Json;

namespace WinFormsApp6_AracKiralama
{
    public partial class frmModels : Form
    {
        public frmModels()
        {
            InitializeComponent();
        }

        private List<string> models = new List<string>();
        public static string path = Application.StartupPath + "models.json";

        private void frmModels_Load(object sender, EventArgs e)
        {
            List<string> list = ReadData();
            models = list;

            BindDataToListbox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            models.Add(txtName.Text);

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

            models[lstNames.SelectedIndex] = txtName.Text;
            BindDataToListbox();
            SaveData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz.");
                return;
            }

            models.RemoveAt(lstNames.SelectedIndex);

            BindDataToListbox();
            SaveData();
        }

        private void BindDataToListbox()
        {
            lstNames.DataSource = null;
            lstNames.DataSource = models;
        }

        private void SaveData()
        {
            //JsonSerializerOptions options = CreateJsonSerializerOptions();
            //JsonSerializer.Serialize(brands, options);

            string json = JsonSerializer.Serialize(models, CreateJsonSerializerOptions());
            File.WriteAllText(path, json);
        }

        private static JsonSerializerOptions CreateJsonSerializerOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;
            return options;
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
