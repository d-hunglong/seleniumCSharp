using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;

namespace seleniumCSharp.Common
{
    public class PageActions:DriverFactory
    {
        public static void Click(By by)
        {
            _driver.FindElement(by).Click();
            Thread.Sleep(1000);
        }
        public static void Input(By by, string text)
        {
            _driver.FindElement(by).SendKeys(text);
            Thread.Sleep(500);
        }
        public static void ClearText(By by)
        {
            _driver.FindElement(by).Clear();
            Thread.Sleep(500);
        }
        public static string GetText(By by)
        {
            string temp = _driver.FindElement(by).Text;
            Console.WriteLine("Actual text: "+temp);
            return temp;
        }
        public static void PrintText(string textneedtoprint)
        {
            Console.WriteLine(textneedtoprint);
        }
        public static void DoubleClick(By by)
        {
            Actions actions = new Actions(_driver);
            IWebElement ele = _driver.FindElement(by);
            actions.DoubleClick(ele).Perform();
        }
        public static void ScrollIntoView(By by)
        {
            IJavaScriptExecutor driver = null;
            driver.ExecuteScript("arguments[0].scrollIntoView(true);", by);
        }
        public static void Pause(int inputSeconds)
        {
            TimeSpan seconds = new TimeSpan(0,0, inputSeconds);
            Thread.Sleep(seconds);
        }
        public static void AcceptAlert()
        {
            IAlert alert = _driver.SwitchTo().Alert();
            alert.Accept();
        }
        public static bool IsElementPresent(By by)
        {
            try
            {
                _driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public static void Navigate(Uri url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
