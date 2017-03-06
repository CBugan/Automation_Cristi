using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protractor.Samples.Tests
{
    [TestFixture]
    class AngularCheckBoxTests
    {
        private IWebDriver driver;
        private AngularCheckBox angularCheckBox;

        [SetUp]
        public void SetUp()
        {
            // Using Chrome
            driver = new ChromeDriver();

            // Required for TestForAngular and WaitForAngular scripts
            //driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(5));
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);

            angularCheckBox = new AngularCheckBox(driver);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test(Description = "Vrem sa dam click pe un check box")]
        public void ClickMyBox()
        {
            angularCheckBox.NavigateToUrl("https://angularjs.org/");
            Assert.AreEqual(2, angularCheckBox.CountCheckBoxes());

            Assert.AreEqual(1, angularCheckBox.CountCheckedBoxes());
            angularCheckBox.ClickCheckBox();
            Assert.AreEqual(2, angularCheckBox.CountCheckedBoxes());


        }

    }
}
