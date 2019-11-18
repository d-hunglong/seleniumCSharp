using System;
using NUnit.Framework;
using OpenQA.Selenium;
using seleniumCSharp.Common;

namespace seleniumCSharp.TestCases
{
    [TestFixture]
    public class LoginDeloitte:WebDriverLaunch
    {
        String accountDeloitte = "longdo@deloitte.com";

        [Test, Order(1)]
        public void inputEmail()
        {
            PageActions.input(By.CssSelector("#i0116"), accountDeloitte);
            PageActions.click(By.CssSelector("#idSIButton9"));
            PageActions.waitElement(By.CssSelector("#loginMessage"));
            string temptext = PageActions.gettext(By.CssSelector("#loginMessage"));
            Console.WriteLine(temptext);
            Assert.AreEqual(temptext, "Sign in with your Deloitte account");
        }
        [Test, Order(2)]
        public void inputPassword()
        {
            PageActions.input(By.CssSelector("#passwordInput"), "qwerty");
            PageActions.click(By.CssSelector("#submitButton"));
            PageActions.waitElement(By.CssSelector("#errorText"));
            string temptext = PageActions.gettext(By.CssSelector("#errorText"));
            Console.WriteLine(temptext);
            Assert.AreEqual(temptext, "Incorrect user ID or password. Type the correct user ID and password, and try again.", "Error message is wrong!");
        }
        [Test, Order(3)]
        public void backButton()
        {
            PageActions.waitElement(By.XPath("//*[@id='email-back-button']/span"));
            PageActions.click(By.XPath("//*[@id='email-back-button']/span"));
            PageActions.click(By.XPath("//*[@id='email-back-button']/span"));
            PageActions.waitElement(By.CssSelector("#loginHeader > div"));
            string temptext = PageActions.gettext(By.CssSelector("#loginHeader > div"));
            Console.WriteLine(temptext);
            Assert.AreEqual(temptext, "Sign in", "Title is wrong!");
        }
    }
}
