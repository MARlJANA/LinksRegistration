using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinksRegistration
{
    class TC_RB052_Registration
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver(@"C:/Automation");
        }

        [Test]
        public void Test()
        {
            string pageUrl = "https://www.links.hr/hr/register";
            Console.Write("Step 1: Navigate to 'https://www.links.hr/hr/register'");
            IWebElement elePageTitle = driver.FindElement(By.ClassName("page-title"));
            driver.Navigate().GoToUrl(pageUrl);
            string sCurrentUrl = driver.Url;

            Assert.That(Map.UI.LinksMap.Register.sPageUrl.Equals(sCurrentUrl));
            Assert.That(elePageTitle.Displayed);
            //Assert.That(Map.UI.LinksMap.Register.elePravnaOsoba.Displayed);
            //Assert.That(Map.UI.LinksMap.Register.elePravnaOsoba.Enabled);
            //Assert.That(!Map.UI.LinksMap.Register.elePravnaOsoba.Selected);

        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}