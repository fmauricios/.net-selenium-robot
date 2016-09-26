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
        IWebDriver driver = new FirefoxDriver();

        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            string uri = "http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login";
            driver.Navigate().GoToUrl(uri);
        }

        [Test]
        public void ExecuteTest()
        {
            // Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Name");

            // Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "Mauricio", "Name");

            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText(driver, "TitleId", "Id"));

            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));

            // Click
            SeleniumSetMethods.Click(driver, "Save", "Name");

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
