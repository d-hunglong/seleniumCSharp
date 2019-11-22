using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace seleniumCSharp.Common
{
    public class Wait : DriverFactory
    {
        public static void WaitPageLoad(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 20));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
        public static void WaitElementVisible(By by)
        {
            WebDriverWait wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(20));
            wait.Until(driver => driver.FindElement(by));
            Thread.Sleep(500);
        }
        public static void WaitAndClick(By by)
        {
            WebDriverWait wait = new WebDriverWait(_driver, System.TimeSpan.FromSeconds(20));
            wait.Until(driver => driver.FindElement(by));
            _driver.FindElement(by).Click();
            Thread.Sleep(1000);
        }
    }
}
