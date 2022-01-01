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
            Console.WriteLine("enter username");
            string input = Console.ReadLine().ToLower();
            Console.WriteLine("enter password");
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
                //            a.Allt som användare kan göra förutom att ta bort sin egna användare.
                //b.Se aktuella användare och deras lösenord.
                //c.Admin skall kunna skapa användare lokalt. Användare skall ha användarnamn och
                //lösenord, dessa måste bestå av både text och siffror.
                //d.Ta bort användare från systemet genom att skriva ett användarnamn och tillhörande
                //lösenord.
                        
        }
        public static void UserMenu()
        {
            Console.WriteLine("user stuff");
            //            a.Se aktuell lön.
            //b.Roll i företaget.
            //c.Ta bort sin egna användare genom att skriva in sitt användarnamn och lösenord.
        }
    }
}
