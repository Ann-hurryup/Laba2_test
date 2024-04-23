using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2.Tests
{
    [TestClass]
    public class OilTests
    {
        [TestMethod]
        public void TestOilTransport()
        {
            // Arrange
            var chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.Analyze);
            var transport = new Transport(0002);
            var oil = new Oil(chemist, transport);

            // Act
            oil.TransportOil(transport);

            // Assert
            Assert.IsTrue(oil.IsOilTransport);
        }

        [TestMethod]
        public void TestOilNotTransport()
        {
            // Arrange
            var chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.QAReport);
            var transport = new Transport(0002);
            var oil = new Oil(chemist, transport);

            // Act
            oil.NotTransportOil(transport);

            // Assert
            Assert.IsFalse(oil.IsOilTransport);
        }

        [TestMethod]
        public void TestOilAnalyse()
        {
            // Arrange
            var chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.Analyze);
            var transport = new Transport(0002);
            var oil = new Oil(chemist, transport);

            // Act
            oil.AnalyseOil(chemist);

            // Assert
            Assert.IsTrue(oil.IsOilTest);
        }

        [TestMethod]
        public void TestOilNotAnalyse()
        {
            // Arrange
            var chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.QAReport);
            var transport = new Transport(0002);
            var oil = new Oil(chemist, transport);

            // Act
            oil.NotAnalyseOil(chemist);

            // Assert
            Assert.IsFalse(oil.IsOilTest);
        }
    }
}