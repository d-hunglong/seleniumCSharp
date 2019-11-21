using System;
using NUnit.Framework;
using OpenQA.Selenium;
using seleniumCSharp.Common;
using seleniumCSharp.PageObjects;

namespace seleniumCSharp.Tests
{
    [TestFixture]
    public class GlobalNavigationTestphp : DriverFactory
    {
        [Test, Order(1)]
        public void LoginPage()
        {
            PageActions.Click(LoginObjects.signupElement);
            PageActions.WaitElementVisible(LoginObjects.usernameElement);
            PageActions.Input(LoginObjects.usernameElement, LoginObjects.accounttestphp);
            PageActions.Input(LoginObjects.passwordElement, LoginObjects.passwordtestphp);
            PageActions.Click(LoginObjects.loginButtonElement);
        }
        [Test, Order(2)]
        public void GoToHomePage()
        {
            PageActions.Click(GlobalNavObjects.homeNavElement);
            PageActions.WaitElementVisible(GlobalNavObjects.pageNameTitleElement);
            string temptext = PageActions.GetText(GlobalNavObjects.pageNameTitleElement);
            Assert.IsTrue(temptext.Contains("welcome to our page"));
        }
        [Test, Order(3)]
        public void GoToCategoriesPage()
        {
            PageActions.Click(GlobalNavObjects.categoriesNavElement);
            PageActions.WaitElementVisible(GlobalNavObjects.pageNameTitleElement);
            string temptext = PageActions.GetText(GlobalNavObjects.pageNameTitleElement);
            Assert.IsTrue(temptext.Contains("categories"));
        }
        [Test, Order(4)]
        public void GoToArtistsPage()
        {
            PageActions.Click(GlobalNavObjects.artistsNavElement);
            PageActions.WaitElementVisible(GlobalNavObjects.commentThisArtistElement);
            string temptext = PageActions.GetText(GlobalNavObjects.commentThisArtistElement);
            Assert.IsTrue(temptext.Contains("comment on this artist"));
        }
        [Test, Order(5)]
        public void GoToYourCartPage()
        {
            PageActions.Click(GlobalNavObjects.yourCartNavElement);
            PageActions.WaitElementVisible(LoginObjects.productIdCartElement);
            string temptext = PageActions.GetText(LoginObjects.productIdCartElement);
            Assert.IsTrue(temptext.Contains("Product id"));
        }
        [Test, Order(6)]
        public void GoToOurGuestbook()
        {
            PageActions.Click(GlobalNavObjects.guestbookNavElement);
            PageActions.WaitElementVisible(GlobalNavObjects.subNameTitleElement);
            string temptext = PageActions.GetText(GlobalNavObjects.subNameTitleElement);
            Assert.IsTrue(temptext.Contains("Our guestbook"));
        }
    }
}
