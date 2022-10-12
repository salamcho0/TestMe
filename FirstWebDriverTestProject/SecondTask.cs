using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FirstWebDriverTestProject
{
    [TestFixture]
    public class SecondTask
    {
        private WebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void VerifyValidationMessageIsDisplayed_When_WrongEmailAndPasswordAreEnteredAndLoginByClick()
        {
            _driver.Navigate().GoToUrl("https://login.bluehost.com/hosting/webmail"); //go to the site


            //extra step for cookies
            //Thread.Sleep(200); //wait for 2000ms to load the pop-up
            IWebElement acceptCookiesButton = _driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler")); //find the cookie button
            acceptCookiesButton.Click(); //click on the cookie button

            IWebElement emailField = _driver.FindElement(By.Name("email")); //find the email input field
            
            emailField.Clear(); //clear the field
            emailField.SendKeys("wrongEmail@test.com"); //insert an email in the field

            IWebElement passwordField = _driver.FindElement(By.Name("password")); //find the pass input field

            passwordField.Clear(); //clear the field
            passwordField.SendKeys("passw0rd"); //insert a pass in the field

            //find the login button
            IWebElement loginButton = _driver.FindElement(By.CssSelector("[value^='Log In']")); 
            //IWebElement loginButton = _driver.FindElement(By.Name("next")); //find hte login button by name/id
            //click on the 'Login' button
            loginButton.Click(); 

            //wait for 3 seconds to err msg to be shown
            WebDriverWait webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3)); 

            //another way to wait using selenium.wait.helpers package
            //IWebElement errMsg = webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[value^='Log In']"))); 

            IWebElement errMsg = _driver.FindElement(By.XPath("//span[@class='error']")); // find the error msg
            //IWebElement errMsg = _driver.FindElement(By.ClassName("error")); // find the error msg by class name

            Assert.AreEqual("Email address or password is incorrect.", errMsg.Text); //compare the error msg

        }

        [Test]
        public void VerifyValidationMessageIsDisplayed_When_WrongEmailAndPasswordAreEnteredAndLoginByEnterb()
        {
            _driver.Navigate().GoToUrl("https://login.bluehost.com/hosting/webmail"); //go to the site
            IWebElement acceptCookiesButton = _driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler")); //find the cookie button
            acceptCookiesButton.Click(); //click on the cookie button

            IWebElement emailField = _driver.FindElement(By.Name("email")); //find the email input field

            emailField.Clear(); //clear the field
            emailField.SendKeys("wrongEmail@test.com"); //insert an email in the field

            IWebElement passwordField = _driver.FindElement(By.Name("password")); //find the pass input field

            passwordField.Clear(); //clear the field
            passwordField.SendKeys("passw0rd"); //insert a pass in the field

            //find the login button
            IWebElement loginButton = _driver.FindElement(By.CssSelector("[value^='Log In']"));
            //click on the 'Login' button
            //loginButton.Click();
            loginButton.SendKeys(Keys.Enter);
            

            //wait for 3 seconds to err msg to be shown
            WebDriverWait webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(3));

            //another way to wait using selenium.wait.helpers package
            IWebElement errMsg = webDriverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='error']"))); 

            //IWebElement errMsg = _driver.FindElement(By.XPath("//span[@class='error']")); // find the error msg
            //IWebElement errMsg = _driver.FindElement(By.ClassName("error")); // find the error msg by class name

            Assert.AreEqual("Email address or password is incorrect.", errMsg.Text); //compare the error msg
        }


    }
}
