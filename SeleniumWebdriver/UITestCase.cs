using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinksRegistration
{
    public class UITestCase
    {
        public UITestCase()
        {
            SetupWebDriver();
        }

        private void SetupWebDriver()
        {
            try
            {
                if (Driver.WebDriver == null)
                {
                    SeleniumSetup setup = new SeleniumSetup();

                    setup.SetupWebDriver();

                    Console.WriteLine("Driver setup complete");
                }
                else
                {
                    Console.WriteLine("Driver already running");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);

                return;
            }
        }
    }
}
