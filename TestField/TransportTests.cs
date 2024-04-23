using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2.Tests
{
    [TestClass]
    public class TransportTests
    {
        [TestMethod]
        public void TestTransportTrans()
        {
            // Arrange
            int id = 0001; // Пример идентификатора транспорта
            var transport = new Transport(id);

            // Act
            transport.Trans();

            // Assert
            Assert.IsTrue(transport.IsTransporting);
        }

        [TestMethod]
        public void TestTransportNotTran()
        {
            // Arrange
            int id = 0002; // Пример идентификатора транспорта
            var transport = new Transport(id);
            transport.Trans(); // Предположим, что в начале транспорт уже в пути

            // Act
            transport.NotTran();

            // Assert
            Assert.IsFalse(transport.IsTransporting);
        }
    }
}