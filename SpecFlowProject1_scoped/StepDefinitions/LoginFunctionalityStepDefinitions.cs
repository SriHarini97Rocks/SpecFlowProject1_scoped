using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1_scoped.StepDefinitions
{
    [Binding]
    public class LoginFunctionalityStepDefinitions
    {
        private readonly IWebDriver _driver;
        private WebDriverWait wait = null;
        private readonly ScenarioContext _scenarioContext;
        public LoginFunctionalityStepDefinitions(ScenarioContext context) {
        
        _scenarioContext= context;
            _driver=_scenarioContext.Get<IWebDriver>("driver");
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }
        [Scope(Tag = "smoke")]
        [Given(@"the login url of the ecommnerce site")]
        public void GivenTheLoginUrlOfTheEcommnerceSite()
        {
            _driver.Url = "https://rahulshettyacademy.com/client";
        }     

        
        [Scope(Tag = "smoke")]
        [Then(@"the valid username and password is entered")]
        public void ThenTheValidUsernameAndPasswordIsEntered()
        {
            _driver.FindElement(By.Id("userEmail")).SendKeys("lastfirst@gmail.com");
            _driver.FindElement(By.Id("userPassword")).SendKeys("nE4vyaW3P@m@PwJ");
        }
        [Scope(Tag = "smoke")]
        [Then(@"clicked on login button")]
        public void ThenClickedOnLoginButton()
        {
            _driver.FindElement(By.Id("login")).Click();
        }

        [Then(@"the page should be redirected to dashboard page")]
        public void ThenThePageShouldBeRedirectedToDashboardPage()
        {
            var title = _driver.Title;
            Assert.AreEqual(title, "Let's Shop");
        }
        [Then(@"the invalid username and password is entered")]
        public void ThenTheInvalidUsernameAndPasswordIsEntered()
        {
            _driver.FindElement(By.Id("userEmail")).SendKeys("lastfirs1t@gmail.com");
            _driver.FindElement(By.Id("userPassword")).SendKeys("nE4vyaW3P@m@PwJ");
        }

        [Then(@"the toaster alert should be displayed")]
        public void ThenTheToasterAlertShouldBeDisplayed()
        {
            Func<IWebDriver, IWebElement> func = new Func<IWebDriver, IWebElement>((IWebDriver driver) =>
            {
                return _driver.FindElement(By.XPath("//div[@role='alertdialog']"));
            });
            IWebElement targetEle = wait.Until(func);
            Assert.AreEqual(targetEle.Text, "Incorrect email or password.");
        }

    }
}
