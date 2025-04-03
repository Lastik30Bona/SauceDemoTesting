using OpenQA.Selenium;

namespace SwagLabsAutomation.Pages
{
    public class CheckoutPage : BasePage
    {
        private By FirstName => By.Id("first-name");
        private By LastName => By.Id("last-name");
        private By PostalCode => By.Id("postal-code");
        private By ContinueButton => By.Id("continue");
        private By FinishButton => By.Id("finish");
        private By ConfirmationMessage => By.ClassName("complete-header");

        public CheckoutPage(IWebDriver driver) : base(driver) { }

        public void FillCheckoutForm(string first, string last, string zip)
        {
            Type(FirstName, first);
            Type(LastName, last);
            Type(PostalCode, zip);
            Click(ContinueButton);
        }

        public void FinishOrder()
        {
            Click(FinishButton);
        }

        public bool IsOrderConfirmed()
        {
            return IsVisible(ConfirmationMessage);
        }
    }
}
