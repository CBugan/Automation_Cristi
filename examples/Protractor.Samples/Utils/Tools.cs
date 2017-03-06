using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protractor.Samples//.Utils
{
    static class Tools
    {

        //this method will scroll your page to make the web element visible on screen
        //use it like this: ngDriver.FindElement(By.XPath("(//*[@type=\"checkbox\"])[2]")).MoveToElement(ngDriver);
        public static void MoveToElement(this NgWebElement currentElement, NgWebDriver ngDriver)
        {
            Actions actions = new Actions(ngDriver);
            actions.MoveToElement(currentElement);
            actions.Perform();
        }

    }
}
