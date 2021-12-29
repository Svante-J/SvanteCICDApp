namespace SvanteSarahsApp.Utility
{
    public static class Validator
    {
        private static bool MainMenu { get; set; }
        private static bool UserMenu { get; set; }
        private static bool AdminMenu { get; set; }


        public static bool GetMainMenuValuation()
        {
            return MainMenu;
        }
        public static bool GetUserMenuValuation()
        {
            return UserMenu;
        }
        public static bool GetAdminMenuValuation()
        {
            return AdminMenu;
        }

        public static void SetMainMenuValuation(bool value)
        {
            MainMenu = value;
        }
        public static void SetUserMenuValuation(bool value)
        {
            UserMenu = value;
        }
        public static void SetAdminMenuValuation(bool value)
        {
            AdminMenu = value;
        }


    }
}
