using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BDDSpecflowNetCore.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click button")]
        public void WhenIClickButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see Employee details link")]
        public void ThenIShouldSeeEmployeeDetailsLink()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
