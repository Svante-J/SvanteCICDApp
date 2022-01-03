using SvanteSarahsApp.Controller;
using System.Collections.Generic;

namespace SvanteSarahsApp.Utility
{
    public class MockData
    {
        public static List<IAccount> mockList;
        public static List<IAccount> FillMockList()
        {
            List<IAccount> mockList = new List<IAccount>();
            mockList.Add(new User()
            {
                Name = "ulla",
                Password = "mypassword1234",
                Role = "Hygien-Tekniker",
                Salary = 24000
            });
            mockList.Add(new Admin()
            {
                Name = "admin1",
                Password = "admin1234",
                Role = "Admin",
                IsAdmin = true

            });

            return mockList;
        }

    }
}
