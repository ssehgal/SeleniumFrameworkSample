using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppacitiveAutomationFramework;
using System.Threading;

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


        public void SwitchToImageLink() // to click on tab we need to find 
        {
            var tabBar = GetUIElementBySelector("tablink");
            var tabLinks=tabBar.GetUIElements("tabchild");
            var imageAnchorTag = tabLinks[2].GetUIElementBySelector("link"); // nesting demonstration
            imageAnchorTag.PressEnter();    //clicking on links is sometimes difficult that is why the use of enter
        }

        public void ClickOnSignInLink()
        {
            WaitAndGetBySelector("SignUpLink",15).Click();
            Thread.Sleep(1200);
        }

        public void ClickOnSignInWithFacebookButton()
        {
            WaitAndGetBySelector("btnLoginWithFacebook",10).Click();
        }

        public void GoToNewWindowUsingTitle()
        {
            //change/ switch to new window
            var check = ReturnWindowHandlesWithTitles();
            ChangeCurrentWindow("Facebook");        
           
            //enter details after switching
            GetUIElementBySelector("email").SendKeys("signups.for.me@gmail.com"); // enter value for email 
            GetUIElementBySelector("password").SendKeys("1qaz!QAZ"); // enter value for password
            GetUIElementBySelector("btnLogin").Click(); // click on signup button
        }

        public void GoToNewWindowUsingIndex()
        {
            //change/ switch to new window
            var handles = ReturnWindowHandles();
            var facebookHandle = handles[1];
            ChangeCurrentWindow(facebookHandle);

            //enter details after switching
            GetUIElementBySelector("email").SendKeys("signups.for.me@gmail.com"); // enter value for email 
            GetUIElementBySelector("password").SendKeys("1qaz!QAZ"); // enter value for password
            GetUIElementBySelector("btnLogin").Click(); // click on signup button
        }

        public void SelectValueFromDropDown()
        {
            var elements=GetUIElementBySelector("AdultsDropDown").GetUIElements("Options");
            var valueToBeSelected = elements[2].Text;
            GetUIElementBySelector("AdultsDropDown").SendKeys(valueToBeSelected);
        }
    }
}
