using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1_scoped.StepDefinitions
{
    [Binding]
    public class ServerStatusFunctionalityStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly ScenarioContext _context;
        public ServerStatusFunctionalityStepDefinitions(ScenarioContext context)
        {
            _context = context;
            _driver = context.Get<IWebDriver>("driver");
        }


        [When(@"the server status url of the site is visited")]
        public void WhenTheServerStatusUrlOfTheSiteIsVisited()
        {

            _driver.Url = "https://phptravels.org/serverstatus.php";
        }

        [Then(@"the no error message should appear")]
        public void ThenTheNoErrorMessageShouldAppear()
        {
            var msg = _driver.FindElement(By.XPath("//div[contains(@class,'alert-success')]")).Text;
            Assert.AreEqual(msg, "There are no Open Network Issues Currently");
        }
    }
}
