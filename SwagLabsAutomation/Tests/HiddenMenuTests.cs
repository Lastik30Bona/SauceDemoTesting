using NUnit.Framework;
using SwagLabsAutomation.Pages;

namespace SwagLabsAutomation.Tests
{
    public class HiddenMenuTests : BaseTest
    {
        [Test]
        public void Logout_ShouldRedirectToLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            var loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");

            var menu = new HiddenMenuPage(driver);
            menu.Logout();

            Assert.That(driver.Url, Does.Contain("saucedemo.com"), "Logout did not redirect to login page.");
        }
    }
}