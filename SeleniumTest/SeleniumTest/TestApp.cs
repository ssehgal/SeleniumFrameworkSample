using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppacitiveAutomationFramework;
using SeleniumTest.Pages;

namespace SeleniumTest
{
    public class TestApp : UIApplication
    {
        public FirstPage FirstPage
        {
            get { return InitializePage<FirstPage>("TestControls"); }
        }
    }
}
