using System;
using NUnit.Framework;

namespace seleniumCSharp.Common
{
    public class AssertValue : DriverFactory
    {
        public static void TextContains(string actualtext, string expectedcontainstext)
        {
            Assert.IsTrue(actualtext.Contains(expectedcontainstext), "["+actualtext+"] doesn't contains ["+expectedcontainstext+"]");
        }
        public static void TextEqual(string actualtext, string expectedequaltext)
        {
            Assert.AreEqual(expectedequaltext, actualtext); //"["+expectedequaltext+"] is not equal to ["+actualtext+"]"
        }
        public static void PageTitleEqual(string expectedequalpagetitle)
        {
            string actualpagetitle = _driver.Title;
            Assert.AreEqual(expectedequalpagetitle, actualpagetitle); //"["+expectedequalpagetitle+"] is not equal to ["+ actualpagetitle+"]"
        }
    }
}
