using OpenQA.Selenium;

namespace seleniumCSharp.PageObjects
{
    public class LoginObjects
    {
        public static By signupElement = By.XPath("//a[text()='Signup']");
        public static By signupTitleElement = By.CssSelector("#content > div:nth-child(1) > h3");
        public static By usernameElement = By.CssSelector("td > input[name=uname]");
        public static By passwordElement = By.CssSelector("td > input[name=pass]");
        public static By signupHereElement = By.XPath("//a[text()='signup here']");
        public static By pageNameTitleElement = By.CssSelector("#pageName");
        public static By loginButtonElement = By.CssSelector("td > input[value=login]");
        public static By loginDescriptionElement = By.CssSelector("#content > div:nth-child(2) > p");
        public static By logoutTestElement = By.XPath("//td/a[text()='Logout test']");
        public static By cartHereElement = By.XPath("//p/a[text()='here']");
        public static By productIdCartElement = By.XPath("//td/strong[text()='Product id']");
        public static string accounttestphp = "test";
        public static string passwordtestphp = "test";
    }
}
