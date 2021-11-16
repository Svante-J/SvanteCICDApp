using SvanteSarahsApp.Controller;
using SvanteSarahsApp.Utility;
using System;
using System.Collections.Generic;
using System.Text;


namespace SvanteSarahsApp.View
{

    public class MainView
    {
        
        public void Run()
        {
            List<object> employeeList = new List<object>();
            Console.WriteLine("Login");
            User user = new User("banan", "1234banan");
            Console.WriteLine(user.ToString());
            List<object> mockList = new List<object>();
            //var reciver = MockData.Caman();
            var emplyeeList = MockData.MockList();

           
            // logg in or register
            
        }
    }
}
