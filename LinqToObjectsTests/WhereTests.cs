using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LinqToObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqToObjectsTests
{
    [TestClass]
    public class WhereTests
    {

        [TestMethod]
        public void WhereShouldReturnSubListOfObjectsThatMeetPredicateCriteria()
        {
            String[] list = new String[10];
            for (int i = 0; i < 10; i++)
                list[i] = i.ToString();

            var subList = list.Where(s=>s.StartsWith("1"));
            var enumerator = subList.GetEnumerator();
            enumerator.MoveNext();
            
            Assert.AreEqual(1, subList.Count());
            Assert.AreEqual(list[1], enumerator.Current);
        }

        [TestMethod]
        public void WhereShouldWorkWithComplexTypesAndReturnObjectsThatMeetPredicateCriteria()
        {
            Pet[] pets = { new Pet { Name="Barley", Vaccinated=false },
                         new Pet { Name="Boots", Vaccinated=true },
                         new Pet { Name="Whiskers", Vaccinated=false } };

            var subList = pets.Where(s => s.Vaccinated.Equals(true));
            var enumerator = subList.GetEnumerator();
            enumerator.MoveNext();

            Assert.AreEqual(pets[1], enumerator.Current);
        }

        [TestMethod]
        public void WhereShouldWorkWithIndexAndReturnObjectsThatMeetPredicateCriteria()
        {
            int[] numbers = { 0, 30, 20, 15, 90, 85, 40, 75 };

            var query = numbers.Where((number, index) => number <= index * 10);
            var enumerator = query.GetEnumerator();

            int[] expectedResults = { 0, 20, 15, 40 };

            Assert.AreEqual(expectedResults.Count(), query.Count());
            for (Int32 i = 0; i < expectedResults.Count(); i++)
            {
                enumerator.MoveNext();
                Assert.AreEqual(expectedResults[i], enumerator.Current);
            }
        }
    }
}
