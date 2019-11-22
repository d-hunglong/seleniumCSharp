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
            Wait.WaitElementVisible(LoginObjects.usernameElement);
            PageActions.Input(LoginObjects.usernameElement, LoginObjects.accounttestphp);
            PageActions.Input(LoginObjects.passwordElement, LoginObjects.passwordtestphp);
            PageActions.Click(LoginObjects.loginButtonElement);
        }
        [Test, Order(2)]
        public void GoToHomePage()
        {
            PageActions.Click(GlobalNavObjects.homeNavElement);
            Wait.WaitElementVisible(GlobalNavObjects.pageNameTitleElement);
            string temptext = PageActions.GetText(GlobalNavObjects.pageNameTitleElement);
            AssertValue.TextContains(temptext, "welcome to our page");
        }
        [Test, Order(3)]
        public void GoToCategoriesPage()
        {
            PageActions.Click(GlobalNavObjects.categoriesNavElement);
            Wait.WaitElementVisible(GlobalNavObjects.pageNameTitleElement);
            string temptext = PageActions.GetText(GlobalNavObjects.pageNameTitleElement);
            AssertValue.TextContains(temptext, "categories");
        }
        [Test, Order(4)]
        public void GoToArtistsPage()
        {
            PageActions.Click(GlobalNavObjects.artistsNavElement);
            Wait.WaitElementVisible(GlobalNavObjects.commentThisArtistElement);
            string temptext = PageActions.GetText(GlobalNavObjects.commentThisArtistElement);
            AssertValue.TextContains(temptext, "comment on this artist");
        }
        [Test, Order(5)]
        public void GoToYourCartPage()
        {
            PageActions.Click(GlobalNavObjects.yourCartNavElement);
            Wait.WaitElementVisible(LoginObjects.productIdCartElement);
            string temptext = PageActions.GetText(LoginObjects.productIdCartElement);
            AssertValue.TextContains(temptext, "Product id");
        }
        [Test, Order(6)]
        public void GoToOurGuestbook()
        {
            PageActions.Click(GlobalNavObjects.guestbookNavElement);
            Wait.WaitElementVisible(GlobalNavObjects.subNameTitleElement);
            string temptext = PageActions.GetText(GlobalNavObjects.subNameTitleElement);
            AssertValue.TextContains(temptext, "Our guestbook");
        }
    }
}
