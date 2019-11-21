using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.IO;
using NUnit.Framework.Interfaces;
using System.Threading;

namespace seleniumCSharp.Common
{
    [TestFixture]
    public class DriverFactory
    {
        public static IWebDriver _driver;
        protected ExtentReports _extent;
        protected ExtentTest _test;

        [OneTimeSetUp]
        public void startBrowser()
        {
            try
            {
                _extent = new ExtentReports();
                var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                DirectoryInfo di = Directory.CreateDirectory(dir + "\\Test_Reports\\");
                var htmlReport = new ExtentHtmlReporter(dir + "\\Test_Reports\\" + "\\HTML_Report\\" + ".html");
                _extent.AddSystemInfo("Environment", "testphp.vulnweb");
                _extent.AddSystemInfo("Username", "LongDo");
                _extent.AttachReporter(htmlReport);
            }
            catch (Exception e)
            {
                throw (e);
            }
            launchDriver();
            _driver.Url = "http://testphp.vulnweb.com/index.php";
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
                    _driver = new FirefoxDriver();
                    break;
                case BrowserType.Ie:
                    _driver = new InternetExplorerDriver();
                    break;
                case BrowserType.Chrome:
                    ChromeOptions options = new ChromeOptions();
                    options.AddExcludedArgument("enable-automation");
                    options.AddAdditionalCapability("useAutomationExtension", false);
                    options.AddUserProfilePreference("credentials_enable_service", false);
                    options.AddUserProfilePreference("profile.password_manager_enabled", false);
                    _driver = new ChromeDriver(options);
                    break;
                case BrowserType.Edge:
                    _driver = new EdgeDriver();
                    break;
                case BrowserType.Safari:
                    _driver = new SafariDriver();
                    break;
                default:
                    throw new NotSupportedException("Unrecognized browser type: " + browserType);
            }
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [SetUp]
        public void BeforeTest()
        {
            try
            {
                _test = _extent.CreateTest(TestContext.CurrentContext.Test.Name);
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        [TearDown]
        public void AfterTest()
        {
            try
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var stacktrace = "" + TestContext.CurrentContext.Result.StackTrace + "";
                var errorMessage = TestContext.CurrentContext.Result.Message;
                Status logstatus;
                switch (status)
                {
                    case TestStatus.Failed:
                        logstatus = Status.Fail;
                        string screenShotPath = Capture(_driver, TestContext.CurrentContext.Test.Name);
                        _test.Log(logstatus, "Test ended with " + logstatus + " – " + errorMessage);
                        _test.Log(logstatus, "Snapshot below: " + _test.AddScreenCaptureFromPath(screenShotPath));
                        break;
                    case TestStatus.Skipped:
                        logstatus = Status.Skip;
                        _test.Log(logstatus, "Test ended with " + logstatus);
                        break;
                    default:
                        logstatus = Status.Pass;
                        _test.Log(logstatus, "Test ended with " + logstatus);
                        break;
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        private string Capture(IWebDriver driver, string screenShotName)
        {
            DateTime serverTime = DateTime.Now;
            DateTime utcTime = serverTime.ToUniversalTime();
            Console.WriteLine($"{utcTime:MMddyyy_HHmmss}");
            string localpath = "";
            try
            {
                Thread.Sleep(4000);
                ITakesScreenshot ts = (ITakesScreenshot)driver;
                Screenshot screenshot = ts.GetScreenshot();
                string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
                DirectoryInfo di = Directory.CreateDirectory(dir + "\\Error_Screenshots\\");
                string finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "\\Error_Screenshots\\" + screenShotName + $"{utcTime:_MMddyyy_HHmmss}" + "_.png";
                localpath = new Uri(finalpth).LocalPath;
                screenshot.SaveAsFile(localpath);
            }
            catch (Exception e)
            {
                throw (e);
            }
            return localpath;
        }

        [OneTimeTearDown]
        public void closeBrowser()
        {
            try
            {
                _extent.Flush();
            }
            catch (Exception e)
            {
                throw (e);
            }
            _driver.Quit();
        }
    }
}
