using System;
using System.Collections.Generic;
using System.Text;

namespace SvanteSarahsApp.Controller
{
    class Admin : IAccount
    {
        public static int CurrentID { get; set; }
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Role { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsAdmin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
   

    public Admin(string name, string password)
    {

        this.ID = GetNextID();
        this.Name = name;
        this.Password = password;
        this.Role = "clerk";
        this.Salary = 24000;
        this.IsAdmin = false;
    }
        public Admin()
        {
            this.ID = GetNextID();
        }
        protected int GetNextID() => ++CurrentID;

    }
}
