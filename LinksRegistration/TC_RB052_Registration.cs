using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
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
            driver = new ChromeDriver(@"C:\Automation");
        }

        [Test]
        public void Test()
        {
            Console.WriteLine("Step 1: Navigate to 'https://www.links.hr/hr/register'");
            driver.Navigate().GoToUrl(Map.UI.LinksMap.Register.sPageUrl);
            IWebElement elePageTitle = driver.FindElement(By.ClassName("page-title"));
            IWebElement elePravnaOsobaCheckbox = driver.FindElement(By.Id("RegisterAsCompany"));
            string sCurrentUrl = driver.Url;

            Assert.That(Map.UI.LinksMap.Register.sPageUrl.Equals(sCurrentUrl));

            Assert.That(elePageTitle.Displayed);

            Assert.That(elePravnaOsobaCheckbox.Displayed);
            Assert.That(elePravnaOsobaCheckbox.Enabled);
            Assert.That(!elePravnaOsobaCheckbox.Selected);

            IWebElement eleVasiOsobniPodaciTitle = driver.FindElement(By.XPath("//strong[contains(text(),'Vaši osobni podaci')]"));
            Assert.That(eleVasiOsobniPodaciTitle.Displayed);

            IWebElement eleRodLabel = driver.FindElement(By.XPath("//label[normalize-space()='Rod:']"));
            Assert.That(eleRodLabel.Displayed);

            IWebElement eleMuskiRadioButton = driver.FindElement(By.Id("gender-male"));
            Assert.That(eleMuskiRadioButton.Displayed);
            Assert.That(eleMuskiRadioButton.Enabled);
            Assert.That(!eleMuskiRadioButton.Selected);

            IWebElement eleZenskiRadioButton = driver.FindElement(By.Id("gender-female"));
            Assert.That(eleZenskiRadioButton.Displayed);
            Assert.That(eleZenskiRadioButton.Enabled);
            Assert.That(!eleZenskiRadioButton.Selected);

            IWebElement eleImeLabel = driver.FindElement(By.CssSelector("label[for='FirstName']"));
            Assert.That(eleImeLabel.Displayed);

            IWebElement eleImeTextBox = driver.FindElement(By.Id("FirstName"));
            Assert.That(eleImeTextBox.Displayed);
            Assert.That(eleImeTextBox.Enabled);
            string sTextImeTextBox = eleImeTextBox.Text;
            Assert.That(sTextImeTextBox.Equals(""));
            
            IWebElement elePrezimeLabel = driver.FindElement(By.CssSelector("label[for='LastName']"));
            Assert.That(elePrezimeLabel.Displayed);

            IWebElement elePrezimeTextBox = driver.FindElement(By.Id("LastName"));
            Assert.That(elePrezimeTextBox.Displayed);
            Assert.That(elePrezimeTextBox.Enabled);
            string sTextPrezimeTextBox = elePrezimeTextBox.Text;
            Assert.That(sTextPrezimeTextBox.Equals(""));

            IWebElement eleDatumRodenjaLabel = driver.FindElement(By.XPath("//label[contains(text(),'Datum rođenja:')]"));
            Assert.That(eleDatumRodenjaLabel.Displayed);

            IWebElement eleDanDropdown = driver.FindElement(By.Name("DateOfBirthDay"));
            Assert.That(eleDanDropdown.Displayed);
            Assert.That(eleDanDropdown.Enabled);
            SelectElement selDanDropdown = new SelectElement(eleDanDropdown);
            string sDanSelectedOption = selDanDropdown.SelectedOption.Text;
            Assert.That(sDanSelectedOption.Equals("Dan"));

            IWebElement eleMjesecDropdown = driver.FindElement(By.Name("DateOfBirthMonth"));
            Assert.That(eleMjesecDropdown.Displayed);
            Assert.That(eleMjesecDropdown.Enabled);
            SelectElement selMjesecDropdown = new SelectElement(eleMjesecDropdown);
            string sMjesecSelectedOption = selMjesecDropdown.SelectedOption.Text;
            Assert.That(sMjesecSelectedOption.Equals("Mjesec"));

            IWebElement eleGodineDropdown = driver.FindElement(By.Name("DateOfBirthYear"));
            Assert.That(eleGodineDropdown.Displayed);
            Assert.That(eleGodineDropdown.Enabled);
            SelectElement selGodineDropdown = new SelectElement(eleGodineDropdown);
            string sGodineSelectedOption = selGodineDropdown.SelectedOption.Text;
            Assert.That(sGodineSelectedOption.Equals("Godine"));

            IWebElement eleElektronskaPostaLabel = driver.FindElement(By.CssSelector("label[for='Email']"));
            Assert.That(eleElektronskaPostaLabel.Displayed);

            IWebElement eleElektronskaPostaTextBox = driver.FindElement(By.Id("Email"));
            Assert.That(eleElektronskaPostaTextBox.Displayed);
            Assert.That(eleElektronskaPostaTextBox.Enabled);
            string sTextElektronskaPostaTextBox = eleElektronskaPostaTextBox.Text;
            Assert.That(sTextElektronskaPostaTextBox.Equals(""));

            IWebElement eleVasaAdresaTitle = driver.FindElement(By.XPath("//strong[contains(text(),'Vaša adresa')]"));
            Assert.That(eleVasaAdresaTitle.Displayed);

            IWebElement eleAdresaUliceLabel = driver.FindElement(By.CssSelector("label[for='StreetAddress']"));
            Assert.That(eleAdresaUliceLabel.Displayed);

            IWebElement eleAdresaUliceTextBox = driver.FindElement(By.Id("StreetAddress"));
            Assert.That(eleAdresaUliceTextBox.Displayed);
            Assert.That(eleAdresaUliceTextBox.Enabled);
            string sTextAdresaUliceTextBox = eleAdresaUliceTextBox.Text;
            Assert.That(sTextAdresaUliceTextBox.Equals(""));

            IWebElement elePostanskiBrojLabel = driver.FindElement(By.CssSelector("label[for='ZipPostalCode']"));
            Assert.That(elePostanskiBrojLabel.Displayed);

            IWebElement elePostanskiBrojTextBox = driver.FindElement(By.XPath("/html/body/div[5]/div[8]/div[4]/div[1]/form/div/div[3]/div[4]/div[2]/div[2]/input[1]"));
            Assert.That(elePostanskiBrojTextBox.Displayed);
            Assert.That(elePostanskiBrojTextBox.Enabled);
            string sTextPostanskiBrojTextBox = elePostanskiBrojTextBox.Text;
            Assert.That(sTextPostanskiBrojTextBox.Equals(""));

            IWebElement eleGradLabel = driver.FindElement(By.CssSelector("label[for='City']"));
            Assert.That(eleGradLabel.Displayed);

            IWebElement eleGradTextBox = driver.FindElement(By.XPath("/html/body/div[5]/div[8]/div[4]/div[1]/form/div/div[3]/div[4]/div[2]/div[3]/input[1]"));
            Assert.That(eleGradTextBox.Displayed);
            Assert.That(eleGradTextBox.Enabled);
            string sTextGradTextBox = eleGradTextBox.Text;
            Assert.That(sTextGradTextBox.Equals(""));

            IWebElement eleZemljaLabel = driver.FindElement(By.XPath("//div[@class='center-2b']//form"));
            Assert.That(eleZemljaLabel.Displayed);

            IWebElement eleZemljaTextBox = driver.FindElement(By.Id("CountryId_dropdown"));
            Assert.That(eleZemljaTextBox.Displayed);
            Assert.That(!eleZemljaTextBox.Enabled);
            string sTextZemljaTextBox = eleZemljaTextBox.Text;
            
            IWebElement eleVasKontaktTitle = driver.FindElement(By.XPath("//strong[contains(text(),'Vaš Kontakt')]"));
            Assert.That(eleVasKontaktTitle.Displayed);

            IWebElement eleTelefonLabel = driver.FindElement(By.XPath("//label[normalize-space()='Telefon:']"));
            Assert.That(eleTelefonLabel.Displayed);

            IWebElement eleTelefonTextBox = driver.FindElement(By.Id("Phone"));
            Assert.That(eleTelefonTextBox.Displayed);
            Assert.That(eleTelefonTextBox.Enabled);
            string sTextTelefonTextBox = eleTelefonTextBox.Text;
            Assert.That(sTextTelefonTextBox.Equals(""));

            IWebElement eleMogucnostiTitle = driver.FindElement(By.XPath("//strong[contains(text(),'Mogućnosti')]"));
            Assert.That(eleMogucnostiTitle.Displayed);

            IWebElement eleNovostiCheckbox = driver.FindElement(By.Id("Newsletter"));
            Assert.That(eleNovostiCheckbox.Displayed);
            Assert.That(eleNovostiCheckbox.Enabled);
            Assert.That(!eleNovostiCheckbox.Selected);

            IWebElement eleTvojaLozinkaTitle = driver.FindElement(By.XPath("//strong[normalize-space()='Tvoja Lozinka']"));
            Assert.That(eleTvojaLozinkaTitle.Displayed);

            IWebElement eleLozinkaLabel = driver.FindElement(By.XPath("//label[normalize-space()='Lozinka:']"));
            Assert.That(eleLozinkaLabel.Displayed);

            IWebElement eleLozinkaTextBox = driver.FindElement(By.Id("Password"));
            Assert.That(eleLozinkaTextBox.Displayed);
            Assert.That(eleLozinkaTextBox.Enabled);
            string sTextLozinkaTextBox = eleLozinkaTextBox.Text;
            Assert.That(sTextLozinkaTextBox.Equals(""));

            IWebElement elePotvrditeLozinkuLabel = driver.FindElement(By.XPath("//label[normalize-space()='Potvrdite lozinku:']"));
            Assert.That(elePotvrditeLozinkuLabel.Displayed);

            IWebElement elePotvrdaLozinkaTextBox = driver.FindElement(By.Id("ConfirmPassword"));
            Assert.That(elePotvrdaLozinkaTextBox.Displayed);
            Assert.That(elePotvrdaLozinkaTextBox.Enabled);
            string sTextPotvrdaLozinkaTextBox = elePotvrdaLozinkaTextBox.Text;
            Assert.That(sTextPotvrdaLozinkaTextBox.Equals(""));

            IWebElement eleRegistracijaButton = driver.FindElement(By.Id("register-button"));
            Assert.That(eleRegistracijaButton.Displayed);
            Assert.That(eleRegistracijaButton.Enabled);

            IWebElement eleCookieButton = driver.FindElement(By.Id("eu-cookie-ok"));
            Assert.That(eleCookieButton.Displayed);
            Assert.That(eleCookieButton.Enabled);

            Console.WriteLine("Step 2: Click on 'Cookie' button.");
            eleCookieButton.Click();
            Assert.That(Map.UI.LinksMap.Register.sPageUrl.Equals(sCurrentUrl));

            Console.WriteLine("Step 3: Click on 'Ženski' radiobutton.");
            eleZenskiRadioButton.Click();
            Assert.That(eleZenskiRadioButton.Selected);

            Console.WriteLine("Step 4: Enter 'ImeTest' string into 'Ime' textbox.");
            eleImeTextBox.SendKeys("ImeTest");
            sTextImeTextBox = eleImeTextBox.GetAttribute("value");
            Assert.That(sTextImeTextBox.Equals("ImeTest"));

            Console.WriteLine("Step 5: Enter 'PrezimeTest' string into 'Prezime' textbox.");
            elePrezimeTextBox.SendKeys("PrezimeTest");
            sTextPrezimeTextBox = elePrezimeTextBox.GetAttribute("value");
            Assert.That(sTextPrezimeTextBox.Equals("PrezimeTest"));

            Console.WriteLine("Step 6: Select '25' from 'Dan' dropdown.");
            selDanDropdown.SelectByValue("25");
            sDanSelectedOption = selDanDropdown.SelectedOption.GetAttribute("value");
            Assert.That(sDanSelectedOption.Equals("25"));

            Console.WriteLine("Step 7: Select 'kolovoz' from 'Mjesec' dropdown.");
            selMjesecDropdown.SelectByText("kolovoz");
            sMjesecSelectedOption = selMjesecDropdown.SelectedOption.Text;
            Assert.That(sMjesecSelectedOption.Equals("kolovoz"));

            Console.WriteLine("Step 8: Select '2000' from 'Godine' dropdown.");
            selGodineDropdown.SelectByValue("2000");
            sGodineSelectedOption = selGodineDropdown.SelectedOption.GetAttribute("value");
            Assert.That(sGodineSelectedOption.Equals("2000"));

            Console.WriteLine("Step 9: Enter valid string into 'Elektronska pošta' textbox.");
            // inace bih stavila mail negdje u konfiguraciju, ali sam ga ovdje hardkodala zbog vremena :D 
            eleElektronskaPostaTextBox.SendKeys("marijana.kreso+15@gmail.com"); 
            sTextElektronskaPostaTextBox = eleElektronskaPostaTextBox.GetAttribute("value");
            Assert.That(sTextElektronskaPostaTextBox.Equals("marijana.kreso+15@gmail.com"));

            Console.WriteLine("Step 10: Enter 'AdresaTest' string into 'Adresa Ulice' textbox.");
            eleAdresaUliceTextBox.SendKeys("AdresaTest");
            sTextAdresaUliceTextBox = eleAdresaUliceTextBox.GetAttribute("value");
            Assert.That(sTextAdresaUliceTextBox.Equals("AdresaTest"));

            Console.WriteLine("Step 11: Enter '31000' string into 'Poštanski broj' textbox.");
            elePostanskiBrojTextBox.SendKeys("31000");
            sTextPostanskiBrojTextBox = elePostanskiBrojTextBox.GetAttribute("value");
            Assert.That(sTextPostanskiBrojTextBox.Equals("31000"));

            Console.WriteLine("Step 12: Enter 'Osijek' string into 'Grad' textbox.");
            eleGradTextBox.SendKeys("Osijek");
            sTextGradTextBox = eleGradTextBox.GetAttribute("value");
            Assert.That(sTextGradTextBox.Equals("Osijek"));

            Console.WriteLine("Step 13: Enter '12341234' string into 'Telefon' textbox.");
            eleTelefonTextBox.SendKeys("12341234");
            sTextTelefonTextBox = eleTelefonTextBox.GetAttribute("value");
            Assert.That(sTextTelefonTextBox.Equals("12341234"));

            Console.WriteLine("Step 14: Enter valid string into 'Lozinka' textbox.");
            eleLozinkaTextBox.SendKeys("lozz12#");
            sTextLozinkaTextBox = eleLozinkaTextBox.GetAttribute("value");
            Assert.That(sTextLozinkaTextBox.Equals("lozz12#"));

            Console.WriteLine("Step 15: Enter valid string into 'Potvrda lozinka' textbox.");
            elePotvrdaLozinkaTextBox.SendKeys("lozz12#");
            sTextPotvrdaLozinkaTextBox = elePotvrdaLozinkaTextBox.GetAttribute("value");
            Assert.That(sTextPotvrdaLozinkaTextBox.Equals("lozz12#"));

            Console.WriteLine("Step 16: Click on 'Registrirajte se' button.");
            eleRegistracijaButton.Click();
            sCurrentUrl = driver.Url;
            Assert.That(Map.UI.LinksMap.Register.sResultPageUrl.Equals(sCurrentUrl));
            IWebElement eleNastavitiButton = driver.FindElement(By.XPath("//input[@value='Nastaviti']"));
            Assert.That(eleNastavitiButton.Displayed);
            Assert.That(eleNastavitiButton.Enabled);

            Console.WriteLine("Step 17: Click on 'Nastaviti' button.");
            eleNastavitiButton.Click();
            sCurrentUrl = driver.Url;
            Assert.That(Map.UI.LinksMap.Register.sHomePageUrl.Equals(sCurrentUrl));
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}