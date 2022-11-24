namespace WinFormsApp5
{
    public class Product
    {
        public string ProductName { get; set; }
        public string SerialNumber { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Continued { get; set; }
        public bool Discounted { get; set; }
        public decimal DiscountRate { get; set; }
    }
}
