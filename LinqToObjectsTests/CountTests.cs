using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqToObjects;
using System.Collections;

namespace LinqToObjectsTests
{
    [TestClass]
    public class CountTests
    {
        [TestMethod]
        public void CountShouldWorkWithStringArrayAndReturnActualNumberOfElements()
        {
            string[] list = new string[10];
            for (int i = 0; i < 10; i++)
                list[i] = i.ToString();

            Assert.AreEqual(10, list.Count());
        }

        [TestMethod]
        public void CountShouldWorkWithCharacterArrayAndReturnActualNumberOfElements()
        {
            var myList = "".PadRight(10, 'A').ToCharArray();
            myList.Count();

            Assert.AreEqual(10, myList.Count());
        }

        [TestMethod]
        public void CountMethodWithPredicateShouldAccuratelyEvaluatePredicate()
        {
            string[] list = new string[10];
            for (int i = 0; i < 10; i++)
                list[i] = i.ToString();

            Assert.AreEqual(1, list.Count(s => s == "1"));
        }

        [TestMethod]
        public void CountWorksWithListOfComplexObjects()
        {
            Pet[] pets = { new Pet { Name="Barley", Vaccinated=true },
                         new Pet { Name="Boots", Vaccinated=false },
                         new Pet { Name="Whiskers", Vaccinated=false } };

            Assert.AreEqual(1, pets.Count(p => p.Vaccinated));
            Assert.AreEqual(2, pets.Count(p => !p.Vaccinated));
        }
    }
}
