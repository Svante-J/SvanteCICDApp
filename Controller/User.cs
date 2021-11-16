using System.Security.Cryptography.X509Certificates;

namespace SvanteSarahsApp.Controller
{
      class User : IAccount
    {
        public static int CurrentID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }
        public bool IsAdmin { get; set; }

        public User(string name, string password)
        {
            
            this.ID = GetNextID();
            this.Name = name;
            this.Password = password;
            this.Role = "clerk";
            this.Salary = 24000;
            this.IsAdmin = false;
        }

        public User()
        {
            this.ID = GetNextID();
        }

        public override string ToString()
        {
            return "Person: " + Name + " " + Password;
        }

        protected int GetNextID() => ++CurrentID;
    }
}