using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Text;

namespace SvanteSarahsApp.Controller
{
     public interface IAccount
     { 
        public static int CurrentID { get; set; }
         public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        
        public bool IsAdmin { get; set; }
        
        protected int GetNextID() => ++CurrentID;

        public static void PrintAll(List<IAccount> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Name + item.Role + item.Password);  
            }
        }

       

    }

  
}
