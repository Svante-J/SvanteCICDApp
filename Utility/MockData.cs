using SvanteSarahsApp.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SvanteSarahsApp.Utility
{
    public class MockData
    {
        
        public static List<IAccount> MockList()
        {
            List<IAccount> mockList = new List<IAccount>();
            mockList.Add(new User()
            {
                Name = "",
                Password = "myPassword1234",
                Role = "Hygien Tekniker",
                Salary = 24000
            });
            mockList.Add(new Admin()
            {
                Name = "admin1",
                Password = "admin1234",
                Role = "Admin",
                IsAdmin = true

            }) ;

            return mockList;
        }
       
    }
}
