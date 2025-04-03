using OpenQA.Selenium;

namespace SwagLabsAutomation.Pages
{
    public class InventoryPage : BasePage
    {
        private By InventoryContainer => By.Id("inventory_container");
        private By ProductList => By.ClassName("inventory_item");
        private By FirstProductAddButton => By.CssSelector(".inventory_item:first-child button.btn_inventory");
        private By CartIcon => By.ClassName("shopping_cart_link");

        public InventoryPage(IWebDriver driver) : base(driver) { }

        public bool IsInventoryLoaded()
        {
            return IsVisible(InventoryContainer);
        }

        public int GetProductCount()
        {
            return driver.FindElements(ProductList).Count;
        }

        public void AddFirstProductToCart()
        {
            Click(FirstProductAddButton);
        }

        public void GoToCart()
        {
            Click(CartIcon);
        }
    }
}