using OpenQA.Selenium;

namespace seleniumCSharp.PageObjects
{
    public class GetStartedObjects
    {
        public static By getStartElement = By.CssSelector("body > header > nav > a.site-header__cta.btn.btn-primary");
        public static By getStartTitleElement = By.CssSelector(".container-fluid.position-relative > div > main > div > header > h1");
        public static By getStartDescriptionElement = By.CssSelector("body > div.container-fluid.position-relative > div > main > div > p");
        public static By windownsElement = By.CssSelector(".fab.fa-windows");
        public static By macOSElement = By.CssSelector(".fab.fa-macos");
        public static By linuxElement = By.CssSelector(".fab.fa-linux");
        public static By setUpEditorElement = By.XPath("//a[text()='Set up an editor']");
    }
}
