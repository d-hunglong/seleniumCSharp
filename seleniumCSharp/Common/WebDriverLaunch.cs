using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

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
                default:
                    throw new NotSupportedException("Unrecognized browser type: " + browserType);
                    //throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
            }
            driver.Manage().Window.Maximize();
            //driver.Manage().Window.FullScreen();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [OneTimeTearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
