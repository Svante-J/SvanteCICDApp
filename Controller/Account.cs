using System;
using System.Collections.Generic;
using System.Text;

namespace SvanteSarahsApp.Controller
{
     abstract class Account
    {
        private string name;
        private int salary;
        private bool isAdmin;

        public Account()
        {

        }

        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        private bool IsAdmin { get => isAdmin; set => isAdmin = value; }
    }

  
}
