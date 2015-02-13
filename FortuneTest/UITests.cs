﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.BDDfy;

namespace FortuneTest
{

   [TestClass]
    public class UITests : UITestHelper
    {
        [ClassInitialize]
        public static void SetupTests(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _context)
        {
            UITestHelper.Setup(_context);
        }

        [TestInitialize]
        public void SetupTests()
        {
            UITestHelper.TestPrep();
        }

        [TestCleanup]
        public void CleanUp()
        {
            UITestHelper.TearDown();
        }

        [TestMethod]
        public void ScenarioAddingAFortune()
        {
            WhenTextBoxisClicked();
            ThenIShouldSeetheTextBoxClear();
            WhenIFillInTheTextBoxWith("Help! I've been kidnapped and forced to work in a Chinese bakery.");
            AndIChooseTheFortuneCategory("Relationships");
            AndIClick("Submit");
            ThenIShouldSeetheTextBoxClear();
            ThenIShouldSeetheTextBoxText("Add your fortune here...");
            AndtheSubmitButtonisDisabled();
        }

       [TestMethod]
       public void ScenarioGetFortuneFromCategory()
        {
           AndIClick("Relationships");
           ThenIShouldSeetheTextBlockwithFortune();
           AndIClick("Life");
           ThenIShouldSeeTextboxWithFortune();
        }
    }
}


