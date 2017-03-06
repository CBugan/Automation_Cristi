using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protractor.Samples//.Utils
{
    class BasePage
    {
        public NgWebDriver ngDriver;

        public BasePage(IWebDriver driver)
        {
            ngDriver = new NgWebDriver(driver);
            PageFactory.InitElements(ngDriver, this);
            
        }

        public string GetPageTitle()
        {
            return ngDriver.Title;
        }

        public void NavigateToUrl(string url)
        {
            ngDriver.Navigate().GoToUrl(url);
        }

    }
}
