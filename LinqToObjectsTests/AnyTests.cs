using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LinqToObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqToObjectsTests
{
    [TestClass]
    public class AnyTests
    {
        [TestMethod]
        public void AnyShouldReturnTrueOnListGreaterThanOneInSize()
        {
            String[] list = new String[10];
            for (int i = 0; i < 10; i++)
                list[i] = i.ToString();

            Assert.IsTrue(list.Any());
        }

        [TestMethod]
        public void AnyShouldReturnFalseIfTheListIsEmpty()
        {
            List<String> list = new List<string>();

            Assert.IsFalse(list.Any());
        }
    }
}
