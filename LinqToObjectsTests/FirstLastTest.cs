using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LinqToObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqToObjectsTests
{
    [TestClass]
    public class FirstLastTest
    {
        [TestMethod]
        public void FirstShouldReturnFirstElementInList()
        {
            var list = new String[10];
            for (int i = 0; i < 10; i++)
                list[i] = i.ToString();

            var firstObject = list.First();
            Assert.AreEqual(list[0], firstObject);
        }

        [TestMethod]
        public void FirstShouldReturnFirstElementInListMatchingPredicateCriteria()
        {
            var list = new String[10];
            for (int i = 0; i < 10; i++)
                list[i] = i.ToString();

            var firstObject = list.First(s => s.Equals("3"));
            Assert.AreEqual(list[3], firstObject);
        }

        [TestMethod]
        public void LastShouldReturnLastElementInList()
        {
            var list = new String[10];
            for (int i = 0; i < 10; i++)
                list[i] = i.ToString();

            var firstObject = list.Last();
            Assert.AreEqual(list[9], firstObject);
        }

        [TestMethod]
        public void LastShouldReturnLastElementInListMatchingPredicateCriteria()
        {
            var list = new String[10];
            for (int i = 0; i < 10; i++)
                list[i] = i.ToString();

            var firstObject = list.Last(s => s.Equals("3"));
            Assert.AreEqual(list[3], firstObject);
        }
    }
}
