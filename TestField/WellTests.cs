using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2.Tests
{
    [TestClass]
    public class WellTests
    {
        private Well well;

        [TestInitialize]
        public void Initialize()
        {
            well = new Well(0001, false);
        }

        [TestMethod]
        public void TestIdWell()
        {
            Assert.AreEqual(well.IdWell, 1);
        }

        [TestMethod]
        public void TestIsExtract()
        {
            Assert.IsFalse(well.IsExtract);
        }

        [TestMethod]
        public void TestExtractWell()
        {
            well.ExtractWell();
            Assert.IsTrue(well.IsExtract);
        }

        [TestMethod]
        public void TestNotExtractWell()
        {
            well.NotExtractWell();
            Assert.IsFalse(well.IsExtract);
        }
    }
}