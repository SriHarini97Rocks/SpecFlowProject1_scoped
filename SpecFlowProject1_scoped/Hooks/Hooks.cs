using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1_scoped.SeleniumDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly:Parallelizable(ParallelScope.Fixtures)]

namespace SpecFlowProject1_scoped.Hooks
{
    [Binding]
    public class Hooks
    {
        private ScenarioContext _context;
        public Hooks(ScenarioContext context)
        {
            _context= context;
        }
        [BeforeScenario] 
        public void BeforeScenario() {
        
            var driver=new RunningWebDriver().InitDriver();

            _context.Set<IWebDriver>(driver, "driver");
        }

        [AfterScenario] 
        public void AfterScenario() {

            var driver = _context.Get<IWebDriver>("driver");
            driver.Quit();
        }
    }
}
