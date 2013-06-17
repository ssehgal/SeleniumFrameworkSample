using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppacitiveAutomationFramework;

namespace SeleniumTest.Pages
{
    public class FirstPage : UIPage
    {
        public bool VerifyControlPresent()
        {
            var control = GetUIElementBySelector("AirSearch");
            if (control.Displayed)
                return true;
            return false;
        }
    }
}
