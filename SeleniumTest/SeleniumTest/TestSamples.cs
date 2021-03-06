﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppacitiveAutomationFramework;

namespace SeleniumTest
{
    [TestClass]
    public class AutomationSamples
    {

        //How to check page title and how to get controls using tags

        [TestMethod]
        public void HowToCheckPageTitle() //finding controls using tags
        {
            using (var app = new TestApp())
            {
                app.Launch("http://www.cleartrip.com/");
                Assert.IsTrue(app.FirstPage.CheckPageTitle(),"The title was not correct!");
            }
        }

        //How to get a button control and using ids to get elements

        [TestMethod]
        public void HowToClickOnAButton()
        {
            using (var app = new TestApp())
            {
                app.Launch("http://www.cleartrip.com/");
                app.FirstPage.ClickOnSearchButton();
            }
        }

        //How to enter text into a textbox

        [TestMethod]
        public void HowToEnterTextInToATextBox()
        {
            using (var app = new TestApp())
            {
                app.Launch("http://www.cleartrip.com/");
                app.FirstPage.EnterTextIntoFromTextBox();
            }
        }

        //How to click on radio button

        [TestMethod]
        public void HowToClickOnARadioButton()
        {
            using (var app = new TestApp())
            {
                app.Launch("http://www.cleartrip.com/");
                app.FirstPage.ClickOnRadioButton();
            }
        }


        //How to select element from a drop down (elements with same classname/ id)

        [TestMethod]
        public void HowToSelectAnElementFromADropDown()
        {
            using (var app = new TestApp())
            {
                app.Launch("http://www.cleartrip.com/");
                app.FirstPage.SelectValueFromDropDown();
            }
        }


        //How to change tab (clicking on link) and use class name and tag name to get selector use of nesting 

        [TestMethod]
        public void HowToSwitchLinks()
        {
            using (var app = new TestApp())
            {
                app.Launch("https://www.google.co.in/");
                app.FirstPage.SwitchToImageLink();
            }
        }

        //How to manage two browser windows and get data from one to another
                    // switching windows using page title
        [TestMethod]
        public void ManageWindowsUsingTitle()
        {
            using (var app = new TestApp())
            {
                app.Launch("https://demos.appacitive.com/connect/index.html");
                app.FirstPage.ClickOnSignInLink();
                app.FirstPage.ClickOnSignInWithFacebookButton();
                app.FirstPage.GoToNewWindowUsingTitle();
            }
        }

        // switching windows using window handle

        [TestMethod]
        public void ManageWindowsUsingIndex()
        {
            using (var app = new TestApp())
            {
                app.Launch("https://demos.appacitive.com/connect/index.html");
                app.FirstPage.ClickOnSignInLink();
                app.FirstPage.ClickOnSignInWithFacebookButton();
                app.FirstPage.GoToNewWindowUsingIndex();
            }
        }

        // clicking on a link by matching the partial text

        [TestMethod]
        public void SelectALinkUsingPartialMatch()
        {
            using (var app = new TestApp())
            {
                app.Launch("http://www.cleartrip.com/");
                app.FirstPage.SelectByMatchingPartialLinkText();
            }
        }
    }
}
