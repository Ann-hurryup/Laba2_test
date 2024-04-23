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
    public class FieldTests
    {
        [TestMethod]
        public void IdField_SetValidId_CheckIfIdSetCorrectly()
        {
            // Arrange
            Field field = new Field();

            // Act
            field.IdField = 1001;

            // Assert
            Assert.AreEqual(1001, field.IdField);
        }

        [TestMethod]
        public void IsDrill_SetTrue_CheckIfDrillingInProgress()
        {
            // Arrange
            Field field = new Field();

            // Act
            field.DrillField();

            // Assert
            Assert.IsTrue(field.IsDrill);
        }

        [TestMethod]
        public void IsDrill_SetFalse_CheckIfDrillingStopped()
        {
            // Arrange
            Field field = new Field();
            field.DrillField(); // Start drilling

            // Act
            field.NotDrillField();

            // Assert
            Assert.IsFalse(field.IsDrill);
        }
    }
}