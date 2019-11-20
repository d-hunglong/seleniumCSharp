using System;
using NUnit.Framework;
using OpenQA.Selenium;
using seleniumCSharp.Common;
using seleniumCSharp.PageObjects;

namespace seleniumCSharp.Tests
{
    [TestFixture]
    public class LoginTestphp : TestBase
    {

        [Test, Order(1)]
        public void GoToSignupPage()
        {
            PageActions.click(LoginObjects.signupElement);
            PageActions.waitelementvisible(LoginObjects.signupTitleElement);
            string temptext = PageActions.gettext(LoginObjects.signupTitleElement);
            Assert.IsTrue(temptext.Contains("If you are already registered please enter your login information below"));
        }
        [Test, Order(2)]
        public void GoToSignupHere()
        {
            PageActions.click(LoginObjects.signupHereElement);
            PageActions.waitelementvisible(LoginObjects.pageNameTitleElement);
            string temptext = PageActions.gettext(LoginObjects.pageNameTitleElement);
            Assert.IsTrue(temptext.Contains("Signup new user"));
        }
        [Test, Order(3)]
        public void LoginWithValidAccount()
        {
            PageActions.click(LoginObjects.signupElement);
            PageActions.waitelementvisible(LoginObjects.usernameElement);
            PageActions.input(LoginObjects.usernameElement, LoginObjects.accounttestphp);
            PageActions.input(LoginObjects.passwordElement, LoginObjects.passwordtestphp);
            PageActions.click(LoginObjects.loginButtonElement);
            //PageActions.acceptalert();
            PageActions.waitelementvisible(LoginObjects.loginDescriptionElement);
            string temptext = PageActions.gettext(LoginObjects.loginDescriptionElement);
            Assert.IsTrue(temptext.Contains("On this page you can visualize or edit you user information"));
        }
        [Test, Order(4)]
        public void LogoutTest()
        {
            if (!PageActions.iselementpresent(LoginObjects.logoutTestElement))
            {
                PageActions.click(LoginObjects.logoutTestElement);
                PageActions.waitelementvisible(LoginObjects.pageNameTitleElement);
                string temptext = PageActions.gettext(LoginObjects.pageNameTitleElement);
                Assert.IsTrue(temptext.Contains("You have been logged out. See you back soon"));
            }
            else
            {
                PageActions.click(LoginObjects.cartHereElement);
                PageActions.waitelementvisible(LoginObjects.productIdCartElement);
                string temptext = PageActions.gettext(LoginObjects.productIdCartElement);
                Assert.IsTrue(temptext.Contains("Product id"));
            }

            
        }
    }
}
