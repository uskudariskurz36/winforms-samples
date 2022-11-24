using Ganss.Excel;
using QRCoder;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Product> _products = new List<Product>();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductName = txtProductName.Text,
                SerialNumber = txtSerialNumber.Text,
                Quantity = (int)nudQuantity.Value,
                UnitPrice = nudUnitPrice.Value,
                Continued = chkContinued.Checked,
                Discounted = chkDiscounted.Checked,
                DiscountRate = nudDiscountRate.Value,
            };
            _products.Add(product);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _products;

            GenerateQRCode(product.SerialNumber);
        }

        private void GenerateQRCode(string serialNumber)
        {
            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData data = generator.CreateQrCode(serialNumber, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            Bitmap bitmap = code.GetGraphic(20);

            pictureBox1.Image = bitmap;
        }

        private void chkDiscounted_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiscounted.Checked)
            {
                nudDiscountRate.Enabled = true;
            }
            else
            {
                nudDiscountRate.Enabled = false;
                nudDiscountRate.Value = 0;
            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            ExcelMapper excelMapper = new ExcelMapper();
            excelMapper.Save("products.xlsx", _products, "Products");

            MessageBox.Show("Kaydedildi.");
        }
    }
}