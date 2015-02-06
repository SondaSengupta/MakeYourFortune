﻿using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace FortuneTest
{
    [TestClass]
    public class ZeroState
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;

        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\FortuneTest\\bin\\Debug\\MakeYourFortune");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);

        }
        [TestMethod]
        public void TestZeroState()
        {
            TextBox text_box = window.Get<TextBox>("FortuneMakerTextBox");
            Label output_label = window.Get<Label>("FortuneOutput");
            Button submit_button = window.Get<Button>("SubmitButton");
            

            Button career_button = window.Get<Button>("CareerButton");
            Button health_button = window.Get<Button>("HealthButton");
            Button relationship_button = window.Get<Button>("RelationshipButton");
            Button life_button = window.Get<Button>("LifeButton");

            Assert.IsTrue(text_box.Enabled);
            Assert.AreEqual(text_box.Text, "Enter your favorite fortune here...");
            Assert.IsFalse(submit_button.Enabled);

            Assert.AreEqual(output_label.Text, "Select your Fortune");
            Assert.IsTrue(career_button.Enabled);
            Assert.IsTrue(health_button.Enabled);
            Assert.IsTrue(relationship_button.Enabled);
            Assert.IsTrue(life_button.Enabled);

        }

        [ClassCleanup]
        public static void TearDown()
        {
            window.Close();
            application.Close();
        }
    }
}
