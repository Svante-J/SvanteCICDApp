using System;
using System.Collections.Generic;
using System.Text;

namespace SvanteSarahsApp.View
{
    public class MenuOptions
    {
        public static void Welcome()
        {
            Console.WriteLine("\t Quinyx 2.0");
            Console.WriteLine("\t Welcome");

            Console.WriteLine("\nPlease enter username for loggin or [Q] ti quit");
        }

        public static void LoggIn()
        {
            string input = Console.ReadLine().ToLower();

            if(input == "q" )
            {
                // boolMethod()
            }
            if(Controller.User.FindUser())
            {

            }
            else
            {
                Console.WriteLine("Username does not exist");
            }
        }


    }
}
