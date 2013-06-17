using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppacitiveAutomationFramework;

namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyControls()
        {
            using (var app = new TestApp())
            {
                app.Launch("http://www.cleartrip.com/");
                Assert.IsTrue(app.FirstPage.VerifyControlPresent(),"Control was not visible!!");
            }
        }
    }
}
