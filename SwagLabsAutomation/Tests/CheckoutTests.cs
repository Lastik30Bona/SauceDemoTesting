using SwagLabsAutomation.Pages;

namespace SwagLabsAutomation.Tests
{
    public class CheckoutTests : BaseTest
    {
        [Test]
        public void Checkout_WithValidData_ShouldCompleteOrder()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            var loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);
            inventoryPage.AddFirstProductToCart();
            inventoryPage.GoToCart();

            var cartPage = new CartPage(driver);
            cartPage.GoToCheckout();

            var checkoutPage = new CheckoutPage(driver);
            checkoutPage.FillCheckoutForm("John", "Doe", "12345");
            checkoutPage.FinishOrder();

            Assert.IsTrue(checkoutPage.IsOrderConfirmed(), "Order was not confirmed successfully.");
        }
    }
}
