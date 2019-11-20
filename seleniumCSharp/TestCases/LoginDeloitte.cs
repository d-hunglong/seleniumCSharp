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
            PageActions.waitElementVisibility(LoginObjects.loginMessage);
            string temptext = PageActions.gettext(LoginObjects.loginMessage);
            Assert.IsTrue(temptext.Contains("Sign in with your Deloitte account"));
        }
        [Test, Order(2)]
        public void inputPassword()
        {
            PageActions.input(LoginObjects.passwordTextbox, LoginObjects.passwordDeloitte);
            PageActions.click(LoginObjects.submitButton);
            PageActions.waitElementVisibility(LoginObjects.errorMessage);
            string temptext = PageActions.gettext(LoginObjects.errorMessage);
            Assert.IsTrue(temptext.Contains("Incorrect user ID or password. Type the correct user ID and password"));
        }
        [Test, Order(3)]
        public void backButton()
        {
            PageActions.waitElementVisibility(LoginObjects.backButton);
            PageActions.click(LoginObjects.backButton);
            PageActions.click(LoginObjects.backButton);
            PageActions.waitElementVisibility(LoginObjects.loginTitle);
            string temptext = PageActions.gettext(LoginObjects.loginTitle);
            Assert.IsTrue(temptext.Contains("Sign in"));
        }
    }
}
