using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WindowsInput;
using WindowsInput.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protractor.Samples//.Pages
{
    class UploadPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "(//div[@class='drop'])[1]/span[text()='Upload File']")]
        public IWebElement UploadFileButton { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='drop'])[1]/span[text()='Upload Folder']")]
        public IWebElement UploadFolderButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Upload File']/input")]
        public IWebElement UploadInput { get; set; }

        [FindsBy(How = How.Custom, CustomFinderType = typeof(NgByRepeater), Using = "file in $flow.files")]
        public IList<IWebElement> UploadedFilesList { get; set; }

        public UploadPage(IWebDriver driver) : base(driver)
        {
            
        }

        public UploadPage ClickButton()
        {

            //UploadFileButton.Click();

            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.visibility = 'visible'; arguments[0].style.height = '100px'; arguments[0].style.width = '100px'; arguments[0].style.opacity = 1", UploadInput);
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.visibility = 'visible'", UploadInput);
            //ngDriver.ExecuteScript("arguments[0].style.visibility = 'visible'", UploadInput);
            //UploadInput.FindElement(By.XPath("//span[text()='Upload File']/input")).SendKeys("C:\\Users\\siandrei\\Downloads\\tst.txt");  //merge
            UploadInput.SendKeys("C:\\Users\\siandrei\\Downloads\\tst.txt");
            UploadInput.SendKeys("C:\\Users\\siandrei\\Downloads\\tst2.txt");
            UploadInput.SendKeys("C:\\Users\\siandrei\\Downloads\\tst3.txt");

            //remove 2nd file from the list
            //System.Threading.Thread.Sleep(2000);
            //UploadedFilesList[1].FindElement(By.XPath("//*[contains(text(),'Cancel')]")).Click();
            //ngDriver.FindElements(NgBy.Repeater("file in $flow.files"))[1].FindElement(By.XPath("//*[@ng-click='file.cancel()']"));
            UploadedFilesList[2].FindElement(By.XPath("//*[@ng-click='file.cancel()']")).Click();

            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.visibility = 'visible'", ngDriver.FindElement(By.XPath("//span[text()='Upload File']/input")));
            //ngDriver.FindElement(By.XPath("//span[text()='Upload File']/input")).SendKeys("C:\\Users\\siandrei\\Downloads\\tst.txt");
            //UploadFileButton.SendKeys("C:\\Users\\siandrei\\Downloads\\tst.txt");

            //UploadFolderButton.Click();



            //using WindowsInput
            /*
             //var fullFilePath = @" D:\workspace\ECOS.TestFramework\Ecos.Planner\Ecos.Planner\UIAutomation\" +
                                           BuildPath.Folder() + @"\ImportData\" + fileName + ".xlsx";
            //var fullFilePath = BuildPath.Combine("ImportData", fileName);
            var fullFilePath = "C:\\Users\\siandrei\\Downloads\\tst.txt";

            InputSimulator simulator = new InputSimulator();
            simulator.Keyboard.Sleep(500);
            simulator.Keyboard.TextEntry(fullFilePath);
            simulator.Keyboard.Sleep(500);
            simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            simulator.Keyboard.Sleep(500);
 */
            return this;
        }

        public int GetFilesCount()
        {
            return UploadedFilesList.Count;
        }




    }
}
