using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinksRegistration
{
    public class SeleniumSetup
    {
        public void SetupWebDriver(IWebDriver CustomWebDriver = null)
        {
            if (CustomWebDriver == null)
            {
                Driver.WebDriver = new ChromeDriver(@"C:\Automation");
            }
            else
            {
                Driver.WebDriver = CustomWebDriver;
            }

            Driver.WebDriver.Manage().Window.Maximize();
        }
    }
}
