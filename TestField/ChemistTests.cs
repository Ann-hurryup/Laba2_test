using Microsoft.VisualStudio.TestTools.UnitTesting;
using lr2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2.Tests
{

    [TestClass]
    public class ChemistTests
    {
        [TestMethod]
        public void Constructor_InitializeProperties_CorrectInitialization()
        {
            // Arrange
            string fullName = "Иван Иванов";
            Chemist.WorkTypeCh workType = Chemist.WorkTypeCh.Analyze;

            // Act
            Chemist chemist = new Chemist(fullName, workType);

            // Assert
            Assert.AreEqual(fullName, chemist.FullNameCh);
            Assert.AreEqual(workType, chemist.CurrentWorkCh);
        }

        [TestMethod]
        public void Analyze_MethodExecution_IsAnalyzeTrue()
        {
            // Arrange
            Chemist chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.Analyze);

            // Act
            chemist.Analyze();

            // Assert
            Assert.IsTrue(chemist.IsAnalyze);
        }

        [TestMethod]
        public void QAReport_MethodExecution_IsAnalyzeFalse()
        {
            // Arrange
            Chemist chemist = new Chemist("Петр Петров", Chemist.WorkTypeCh.QAReport);

            // Act
            chemist.QAReport();

            // Assert
            Assert.IsFalse(chemist.IsAnalyze);
        }
    }
}