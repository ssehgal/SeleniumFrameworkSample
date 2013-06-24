﻿using System;
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

        public bool CheckPageTitle()  //finding controls using tags
        {
            var titleText = GetUIElementBySelector("pageTitle").Text; //check control file and how the titletext control was got
            if (titleText == "Cleartrip | Flights, Hotels, Packages, Trains")
                return true;
            return false;

        }

        public void ClickOnSearchButton()  //finding control using id (css selector #id)
        {
            GetUIElementBySelector("SearchBtn").Click();
        }


        public void ClickOnTab() // to click on tab we need to find 
        {
            var tabBar = GetUIElementBySelector("tablink");
            var tabLinks=tabBar.GetUIElements("tabchild");
            var imageAnchorTag = tabLinks[2].GetUIElementBySelector("link"); // nesting demonstration
            imageAnchorTag.PressEnter();    //clicking on links is sometimes difficult that is why the use of enter
        }
    }
}
