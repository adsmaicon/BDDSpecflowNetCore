using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDDSpecflowNetCore.Pages
{
    class LoginPage
    {
        public IWebDriver WebDriver { get; }
        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        //UI elements
        public IWebElement lnkLogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement txtUsername => WebDriver.FindElement(By.Name("UserName"));
        public IWebElement txtPassword => WebDriver.FindElement(By.Name("Password"));
        public IWebElement btnLogin => WebDriver.FindElement(By.CssSelector(".btn-default"));
        public IWebElement lnkEmployeeDetails => WebDriver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => lnkLogin.Click();

        public void Login(string userName, string password)
        {
            txtUsername.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLoginButton() => btnLogin.Submit();
        public bool IsEmployeeDetailsExist() => lnkEmployeeDetails.Displayed;
    }
}
