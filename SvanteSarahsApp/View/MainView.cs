using SvanteSarahsApp.Utility;


namespace SvanteSarahsApp.View
{

    public class MainView
    {

        public void Run()
        {
            MockData.mockList = MockData.FillMockList();// användare och Admin
            MenuOptions.Welcome();

            Validator.SetMainMenuValuation(true);
            while (Validator.GetMainMenuValuation())
            {
                MenuOptions.LoggIn();

            }

            while (Validator.GetAdminMenuValuation())
            {
                MenuOptions.AdminMenu();
            }

            while (Validator.GetUserMenuValuation())
            {
                MenuOptions.UserMenu();
            }

        }
    }
}
