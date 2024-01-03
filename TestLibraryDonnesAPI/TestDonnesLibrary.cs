using CollecteDeDonnees;
using LibraryDonnesAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestLibraryDonnesAPI
{
    [TestClass]
    public class TestLibraryB
    {
        [TestMethod]
        public void TestGetWebDonne()
        {

            FakeLibraryB fake = new FakeLibraryB();
            DonneLibrary target = new DonneLibrary();

            List<LineDonne> result = target.GetWebDonne();
            Assert.IsNotNull(result);
        }
    }
}
