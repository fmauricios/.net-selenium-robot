using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSelenium
{
    class Program
    {

        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new FirefoxDriver();

            string uri = "http://www.executeautomation.com/demosite/Login.html";
            PropertiesCollection.driver.Navigate().GoToUrl(uri);
        }

        [Test]
        public void ExecuteTest()
        {
            /* Login to application */

            LoginPageObject loginPage = new LoginPageObject();
            EAPageObject pageEA = loginPage.Login("mauricio", "123456");

            pageEA.FillUserForm("KK", "Mauricio", "Andres");
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
