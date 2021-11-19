using System;
using System.Collections.Generic;
using System.Linq;

namespace SvanteSarahsApp.Controller
{
    public interface IAccount
    {
        public static int CurrentID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Salary { get; set; }

        public bool IsAdmin { get; set; }

        protected int GetNextID() => ++CurrentID;

        public static IAccount FindUser(string name, string password, List<IAccount> userList)
        {
            var query =
                from user in userList
                where
                (user.Name != null && user.Name.Contains(name)) ||
                (user.Password != null && user.Password.Contains(password))
                select user;

            return null;

        }

        public static void PrintAll(List<IAccount> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.Name + item.Role + item.Password);
            }
        }


    }


}
