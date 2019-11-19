using System;
using NUnit.Framework;
using OpenQA.Selenium;
using seleniumCSharp.Common;
using seleniumCSharp.Pages;

namespace seleniumCSharp.TestCases
{
    [TestFixture]
    public class LoginDeloitte:WebDriverLaunch
    {

        [Test, Order(1)]
        public void inputEmail()
        {
            PageActions.input(LoginObjects.emailTextbox, LoginObjects.accountDeloitte);
            PageActions.click(LoginObjects.nextButton);
            PageActions.waitElement(LoginObjects.loginMessage);
            string temptext = PageActions.gettext(LoginObjects.loginMessage);
            Console.WriteLine(temptext);
            Assert.AreEqual(temptext, "Sign in with your Deloitte account");
        }
        [Test, Order(2)]
        public void inputPassword()
        {
            PageActions.input(LoginObjects.passwordTextbox, LoginObjects.passwordDeloitte);
            PageActions.click(LoginObjects.submitButton);
            PageActions.waitElement(LoginObjects.errorMessage);
            string temptext = PageActions.gettext(LoginObjects.errorMessage);
            Console.WriteLine(temptext);
            Assert.AreEqual(temptext, "Incorrect user ID or password. Type the correct user ID and password, and try again.", "Error message is wrong!");
        }
        [Test, Order(3)]
        public void backButton()
        {
            PageActions.waitElement(LoginObjects.backButton);
            PageActions.click(LoginObjects.backButton);
            PageActions.click(LoginObjects.backButton);
            PageActions.waitElement(LoginObjects.loginTitle);
            string temptext = PageActions.gettext(LoginObjects.loginTitle);
            Console.WriteLine(temptext);
            Assert.AreEqual(temptext, "Sign in", "Title is wrong!");
        }
    }
}
