using OpenQA.Selenium;
using seleniumCSharp.Common;
using OpenQA.Selenium.Support.PageObjects;

namespace seleniumCSharp.Pages
{
    public class LoginObjects
    {
        public static By emailTextbox = By.CssSelector("#i0116");
        public static By nextButton = By.CssSelector("#idSIButton9");
        public static By loginMessage = By.CssSelector("#loginMessage");
        public static By passwordTextbox = By.CssSelector("#passwordInput");
        public static By submitButton = By.CssSelector("#submitButton");
        public static By errorMessage = By.CssSelector("#errorText");
        public static By backButton = By.XPath("//*[@id='email-back-button']/span");
        public static By loginTitle = By.CssSelector("#loginHeader > div");

        public static string accountDeloitte = "longdo@deloitte.com";
        public static string passwordDeloitte = "qwerty";
    }
}
