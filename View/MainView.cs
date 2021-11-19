using SvanteSarahsApp.Utility;


namespace SvanteSarahsApp.View
{

    public class MainView
    {

        public void Run()
        {
            MockData.mockList = MockData.FillMockList();// användare o Admin
            MenuOptions.Welcome();

            Validator.SetMainMenuValuation(true);
            while (Validator.GetMainMenuValuation())
            {
                MenuOptions.LoggIn();

            }


        }
    }
}
