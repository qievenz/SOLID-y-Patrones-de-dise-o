using _09.Patron.Creacional.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PruebasUnitarias
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var finder = new SingletonFinder(new DummyDatabase());
            var total = finder.GetPopulation(new [] {"London", "Beijing"});

            Assert.AreEqual(8630100 + 20693000, total);
        }
    }

    public class DummyDatabase : ISingletonContainer
    {
        public int GetPopulation(string name)
        {
            return new Dictionary<string, int>
            {
                ["London"] = 8630100,
                ["Beijing"] = 20693000,
            }[name];
        }
    }
}
