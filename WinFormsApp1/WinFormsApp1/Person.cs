namespace WinFormsApp1
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateOnly Birthdate { get; set; }
        public bool Male { get; set; }

        public string Info
        {
            get
            {
                return $"{Name} {Surname} ({Age}) - {(Male ? "Bay" : "Bayan")}";
            }
        }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Age}) - {(Male ? "Bay" : "Bayan")}";
        }
    }
}
