using SvanteSarahsApp.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace SvanteSarahsApp.Model
{
    public static class UserData
    {
        private static List<User> UserList;

        //public static void SetUserList(List<User> fsdfs)
        //{
        //    UserList = fsdfs;
        //}

        internal static List<User> userList { get => UserList; set => UserList = value; }
    }
}
