using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protractor.Samples//.Tests
{
    [TestFixture]
    class HomePageTests
    {
        private IWebDriver driver;
        private HomePage homePage;

        [SetUp]
        public void SetUp()
        {
            // Using Chrome
            driver = new ChromeDriver();

            // Required for TestForAngular and WaitForAngular scripts
            //driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(5));
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);

            homePage = new HomePage(driver);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test(Description = "Should filter the phone list as user types into the search box")]
        public void ShouldFilter()
        {

            homePage.NavigateToUrl("http://angular.github.io/angular-phonecat/step-7/app/");

            Assert.AreEqual(20, homePage.GetResultsCount());

            homePage.SearchFor("Motorola");
            Assert.AreEqual(8, homePage.GetResultsCount());

            homePage.SearchFor("Nexus");
            Assert.AreEqual(1, homePage.GetResultsCount());
        }

        [Test(Description = "Should be possible to control phone order via the drop down select box")]
        public void ShouldSort()
        {
            homePage.NavigateToUrl("http://angular.github.io/angular-phonecat/step-7/app/");

            homePage.SearchFor("tablet");
            Assert.AreEqual(2, homePage.GetResultsCount());

            homePage.SortByAge();
            Assert.AreEqual("Motorola XOOM™ with Wi-Fi", homePage.GetResultsPhoneName(0));
            Assert.AreEqual("MOTOROLA XOOM™", homePage.GetResultsPhoneName(1));

            homePage.SortByName();
            Assert.AreEqual("MOTOROLA XOOM™", homePage.GetResultsPhoneName(0));
            Assert.AreEqual("Motorola XOOM™ with Wi-Fi", homePage.GetResultsPhoneName(1));
        }

    }
}
