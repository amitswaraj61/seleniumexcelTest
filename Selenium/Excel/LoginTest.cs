using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium.Excel
{
    [TestFixture]
    class LoginTest
    {
        [Test]
        public void loginTest()
        {
            Credentails credentials = new Credentails();
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Maximizing the window
            driver.Manage().Window.Maximize();

            //Enter the url
            driver.Url = "https://www.linkedin.com/login";

            IWebElement username = driver.FindElement(By.XPath("//input[contains(@id,'username')]"));


            username.SendKeys(credentials.userName);
            Thread.Sleep(3000);

            
            string pa = ExcelOperations.ReadData(1, "password");
            IWebElement pas = driver.FindElement(By.XPath("//input[contains(@id,'password')]"));
            pas.SendKeys(credentials.pass);
        
            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
