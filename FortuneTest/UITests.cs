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
    public class UITests : TestHelper
    {

        [TestMethod]
        public void AddingFortuneScenario()
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
       public void GettingRandomFortuneScenario()
        {
           AndIClick("Relationships");
           ThenIShouldSeetheTextBlockwithFortune();
           AndIClick("Life");
           ThenIShouldSeeTextboxWithFortune();
        }
    }
}


