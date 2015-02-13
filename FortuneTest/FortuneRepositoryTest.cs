using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MakeYourFortune;
using MakeYourFortune.Repository;
using MakeYourFortune.Model;
using System.Text;
using System.Collections.Generic;


namespace FortuneTest
{
    [TestClass]
    public class FortuneRepositoryTest
    {
        private static FortuneRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new FortuneRepository();
            repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();
            repo.Dispose();
        }

       [TestMethod]
        public void DatabaseAddItem()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new FortuneItem("You will be given a great deal of hugs.", "Relationships"));
            Assert.AreEqual(1, repo.GetCount());
        }

       [TestMethod]
       public void DatabaseGetCount()
       {
           repo.Add(new FortuneItem("Your job will take a turn for the worst", "Careers"));
           repo.Add(new FortuneItem("Your significant other will break up with you", "Relationships"));
           Assert.AreEqual(2, repo.GetCount());
       }

       [TestMethod]
       public void DatabaseClearAll()
       {
           repo.Add(new FortuneItem("Your job will take a turn for the worst", "Careers"));
           repo.Add(new FortuneItem("Your significant other will break up with you", "Relationships"));
           repo.Clear();
           Assert.AreEqual(0, repo.GetCount());
       }

       [TestMethod]
       public void DatabaseDeleteItem()
       {
           Assert.AreEqual(0, repo.GetCount());
           FortuneItem hugs = new FortuneItem("You will be given a great deal of hugs.", "Relationships");
           repo.Add(hugs);
           repo.Delete(hugs.FortuneId);
           Assert.AreEqual(0, repo.GetCount());
       }

    }
}
