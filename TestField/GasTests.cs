using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2.Tests
{
    [TestClass]
    public class GasTests
    {
        [TestMethod]
        public void TransportGas_WhenCalled_ShouldSetIsGasTransportTrue()
        {
            // Arrange
            Chemist chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.Analyze);
            Transport transport = new Transport(0001);
            Gas gas = new Gas(chemist, transport);

            // Act
            gas.TransportGas(transport);

            // Assert
            Assert.IsTrue(gas.IsGasTrancport);
        }

        [TestMethod]
        public void NotTransportGas_WhenCalled_ShouldSetIsGasTransportFalse()
        {
            // Arrange
            Chemist chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.QAReport);
            Transport transport = new Transport(0001);
            Gas gas = new Gas(chemist, transport);

            // Act
            gas.NotTransportGas(transport);

            // Assert
            Assert.IsFalse(gas.IsGasTrancport);
        }

        [TestMethod]
        public void AnalyseGas_WhenCalled_ShouldSetIsGasAnalyzeTrue()
        {
            // Arrange
            Chemist chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.Analyze);
            Transport transport = new Transport(0001);
            Gas gas = new Gas(chemist, transport);

            // Act
            gas.AnalyseGas(chemist);

            // Assert
            Assert.IsTrue(gas.IsGasAnalyze);
        }

        [TestMethod]
        public void NotAnalyseGas_WhenCalled_ShouldSetIsGasAnalyzeFalse()
        {
            // Arrange
            Chemist chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.QAReport);
            Transport transport = new Transport(0001);
            Gas gas = new Gas(chemist, transport);

            // Act
            gas.NotAnalyseGas(chemist);

            // Assert
            Assert.IsFalse(gas.IsGasAnalyze);
        }
    }
}