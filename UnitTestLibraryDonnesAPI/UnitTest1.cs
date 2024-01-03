using CollecteDeDonnees;
using LibraryDonnesAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestLibraryDonnesAPI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetWebDonne()
        {
            FakeRequest fake  = new FakeRequest();

            //call the second constructor class DonneLibrary
            DonneLibrary target  = new DonneLibrary(fake);

            List<LineDonne> result = target.GetWebDonne();

            
            Assert.AreEqual(12, result.Count);
            Assert.AreEqual("SEM:1696", result[0].id);
            Assert.AreEqual("Grenoble, Chavant", result[0].name);


        }
    }
}
