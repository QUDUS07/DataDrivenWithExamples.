using DataDrivenWithExamples.PageOject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DataDrivenWithExamples.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        RegistrationPage registrationPage;
        RegistrationStepDefinitions() 
        {
            registrationPage= new RegistrationPage();
        }

        [Given(@"I navigate ""([^""]*)""")]
        public void GivenINavigate(string website)
        {
           registrationPage.NavigateToWebSite(website);
        }

        [Given(@"I click on the SignUp")]
        public void GivenIClickOnTheSignUp()
        {
            registrationPage.ClickOnSignUp();
        }

        [Given(@"I enter Username text ""([^""]*)""")]
        public void GivenIEnterUsernameText(string username)
        {
            registrationPage.EnterUsername(username);
        }

        [Given(@"I enter Email text ""([^""]*)""")]
        public void GivenIEnterEmailText(string email)
        {
            registrationPage.EnterEmail(email);
        }

        [Given(@"I enter Password test ""([^""]*)""")]
        public void GivenIEnterPasswordTest(string password)
        {
            registrationPage.EnterPassword(password);
        }

        [When(@"I click on SignUp button")]
        public void WhenIClickOnSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsSettingsDisplayed);
        }
    }
}
