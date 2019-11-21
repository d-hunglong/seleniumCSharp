﻿using System;
using NUnit.Framework;
using OpenQA.Selenium;
using seleniumCSharp.Common;
using seleniumCSharp.PageObjects;

namespace seleniumCSharp.Tests
{
    [TestFixture]
    public class LoginTestphp : DriverFactory
    {

        [Test, Order(1)]
        public void GoToSignupPage()
        {
            PageActions.Click(LoginObjects.signupElement);
            PageActions.WaitElementVisible(LoginObjects.signupTitleElement);
            string temptext = PageActions.GetText(LoginObjects.signupTitleElement);
            Assert.IsTrue(temptext.Contains("If you are already registered please enter your login information below"));
        }
        [Test, Order(2)]
        public void GoToSignupHere()
        {
            PageActions.Click(LoginObjects.signupHereElement);
            PageActions.WaitElementVisible(LoginObjects.pageNameTitleElement);
            string temptext = PageActions.GetText(LoginObjects.pageNameTitleElement);
            Assert.IsTrue(temptext.Contains("Signup new user"));
        }
        [Test, Order(3)]
        public void LoginWithValidAccount()
        {
            PageActions.Click(LoginObjects.signupElement);
            PageActions.WaitElementVisible(LoginObjects.usernameElement);
            PageActions.Input(LoginObjects.usernameElement, LoginObjects.accounttestphp);
            PageActions.Input(LoginObjects.passwordElement, LoginObjects.passwordtestphp);
            PageActions.Click(LoginObjects.loginButtonElement);
            //PageActions.acceptalert();
            PageActions.WaitElementVisible(LoginObjects.loginDescriptionElement);
            string temptext = PageActions.GetText(LoginObjects.loginDescriptionElement);
            Assert.IsTrue(temptext.Contains("On this page you can visualize or edit you user information"));
        }
        [Test, Order(4)]
        public void GotoCart()
        {
            PageActions.Click(LoginObjects.cartHereElement);
            PageActions.WaitElementVisible(LoginObjects.productIdCartElement);
            string temptext = PageActions.GetText(LoginObjects.productIdCartElement);
            Assert.IsTrue(temptext.Contains("Product id"));
        }
        [Test, Order(5)]
        public void LogoutTest()
        {
            PageActions.Click(LoginObjects.logoutTestElement);
            PageActions.WaitElementVisible(LoginObjects.pageNameTitleElement);
            string temptext = PageActions.GetText(LoginObjects.pageNameTitleElement);
            Assert.IsTrue(temptext.Contains("You haven't been logged out. See you back soon"));
        }
    }
}
