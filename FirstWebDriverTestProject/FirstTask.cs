using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstWebDriverTestProject
{
    [TestFixture]
    public class FirstTask
    {
       
        private IWebDriver _driver;


        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }


        [Test]
        public void CorrectPageIsLoaded()
        {

            _driver.Navigate().GoToUrl("https://www.selenium.dev/documentation/webdriver/getting_started/"); //navigate to the url
            IWebElement gridAnchor = _driver.FindElement(By.LinkText("Grid")); //find the UI element with text "Grid"

            gridAnchor.Click(); // click on the element with text "Grid"

            IWebElement secondComponentsAnchor = _driver.FindElements(By.LinkText("Components"))[0]; //find the first(second in the exercise) element with text Components

            secondComponentsAnchor.Click();

            Assert.AreEqual("https://www.selenium.dev/documentation/grid/components/", _driver.Url); // check if the page is loaded by comparing it to the url property of the driver

            //IWebElement h1Title = _driver.FindElement(By.TagName("h1"));
            
            string h1Title = _driver.FindElement(By.XPath("//h1"))
                .GetAttribute("innerHTML");
            Assert.AreEqual("Selenium Grid Components", h1Title); // check if the page is loaded by comparing it to heading of the page

            IWebElement githubLink = _driver.FindElement(By.XPath("/html/body/div/footer/div/div/div[2]/ul/li[2]/a")); //get the github icon element

            githubLink.Click(); //click on the github icon
            _driver.SwitchTo().Window(_driver.WindowHandles.Last()); //change to the most recent opened tab


            //IWebElement h1Github = _driver.FindElement(By.XPath("//h1[@dir='auto']")); //check what is the h1 of the page
            //IWebElement h1Github = _driver.FindElement(By.XPath("//*[@id=\"readme\"]/div[2]/article/h1/text()")); //check what is the h1 of the page
            
            
            //  //span[1]/a
            IWebElement h1Github = _driver.FindElement(By.XPath("//span[1]/a")); //get SeleniumHQ link text


            Assert.AreEqual("https://github.com/seleniumhq/selenium", _driver.Url); //check if the url is the git one
            Assert.AreEqual("SeleniumHQ", h1Github.GetAttribute("innerHTML")); // check if the SeleniumHQ link text matches


        }

    }

 
}
