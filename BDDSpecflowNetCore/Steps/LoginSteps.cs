using BDDSpecflowNetCore.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDDSpecflowNetCore.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        LoginPage loginPage = null;

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            ChromeOptions optionsChr = new ChromeOptions();
            optionsChr.AddArgument("--headless");

            IWebDriver webDriver = new ChromeDriver(optionsChr);
            
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            loginPage = new LoginPage(webDriver);
        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            loginPage.ClickLogin();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            loginPage.Login((string)data.UserName,(string)data.Password);
        }

        [When(@"I click button")]
        public void WhenIClickButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            Assert.That(loginPage.IsEmployeeDetailsExist(), Is.True);
        }

    }
}
