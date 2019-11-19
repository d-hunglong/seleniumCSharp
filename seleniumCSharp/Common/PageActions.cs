using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace seleniumCSharp.Common
{
    public class PageActions:WebDriverLaunch
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
            Thread.Sleep(1000);
        }
        public static void cleartext(By by)
        {
            driver.FindElement(by).Clear();
            Thread.Sleep(500);
        }
        public static void waitElementVisibility(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(20));
            wait.Until(driver => driver.FindElement(by));
        }
        public static string gettext(By by)
        {
            return driver.FindElement(by).Text;
        }
        public static void doubleClick(By by)
        {
            Actions actions = new Actions(driver);
            IWebElement ele = driver.FindElement(by);
            actions.DoubleClick(ele).Perform();
        }
        public static void scrollIntoView(By by, IJavaScriptExecutor driver)
        {
            driver.ExecuteScript("arguments[0].scrollIntoView(true);", by);
        }
        public static void waitpageload(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WebDriverWait wait = new WebDriverWait(driver, new System.TimeSpan(0, 0, 20));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
