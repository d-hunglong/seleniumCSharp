using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;

namespace seleniumCSharp.Common
{
    public class PageActions:TestBase
    {
        public static void click(By by)
        {
            driver.FindElement(by).Click();
            Thread.Sleep(1000);
        }
        public static void waitandclick(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            wait.Until(driver => driver.FindElement(by));
            driver.FindElement(by).Click();
            Thread.Sleep(1000);
        }
        public static void input(By by, string text)
        {
            driver.FindElement(by).SendKeys(text);
            Thread.Sleep(500);
        }
        public static void cleartext(By by)
        {
            driver.FindElement(by).Clear();
            Thread.Sleep(500);
        }
        public static void waitelementvisible(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            wait.Until(driver => driver.FindElement(by));
            Thread.Sleep(500);
        }
        public static string gettext(By by)
        {
            string temp = driver.FindElement(by).Text;
            Console.WriteLine(temp);
            return temp;
        }
        public static void doubleclick(By by)
        {
            Actions actions = new Actions(driver);
            IWebElement ele = driver.FindElement(by);
            actions.DoubleClick(ele).Perform();
        }
        public static void scrollintoview(By by)
        {
            IJavaScriptExecutor driver = null;
            driver.ExecuteScript("arguments[0].scrollIntoView(true);", by);
        }
        public static void waitpageload(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 20));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
        public static void pause(int inputSeconds)
        {
            TimeSpan seconds = new TimeSpan(0,0, inputSeconds);
            Thread.Sleep(seconds);
        }
        public static void acceptalert()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }
        public static bool iselementpresent(By by)
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
    }
}
