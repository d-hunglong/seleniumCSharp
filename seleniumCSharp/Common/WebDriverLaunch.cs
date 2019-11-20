using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace seleniumCSharp.Common
{
    [TestFixture]
    public class WebDriverLaunch
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void startBrowser()
        {
            launchDriver();
            driver.Url = "https://dlevvia.aaps.deloitte.com/";
        }

        public enum BrowserType
        {
            Firefox,
            Ie,
            Chrome,
            Edge,
            Safari,
        }
        public static void launchDriver()
        {
            BrowserType browserType = BrowserType.Chrome;
            switch (browserType)
            {
                case BrowserType.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case BrowserType.Ie:
                    driver = new InternetExplorerDriver();
                    break;
                case BrowserType.Chrome:
                    driver = new ChromeDriver();
                    break;
                case BrowserType.Edge:
                    driver = new EdgeDriver();
                    break;
                case BrowserType.Safari:
                    driver = new SafariDriver();
                    break;
                default:
                    throw new NotSupportedException("Unrecognized browser type: " + browserType);
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [OneTimeTearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
