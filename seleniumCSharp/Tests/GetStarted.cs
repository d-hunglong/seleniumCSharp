using NUnit.Framework;
using seleniumCSharp.Common;
using seleniumCSharp.PageObjects;

namespace seleniumCSharp.Tests
{
    [TestFixture]
    public class GetStarted : DriverFactory
    {
        [Test, Order(1)]
        public void GoToStartPage()
        {
            PageActions.Click(GetStartedObjects.getStartElement);
            Wait.WaitElementVisible(GetStartedObjects.getStartTitleElement);
            string actualtext = PageActions.GetText(GetStartedObjects.getStartTitleElement);
            string actualtext1 = PageActions.GetText(GetStartedObjects.getStartDescriptionElement);
            AssertValue.TextContains(actualtext, "Install");
            AssertValue.TextContains(actualtext1, "Select the operating system on which you are installing Flutter");
        }
        [Test, Order(2)]
        public void GoToWindowsInstall()
        {
            PageActions.Click(GetStartedObjects.windownsElement);
            Wait.WaitElementVisible(GetStartedObjects.getStartTitleElement);
            string actualtext = PageActions.GetText(GetStartedObjects.getStartTitleElement);
            AssertValue.TextContains(actualtext, "Windows install");
        }
        [Test, Order(3)]
        public void GoToMacOSInstall()
        {
            PageActions.Click(GetStartedObjects.getStartElement);
            PageActions.Click(GetStartedObjects.macOSElement);
            Wait.WaitElementVisible(GetStartedObjects.getStartTitleElement);
            string actualtext = PageActions.GetText(GetStartedObjects.getStartTitleElement);
            AssertValue.TextContains(actualtext, "macOS install");
        }
        [Test, Order(4)]
        public void GoToLinuxInstall()
        {
            PageActions.Click(GetStartedObjects.getStartElement);
            PageActions.Click(GetStartedObjects.linuxElement);
            Wait.WaitElementVisible(GetStartedObjects.getStartTitleElement);
            string actualtext = PageActions.GetText(GetStartedObjects.getStartTitleElement);
            AssertValue.TextContains(actualtext, "Linux install");
        }
        [Test, Order(5)]
        public void GoToSetUpEditor()
        {
            PageActions.Click(GetStartedObjects.getStartElement);
            PageActions.Click(GetStartedObjects.setUpEditorElement);
            Wait.WaitElementVisible(GetStartedObjects.getStartTitleElement);
            string actualtext = PageActions.GetText(GetStartedObjects.getStartTitleElement);
            AssertValue.TextContains(actualtext, "Set up an editor");
        }
    }
}
