using SvanteSarahsApp.Controller;
using System.Collections.Generic;

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
