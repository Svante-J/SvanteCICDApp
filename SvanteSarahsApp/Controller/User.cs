using System;
using System.Collections.Generic;

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

        internal static bool FindUser(string name, string password, List<User> userList)
        {
            return false;
        }

        public User()
        {
            this.ID = GetNextID();
        }

        public static void PrintAll(List<IAccount> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Name + item.Role + item.Password);
            }
        }

        public override string ToString()
        {
            return "Person: " + Name + " " + Password;
        }

        protected int GetNextID() => ++CurrentID;
    }
}