using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MakeYourFortune.Model;

namespace FortuneTest
{
    [TestClass]
    public class FortuneItemModelTest
    {

        [TestMethod]
        public void FortuneConstructorStoresItsProperties()
        {
            FortuneItem kidnapped = new FortuneItem("Help! I'm being forced to work in a Chinese Bakery", "Relationships");
            Assert.AreEqual("Help! I'm being forced to work in a Chinese Bakery", kidnapped.FortuneText);
            Assert.AreEqual("Relationships", kidnapped.FortuneCategory);
        }
    }
}
