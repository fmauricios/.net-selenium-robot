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

            string uri = "http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login";
            PropertiesCollection.driver.Navigate().GoToUrl(uri);
        }

        [Test]
        public void ExecuteTest()
        {
            /*
             * Initialize the page by calling it's reference
            */

            PageObject page = new PageObject();

            page.txtInitial.SendKeys("Crystal Lang");
            page.btnSave.Click();



            // Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            // Initial
            //SeleniumSetMethods.EnterText("Initial", "Mauricio", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDropdownList("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            // Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);

        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
