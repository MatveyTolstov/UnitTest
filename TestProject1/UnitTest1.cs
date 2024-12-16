using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Test2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private CollectionTest collectionTest;

        private PercentageCalculator percentageCalculator;

        [TestInitialize]
        public void Setup()
        {
            collectionTest = new CollectionTest();

            percentageCalculator = new PercentageCalculator();
        }

        [TestMethod]
        public void TestMethod_CollectionEquals()
        {
            List<string> expectedStudents = new List<string>
            {
                "Barry",
                "Alan",
                "Casly",
                "Dex"
            };


            var actualStudents = collectionTest.Initialize();

            CollectionAssert.AreEqual(expectedStudents, actualStudents);
        }

        [TestMethod]
        public void TestMethod_CollectionAreEquivalent()
        {

            List<string> expectedStudents = new List<string>
            {
                "Barry",
                "Alan",
                "Casly",
                "Dex"
            };

            var actualStudents = collectionTest.Initialize();

            CollectionAssert.AreEquivalent(expectedStudents, actualStudents);
        }
        
        [TestMethod]
        public void TestMethod_CalculatePercentage_ValidInput()
        {
            
            double total = 200;
            double part = 50;
            double expectedPercentage = 25.0;
            double delta = 0.0001; 

            double actualPercentage = PercentageCalculator.CalculatePercentage(total, part);

            Assert.AreEqual(expectedPercentage, actualPercentage, delta);
        }
    }
}