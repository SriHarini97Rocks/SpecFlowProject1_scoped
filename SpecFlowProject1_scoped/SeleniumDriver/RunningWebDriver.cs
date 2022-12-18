using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1_scoped.SeleniumDriver
{
    public class RunningWebDriver
    {
       
        private readonly IWebDriver _driver;
    
        public IWebDriver InitDriver()
        {
            var driver = new ChromeDriver(@"F:\eclipseprojects\browsers exe");
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
