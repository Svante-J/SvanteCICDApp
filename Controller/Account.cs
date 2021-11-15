using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Text;

namespace SvanteSarahsApp.Controller
{
     abstract class Account
     { 
         private static int CurrentID { get; set; }
         private int ID;
        private string Name;
        private string Password;
        private string Role;
        private int Salary;
        private bool IsAdmin;

        public Account(string name, string password, int salary)
        {
            this.ID = GetNextID();
            this.Name = name;
            this.Password = password;
            this.Salary = salary;
        }
        protected int GetNextID() => ++CurrentID;
        //public int Id { get => id; set => id = value; }
        //public string Name { get => name; set => name = value; }
        //public int Salary { get => salary; set => salary = value; }
        //private bool IsAdmin { get => isAdmin; set => isAdmin = value; }
    }

  
}
