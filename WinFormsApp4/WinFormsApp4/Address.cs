namespace WinFormsApp4
{
    public class Address
    {
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public Country Country { get; set; }
    }

    public class Country
    {
        public string Name { get; set; }
        public string RegionCode { get; set; }
    }

    public class Experience
    {
        public string Company { get; set; }
        public ExperienceAddress Address { get; set; }

    }

    public class ExperienceAddress
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Detail { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Male { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Experience> Experiences { get; set; }
    }

}
