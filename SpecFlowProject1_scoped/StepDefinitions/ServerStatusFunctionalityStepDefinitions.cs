using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1_scoped.StepDefinitions
{
    [Binding]
    public class ServerStatusFunctionalityStepDefinitions
    {
        public WebDriverWait wait = null; 
        private readonly IWebDriver _driver;
        private readonly ScenarioContext _context;
        public ServerStatusFunctionalityStepDefinitions(ScenarioContext context)
        {
            _context = context;
            _driver = context.Get<IWebDriver>("driver");
            wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }

        [When(@"the orders tab of the site is clicked")]
        public void WhenTheOrdersTabOfTheSiteIsClicked()
        {
          
            Func<IWebDriver, IWebElement> func = new Func<IWebDriver, IWebElement>((IWebDriver driver) =>
            {
                return _driver.FindElement(By.XPath("//button[@routerlink='/dashboard/myorders']"));
            });
            IWebElement targetEle = wait.Until(func);
            targetEle.Click();
        }

        [Then(@"the total order should be (.*)")]
        public void ThenTheTotalOrderShouldBe(int p0)
        {
            Func<IWebDriver, IWebElement> func = new Func<IWebDriver, IWebElement>((IWebDriver driver) =>
            {
                return _driver.FindElement(By.XPath("//table[@class='table table-bordered table-hover ng-star-inserted']/tbody"));
            });
            IWebElement targetEle = wait.Until(func);
            
            int rows = targetEle.FindElements(By.TagName("tr")).Count;

            Assert.AreEqual(rows, p0);
        }
    }
}
