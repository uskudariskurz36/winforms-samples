namespace WinFormsApp6_AracKiralama
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int KM { get; set; }
        public int Year { get; set; }
        public decimal DailyPrice { get; set; }
        public bool IsRent { get; set; }
        public string ImagePath { get; set; }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year})";
        }
    }
}
