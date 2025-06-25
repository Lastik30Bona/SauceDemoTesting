using NUnit.Framework;
using SwagLabsAutomation.Pages;
using SwagLabsAutomation.Helpers;

namespace SwagLabsAutomation.Tests
{
    public class LoginTests : BaseTest
    {

        // Legacy tests using hardcoded credentials.
        // These are commented out to avoid duplication since we're now using data-driven tests via JSON.

        //[Test]
        //public void Login_WithValidCredentials_ShouldRedirectToInventory()
        //{
        //    driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        //    var loginPage = new LoginPage(driver);
        //    loginPage.Login("standard_user", "secret_sauce");

        //    Assert.That(driver.Url, Does.Contain("inventory"), "Login was not successful – inventory page not loaded.");
        //}
        //[Test]
        //public void Login_WithInvalidCredentials_ShouldShowError()
        //{
        //    driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        //    var loginPage = new LoginPage(driver);
        //    loginPage.Login("wrong_user", "wrong_pass");

        //    Assert.IsTrue(loginPage.IsErrorVisible(), "Error message was not displayed for invalid login.");
        //}


        // Parameterized test using JSON data source for both positive and negative login scenarios.

        [Test, TestCaseSource(typeof(TestDataLoader), nameof(TestDataLoader.GetLoginTestData))]
        public void LoginTest_WithJsonData(LoginData data)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            var loginPage = new LoginPage(driver);
            loginPage.Login(data.Username, data.Password);

            if (data.ShouldLoginSucceed)
            {
                Assert.That(driver.Url, Does.Contain("inventory"));
            }
            else
            {
                Assert.That(loginPage.IsErrorVisible(), Is.True);
            }
        }
    }
}



