using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinksRegistration
{
    public class Driver
    {

        private static IWebDriver _Driver;

        public static IWebDriver WebDriver
        {
            get
            {
                return _Driver;
            }

            set
            {
                _Driver = value;
            }
        }
    }
}
