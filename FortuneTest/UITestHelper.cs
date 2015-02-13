using System;
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
﻿using System.IO;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace FortuneTest
{
    public class UITestHelper
    {
        private static Window window;
        private static Application application;


        private static TextBox text_box;
        private static Label output_label;
        private static Button submit_button;

        private static Button career_button;
        private static Button health_button;
        private static Button relationship_button;
        private static Button life_button;

        [ClassInitialize]
        public static void Setup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _context)
        {
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\FortuneTest\\bin\\Debug\\MakeYourFortune");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            text_box = window.Get<TextBox>("FortuneMakerTextBox");
            output_label = window.Get<Label>("FortuneOutput");
            submit_button = window.Get<Button>("SubmitButton");

            career_button = window.Get<Button>("CareerButton");
            health_button = window.Get<Button>("HealthButton");
            relationship_button = window.Get<Button>("RelationshipButton");
            life_button = window.Get<Button>("LifeButton");

        }

        public void WhenTextBoxisClicked()
        {
            System.Threading.Thread.Sleep(500); // So we can see it
            text_box.Click();
            System.Threading.Thread.Sleep(500); // So we can see it
            Assert.AreEqual("", text_box.Text);
        }

        public void ThenIShouldSeetheTextBoxClear()
        {
            throw new NotImplementedException();
        }

        public void WhenIFillInTheTextBoxWith(string p)
        {
            throw new NotImplementedException();
        }

        public void AndIChooseTheFortuneCategory(string p)
        {
            throw new NotImplementedException();
        }

        public void AndIClick(string p)
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeetheTextBoxText(string p)
        {
            throw new NotImplementedException();
        }

        public void AndtheSubmitButtonisDisabled()
        {
            throw new NotImplementedException();
        }

        //Getting Random Fortune Scenario Helper Methods

        public void ThenIShouldSeetheTextBlockwithFortune()
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeTextboxWithFortune()
        {
            throw new NotImplementedException();
        }

        [ClassCleanup]
        public static void TearDown()
        {
            window.Close();
            application.Close();
        }
    }
}
