using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Protractor.Samples
{
    class AngularCheckBox : BasePage
    {
        [FindsBy(How = How.XPath, Using = "(//*[@type=\"checkbox\"])[2]")]
        public IWebElement ACheckBox { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByRepeater), Using = "todo in todoList.todos")]
        public IList<IWebElement> ToDoList { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".done-true")]
        public IList<IWebElement> CheckedBoxes { get; set; }

        public AngularCheckBox(IWebDriver driver) : base(driver)
        {
        }
        

        public AngularCheckBox ClickCheckBox()
        {
            
            ngDriver.FindElement(By.XPath("(//*[@type=\"checkbox\"])[2]")).MoveToElement(ngDriver);

            ACheckBox.Click();
            return this;
        }

        public int CountCheckBoxes()
        {
            return ToDoList.Count;
        }

        public int CountCheckedBoxes()
        {
            return CheckedBoxes.Count;
        }



    }
}
