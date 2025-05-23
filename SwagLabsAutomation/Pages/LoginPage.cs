﻿using OpenQA.Selenium;

namespace SwagLabsAutomation.Pages
{
    public class LoginPage : BasePage
    {
        private By UsernameInput => By.Id("user-name");
        private By PasswordInput => By.Id("password");
        private By LoginButton => By.Id("login-button");
        private By ErrorMessage => By.CssSelector("h3[data-test='error']");

        public LoginPage(IWebDriver driver) : base(driver) { }

        public void Login(string username, string password)
        {
            Type(UsernameInput, username);
            Type(PasswordInput, password);
            Click(LoginButton);
        }

        public bool IsErrorVisible()
        {
            return IsVisible(ErrorMessage);
        }
    }
}