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
            //Arrange
            FakeRequest fake  = new FakeRequest();

            //call the second constructor class DonneLibrary
            DonneLibrary target  = new DonneLibrary(fake);

            string X = "5.731358767949209";
            String Y = "45.18457681950622";
            String D = "300";
            String B = "true";

            String url = $"http://data.mobilites-m.fr/api/linesNear/json?x={X}&y={Y}&dist={D}&details={B}";

            //Act
            List<LineDonne> result = target.GetWebDonne(url);

            //assert Verification 
            Assert.AreEqual(12, result.Count);
            Assert.AreEqual("SEM:1696", result[0].id);
            Assert.AreEqual("Grenoble, Chavant", result[0].name);


        }
    }
}
