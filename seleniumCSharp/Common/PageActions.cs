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
            driver.FindElement(by).Click();
            Thread.Sleep(1000);
        }
        public static void WaitAndClick(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            wait.Until(driver => driver.FindElement(by));
            driver.FindElement(by).Click();
            Thread.Sleep(1000);
        }
        public static void Input(By by, string text)
        {
            driver.FindElement(by).SendKeys(text);
            Thread.Sleep(500);
        }
        public static void ClearText(By by)
        {
            driver.FindElement(by).Clear();
            Thread.Sleep(500);
        }
        public static void WaitElementVisible(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            wait.Until(driver => driver.FindElement(by));
            Thread.Sleep(500);
        }
        public static string GetText(By by)
        {
            string temp = driver.FindElement(by).Text;
            Console.WriteLine(temp);
            return temp;
        }
        public static void DoubleClick(By by)
        {
            Actions actions = new Actions(driver);
            IWebElement ele = driver.FindElement(by);
            actions.DoubleClick(ele).Perform();
        }
        public static void ScrollIntoView(By by)
        {
            IJavaScriptExecutor driver = null;
            driver.ExecuteScript("arguments[0].scrollIntoView(true);", by);
        }
        public static void WaitPageLoad(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 20));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
        public static void Pause(int inputSeconds)
        {
            TimeSpan seconds = new TimeSpan(0,0, inputSeconds);
            Thread.Sleep(seconds);
        }
        public static void AcceptAlert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
        public static bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public static void Navigate(Uri url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
