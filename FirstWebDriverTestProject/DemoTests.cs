using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstWebDriverTestProject
{
    [TestFixture]
    public class DemosTests
    {
        private IWebDriver _driver;

        //asd

        [SetUp] //executed before each tests
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://demos.bellatrix.solutions/";
        }

        [TearDown] //executed after each test
        public void TearDown()
        {
            _driver.Quit();
        }

        [Test]
        public void CorrectPageWasLoaded()
        {
            Assert.AreEqual("https://demos.bellatrix.solutions/", _driver.Url);
        }

        //comment
    }
}