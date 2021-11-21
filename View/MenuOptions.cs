using SvanteSarahsApp.Utility;
using System;

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
            string passwordInput = Console.ReadLine().ToLower();// metod

            if (input == "q")
            {
                Validator.SetMainMenuValuation(false);
                Console.WriteLine("Good bye!");
            }


            if (Controller.IAccount.FindUser(input, passwordInput, MockData.mockList))
            {
                if (LoggedInUser.ActiveUser.IsAdmin)
                {
                    Validator.SetMainMenuValuation(false);
                    Validator.SetAdminMenuValuation(true);
                    //MenuOptions.AdminMenu();
                }
                else if(!LoggedInUser.ActiveUser.IsAdmin)
                {
                    Validator.SetMainMenuValuation(false);
                    Validator.SetUserMenuValuation(true);

                }
            }


            else
            {
                Console.WriteLine("Username does not exist");
            }
        }

        public static void AdminMenu()
        {
            Console.WriteLine("admin stuff");
        }
        public static void UserMenu()
        {
            Console.WriteLine("user stuff");
        }
    }
}
