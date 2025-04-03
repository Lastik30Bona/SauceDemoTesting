using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SwagLabsAutomation.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }

        public void Click(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

        public void Type(By locator, string text)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);
        }

        public IWebElement Find(By locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public bool IsVisible(By locator)
        {
            wait.Until(driver => driver.FindElement(locator).Displayed);
            return true;
        }
    }   
}
