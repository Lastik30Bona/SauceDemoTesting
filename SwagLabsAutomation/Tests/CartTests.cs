using SwagLabsAutomation.Pages;

namespace SwagLabsAutomation.Tests
{
    public class CartTests : BaseTest
    {
        [Test]
        public void AddProductToCart_ShouldShowInCart()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            var loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddFirstProductToCart();
            inventoryPage.GoToCart();

            var cartPage = new CartPage(driver);
            Assert.IsTrue(cartPage.IsCartNotEmpty(), "Cart is empty after adding product.");
        }
    }
}