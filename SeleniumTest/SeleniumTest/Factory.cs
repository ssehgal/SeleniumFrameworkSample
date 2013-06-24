using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppacitiveAutomationFramework;

namespace SeleniumTest
{
    public static class Factory
    {
        public static void PressEnter(this IUIWebElement element)
        {
            element.SendKeys(UIKeys.GetSpecialKey("Return")); 
        }
    }
}
