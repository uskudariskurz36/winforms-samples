namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text;
            person.Surname = txtSurname.Text;
            person.Age = (int)nudAge.Value;
            person.Male = rdbMale.Checked;
            person.Birthdate = DateOnly.FromDateTime(dtpBirthdate.Value);

            lstPeople.Items.Add(person);
        }

        private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPeople.SelectedIndex < 0)
                return;

            if (lstPeople.SelectedItem == null)
                return;

            //object selected1 = lstPeople.Items[lstPeople.SelectedIndex];
            Person selected1 = (Person)lstPeople.SelectedItem;

            txtName.Text = selected1.Name;
            txtSurname.Text = selected1.Surname;
            dtpBirthdate.Value = selected1.Birthdate.ToDateTime(TimeOnly.MinValue);
            nudAge.Value = selected1.Age;
            rdbMale.Checked = selected1.Male;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItem == null)
                return;

            lstPeople.Items.Remove(lstPeople.SelectedItem);
        }
    }
}