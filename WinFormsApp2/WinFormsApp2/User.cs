namespace WinFormsApp2
{
    public class User
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Category { get; set; }
        public string EnglishLevel { get; set; }
        public bool SSCSharp { get; set; }
        public bool SSSql { get; set; }
        public bool SSWinform { get; set; }
        public bool SSAspnet { get; set; }
        public string SocialUrl1 { get; set; }
        public string SocialUrl2 { get; set; }
        public string SocialUrl3 { get; set; }

        public override string ToString()
        {
            return $"{FullName}({Username})";
        }
    }
}
