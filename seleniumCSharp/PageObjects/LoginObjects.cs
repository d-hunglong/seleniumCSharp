using OpenQA.Selenium;

namespace seleniumCSharp.PageObjects
{
    public class LoginObjects
    {
        public static By signupElement = By.XPath("//*[@id='sectionLinks']/ul/li/a[text()='Signup']");
        public static By signupTitleElement = By.CssSelector("#content > div:nth-child(1) > h3");
        public static By usernameElement = By.CssSelector("form > table > tbody > tr > td > input[name=uname]");
        public static By passwordElement = By.CssSelector("form > table > tbody > tr > td > input[name=pass]");
        public static By signupHereElement = By.XPath("//*[@id='content']/div/h3/a[text()='signup here']");
        public static By pageNameTitleElement = By.CssSelector("#pageName");
        public static By loginButtonElement = By.CssSelector("form > table > tbody > tr > td > input[value=login]");
        public static By loginDescriptionElement = By.CssSelector("#content > div:nth-child(2) > p");
        public static By logoutTestElement = By.XPath("//*[@id='globalNav']/table/tbody/tr/td/a[text()='Logout test']");
        public static By cartHereElement = By.XPath("//*[@id='content']/div/p/a[text()='here']");
        public static By productIdCartElement = By.XPath("//*[@id='content']/div/table/tbody/tr/td[1]/strong[text()='Product id']");
        public static string accounttestphp = "test";
        public static string passwordtestphp = "test";
    }
}
