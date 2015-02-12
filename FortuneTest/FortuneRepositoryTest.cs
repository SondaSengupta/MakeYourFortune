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
            throw new NotImplementedException();
        }

       [TestMethod]
       public void DatabaseGetCount()
       {
           throw new NotImplementedException();
       }

       [TestMethod]
       public void DatabaseClearAll()
       {
           throw new NotImplementedException();
       }

       [TestMethod]
       public void DatabaseDeleteItem()
       {
           throw new NotImplementedException();
       }

    }
}
