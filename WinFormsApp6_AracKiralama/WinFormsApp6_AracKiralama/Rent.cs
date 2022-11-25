namespace WinFormsApp6_AracKiralama
{
    public class Rent
    {
        public string NameSurname { get; set; }
        public string TCNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal DownPayment { get; set; }
        public Vehicle Vehicle { get; set; }

        public int RentDay
        {
            get
            {
                return EndDate.Subtract(StartDate).Days;
            }
        }

        public decimal Total
        {
            get
            {
                return RentDay * Vehicle.DailyPrice;
            }
        }

        public override string ToString()
        {
            return $"{NameSurname} ({StartDate.ToShortDateString()} - {EndDate.ToShortDateString()}) - {RentDay} - {Total.ToString("C2")}";
        }
    }
}
