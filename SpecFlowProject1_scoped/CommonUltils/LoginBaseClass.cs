using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1_scoped.CommonUltils
{
    public class LoginBaseClass
    {
        private readonly IWebDriver _driver;
        public LoginBaseClass(ScenarioContext context) {
        _driver= context.Get<IWebDriver>("driver");
        }
        [Given(@"the login url of the phptravels site")]
        public void GivenTheLoginUrlOfThePhptravelsSite()
        {
            _driver.Url = "https://phptravels.org/login";
        }

        [When(@"the valid username and password is entered")]
        public void WhenTheValidUsernameAndPasswordIsEntered()
        {
            _driver.FindElement(By.Id("inputEmail")).SendKeys("firstnameslastnames@gmail.com");
            _driver.FindElement(By.Id("inputPassword")).SendKeys("seGe4g5erihn");
            Thread.Sleep(15000);
        }

        [When(@"clicked on login button")]
        public void WhenClickedOnLoginButton()
        {
            _driver.FindElement(By.Id("login")).Click();
        }

        
    }
}
