using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protractor.Samples//.Pages
{
    class HomePage : BasePage
    {
        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByModel), Using = "$ctrl.query")]
        public IWebElement QueryInput { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByModel), Using = "$ctrl.orderProp")]
        public IWebElement SortBySelect { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByRepeater), Using = "phone in $ctrl.phones")]
        public IList<IWebElement> PhonesList { get; set; }


        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        public HomePage SearchFor(string query)
        {
            QueryInput.Clear();
            QueryInput.SendKeys(query);
            return this;
        }

        public HomePage SortByName()
        {
            SortBySelect.FindElement(By.XPath("//option[@value='name']")).Click();
            return this;
        }

        public HomePage SortByAge()
        {
            SortBySelect
                .FindElement(By.XPath("//option[@value='age']"))
                .Click();
            return this;
        }

        public int GetResultsCount()
        {
            return PhonesList.Count;
        }

        public string GetResultsPhoneName(int index)
        {
            return PhonesList[index].FindElement(NgBy.Binding("phone.name")).Text;
        }
    }
}
