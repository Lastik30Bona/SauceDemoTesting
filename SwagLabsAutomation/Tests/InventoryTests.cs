using SwagLabsAutomation.Pages;

namespace SwagLabsAutomation.Tests
{
    public class InventoryTests : BaseTest
    {
        [Test]
        public void Inventory_ShouldShowProducts()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            var loginPage = new LoginPage(driver);
            loginPage.Login("standard_user", "secret_sauce");

            var inventoryPage = new InventoryPage(driver);

            Assert.IsTrue(inventoryPage.IsInventoryLoaded(), "Inventory page did not load correctly.");
            Assert.That(inventoryPage.GetProductCount(), Is.GreaterThan(0), "No products found on inventory page.");
        }
    }
}