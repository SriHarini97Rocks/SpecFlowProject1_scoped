using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1_scoped.SeleniumDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Infrastructure;

[assembly:Parallelizable(ParallelScope.Fixtures)]

namespace SpecFlowProject1_scoped.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ISpecFlowOutputHelper _specFlowOutputHelper;
        private ScenarioContext _context;
        public Hooks(ScenarioContext context, ISpecFlowOutputHelper outputHelper)
        {
            _context= context;
            _specFlowOutputHelper = outputHelper;
        }
        [BeforeScenario] 
        public void BeforeScenario() {
        
            var driver=new RunningWebDriver().InitDriver();

            _context.Set<IWebDriver>(driver, "driver");
        }
        [AfterStep] 
        public void TakeScreenshotAfterStep()
        {

            var driver = _context.Get<IWebDriver>("driver");
            if(driver is ITakesScreenshot screenshot)
            {
                string filePath = _context.StepContext.StepInfo.Text+".png";
                screenshot.GetScreenshot().SaveAsFile(filePath);
                _specFlowOutputHelper.AddAttachment(filePath);
            }
           

        }
        [AfterScenario] 
        public void AfterScenario() {

            var driver = _context.Get<IWebDriver>("driver");
            driver.Quit();
        }
    }
}
