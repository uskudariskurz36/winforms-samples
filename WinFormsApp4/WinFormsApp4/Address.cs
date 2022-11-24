using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp4
{
    public class Address
    {
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public Country Country { get; set; }

        //public string Info
        //{
        //    get
        //    {
        //        return $"{Street} - {PostalCode} - {City}";
        //    }
        //}

        public override string ToString()
        {
            return $"{Street} - {PostalCode} - {City}";
        }
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
        // User Nesnesi oluşurken Name property si varsayılan "murat" değeri ile gelir.
        //public string Name { get; set; } = "murat";
        public string Name { get; set; } 
        public string Surname { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Male { get; set; }
        public List<Address> Addresses { get; set; } 
        public List<Experience> Experiences { get; set; }

        // User Nesnesi oluşurken bu property ler new lenir.
        //public List<Address> Addresses { get; set; } = new List<Address>();
        //public List<Experience> Experiences { get; set; } = new List<Experience>();


        public User()   // constructor
        {
            // User Nesnesi oluşurken bu property ler new lenir.
            Addresses = new List<Address>();
            Experiences = new List<Experience>();
        }
    }

}
