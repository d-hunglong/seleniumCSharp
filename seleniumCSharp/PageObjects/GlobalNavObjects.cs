using OpenQA.Selenium;
using seleniumCSharp.Common;

namespace seleniumCSharp.PageObjects
{
    public class GlobalNavObjects
    {
        public static By homeNavElement = By.XPath("//a[text()='home']");
        public static By categoriesNavElement = By.XPath("//a[text()='categories']");
        public static By artistsNavElement = By.XPath("//a[@href='artists.php']");
        public static By disclaimerNavElement = By.XPath("//a[text()='disclaimer']");
        public static By yourCartNavElement = By.XPath("//a[text()='your cart']");
        public static By guestbookNavElement = By.XPath("//a[text()='guestbook']");
        public static By signupElement = By.XPath("//a[text()='home']");
        public static By pageNameTitleElement = By.CssSelector("#pageName");
        public static By subNameTitleElement = By.CssSelector("tr > td > h2");
        public static By commentThisArtistElement = By.XPath("//a[text()='comment on this artist']");
        public static By ajaxdemoNavElement = By.XPath("//a[text()='AJAX Demo']");
        public static By ajaxSendXMLNavElement = By.XPath("//td[@class='bordered']/a[@onclick='sendXML()']");
        public static By ajaxSetMyCookieNavElement = By.XPath("//td[@class='bordered']/a[@onclick='SetMyCookie()']");
    }
}
