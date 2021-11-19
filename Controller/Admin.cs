using System;
using System.Collections.Generic;
using System.Text;

namespace SvanteSarahsApp.Controller
{
    class Admin : IAccount
    {
        public static int CurrentID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }

        public bool IsAdmin { get; set; }

        public Admin(string name, string password)
    {

        this.ID = GetNextID();
        this.Name = name;
        this.Password = password;
        this.Role = "clerk";
        
        this.IsAdmin = false;
    }
        public Admin()
        {
            this.ID = GetNextID();
        }
        protected int GetNextID() => ++CurrentID;

    }
}
