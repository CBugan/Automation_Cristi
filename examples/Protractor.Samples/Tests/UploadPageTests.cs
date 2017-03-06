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
    class UploadPageTests
    {
        private IWebDriver driver;
        private UploadPage uploadPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);

            uploadPage = new UploadPage(driver);
        }
        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }

        [Test(Description = "Upload a file")]
        public void UploadFile()
        {
            uploadPage.NavigateToUrl("http://flowjs.github.io/ng-flow/");
            uploadPage.ClickButton();

        }

    }
}
