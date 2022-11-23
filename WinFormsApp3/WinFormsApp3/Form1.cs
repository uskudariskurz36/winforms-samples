using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Todo> todos = new List<Todo>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtKonu.Text) || string.IsNullOrWhiteSpace(txtKonu.Text))
            if (txtKonu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Konu bo� b�rak�lamaz!", "Uyar�!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                picAlertKonu.Visible = true;
                errorProvider1.SetError(txtKonu, "Konu bo� b�rak�lamaz!");

                return;
            }
            else
            {
                picAlertKonu.Visible = false;
                errorProvider1.SetError(txtKonu, null);
            }


            //Todo todo = new Todo();
            Todo todo = new();
            todo.Id = Guid.NewGuid();
            todo.Subject = txtKonu.Text;
            todo.Detail = txtDetay.Text;
            todo.DueDate = dtpSonTarih.Value;
            todo.IsCompleted = chkTamamlandi.Checked;

            todos.Add(todo);    // Generic listeye ekledik.


            //LoadListboxMethod1();
            LoadListboxMethod2();
        }

        private void LoadListboxMethod2()
        {
            lstYapilacaklar.DataSource = null;
            lstYapilacaklar.DisplayMember = nameof(Todo.Subject);
            lstYapilacaklar.ValueMember = nameof(Todo.Id);
            lstYapilacaklar.DataSource = todos;
        }

        private void LoadListboxMethod1()
        {
            // �nce listbox � temizledik.
            lstYapilacaklar.Items.Clear();

            // Generic listedeki t�m todo lar� listbox a aktard�k.
            foreach (Todo item in todos)
            {
                lstYapilacaklar.Items.Add(item);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            txtKonu.Clear();
            txtDetay.Clear();
            dtpSonTarih.Value = DateTime.Now;
            chkTamamlandi.Checked = false;
        }

        TextBox currentTextbox = null;

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            //txtKonu.Cut();
            currentTextbox.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            //txtKonu.Copy();
            currentTextbox.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            //txtKonu.Paste();
            currentTextbox.Paste();
        }

        //private void txtKonu_MouseClick(object sender, MouseEventArgs e)
        //{
        //    currentTextbox = txtKonu;
        //}

        //private void txtDetay_MouseClick(object sender, MouseEventArgs e)
        //{
        //    currentTextbox = txtDetay;
        //}

        private void textbox_MouseClick(object sender, MouseEventArgs e)
        {
            currentTextbox = (TextBox)sender;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            // subject|detail|23.12.2022 23:00|true|ADE567-ASS1234-2323...

            List<string> lines = new List<string>(todos.Count);

            foreach (Todo item in todos)
            {
                string line = $"{item.Subject}|{item.Detail}|{item.DueDate}|{item.IsCompleted}|{item.Id}";
                lines.Add(line);
            }

            //string path = Application.StartupPath + "\\data.txt";
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\data.txt";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Verileri Kaydet";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Filter = "Metin Belgeleri(*.txt)|*.txt|Todo App Format(*.todo)|*.todo";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, lines);
                MessageBox.Show("Veriler kaydedildi.", "Kaydetme Yap�ld�");
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();   // Kullan�c�ya daha �nce kaydedilen dosya se�tirilir.
            openFileDialog.Title = "Verileri A�";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Metin Belgeleri(*.txt)|*.txt|Todo App Format(*.todo)|*.todo";

            DialogResult result = openFileDialog.ShowDialog();  // Open FileDialog a��l�r.

            if (result == DialogResult.OK)                  // E�er dosya se�ip Tamam d��mesine bast� ise;
            {
                string path = openFileDialog.FileName;      // Dosya konumu al�n�r.
                string[] lines = File.ReadAllLines(path);   // Dosyadan t�m sat�rlar string olarak okunur.

                todos.Clear();                              // Elimizdeki liste temizlenir.

                foreach (string line in lines)              // T�m okunan sat�rlar i�in d�n�l�r.
                {
                    string[] splitted = line.Split("|");    // Sat�r verisi par�alan�r.
                                                            // subject|detail|23.12.2022 23:00|true
                    Todo todo = new();                      // Todo nesnesi olu�turulur.
                    todo.Subject = splitted[0];
                    todo.Detail = splitted[1];
                    todo.DueDate = DateTime.Parse(splitted[2]);
                    todo.IsCompleted = bool.Parse(splitted[3]);
                    todo.Id = Guid.Parse(splitted[4]);

                    todos.Add(todo);                        // Listeye olu�turulan Todo nesnesi eklenir.
                }

                LoadListboxMethod2();                       // liste den Listbox doldurulur.
            }
        }
    }
}