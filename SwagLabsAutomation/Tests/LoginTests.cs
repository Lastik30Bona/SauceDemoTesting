using NUnit.Framework;
using SwagLabsAutomation.Pages;

namespace SwagLabsAutomation.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void Login_WithValidCredentials_ShouldRedirectToInventory()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            var loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");

            Assert.That(driver.Url, Does.Contain("inventory"), "Login was not successful – inventory page not loaded.");
        }
        [Test]
        public void Login_WithInvalidCredentials_ShouldShowError()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            var loginPage = new LoginPage(driver);
            loginPage.Login("wrong_user", "wrong_pass");

            Assert.IsTrue(loginPage.IsErrorVisible(), "Error message was not displayed for invalid login.");
        }

    }
}