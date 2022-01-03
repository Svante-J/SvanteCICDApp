using SvanteSarahsApp.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SvanteSarahsApp.Utility
{
    public class LoggedInUser
    {
        public static IAccount ActiveUser { get; set; }


        public static IAccount GetActiveUser()
        {
            return ActiveUser;
        }
        public static void SetActiveUser(IAccount account)
        {
            ActiveUser = account;
        }
    }
}
