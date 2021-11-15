using System.Security.Cryptography.X509Certificates;

namespace SvanteSarahsApp.Controller
{
     class User : Account
    {
        public User()
        {
            PublicKey User(string name, string password, int salary)
            {
                this.ID = GetNextID();
                this.Name = name;
                this.Password = password;
                this.Salary = salary;
            }

        }
    }
}