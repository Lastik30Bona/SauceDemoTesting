using OpenQA.Selenium;

namespace SwagLabsAutomation.Pages
{
    public class CartPage : BasePage
    {
        private By CartItem => By.ClassName("cart_item");
        private By CheckoutButton => By.Id("checkout");

        public CartPage(IWebDriver driver) : base(driver) { }

        public bool IsCartNotEmpty()
        {
            return driver.FindElements(CartItem).Count > 0;
        }

        public void GoToCheckout()
        {
            Click(CheckoutButton);
        }
    }
}