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

        public User(string name, string password, int salary)
        {
            this.ID = GetNextID();
            this.Name = name;
            this.Password = password;
            this.Salary = salary;
            this.IsAdmin = false;
        }

        protected int GetNextID() => ++CurrentID;
    }
}