using OpenQA.Selenium;

namespace SwagLabsAutomation.Pages
{
    public class HiddenMenuPage : BasePage
    {
        private By MenuButton => By.Id("react-burger-menu-btn");
        private By LogoutLink => By.Id("logout_sidebar_link");

        public HiddenMenuPage(IWebDriver driver) : base(driver) { }

        public void Logout()
        {
            Click(MenuButton);
            Click(LogoutLink);
        }
    }
}