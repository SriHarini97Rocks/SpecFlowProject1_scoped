using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1_scoped.StepDefinitions
{
    [Binding]
    public class LoginFunctionalityStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly ScenarioContext _scenarioContext;
        public LoginFunctionalityStepDefinitions(ScenarioContext context) {
        
        _scenarioContext= context;
            _driver=_scenarioContext.Get<IWebDriver>("driver");
        }
       
        [Given(@"the login url of the phptravels site")]
        public void GivenTheLoginUrlOfThePhptravelsSite()
        {
            _driver.Url = "https://phptravels.org/login";
        }
      
        [Then(@"the valid username and password is entered")]
        public void ThenTheValidUsernameAndPasswordIsEntered()
        {
            _driver.FindElement(By.Id("inputEmail")).SendKeys("firstnameslastnames@gmail.com");
            _driver.FindElement(By.Id("inputPassword")).SendKeys("seGe4g5erihn");
            Thread.Sleep(15000);
        }
       
        [Then(@"clicked on login button")]
        public void ThenClickedOnLoginButton()
        {
            _driver.FindElement(By.Id("login")).Click();
        }

        [Then(@"the page should be redirected to clientarea page")]
        public void ThenThePageShouldBeRedirectedToClientareaPage()
        {
            var title = _driver.Title;
            Assert.AreEqual(title, "Client Area - PHPTRAVELS");
        }
    }
}
