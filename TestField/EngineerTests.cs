using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2.Tests
{
    [TestClass]
    public class EngineerTests
    {
        [TestMethod]
        public void Constructor_InitializeProperties_CorrectInitialization()
        {
            // Arrange
            string fullName = "Михаил Носков";
            Engineer.WorkType currentWork = Engineer.WorkType.Drill;
            Well well = new Well(0001, false);
            Field field = new Field();

            // Act
            Engineer engineer = new Engineer(fullName, currentWork, well, field);

            // Assert
            Assert.AreEqual(fullName, engineer.FullName);
            Assert.AreEqual(currentWork, engineer.CurrentWork);
            Assert.AreEqual(well, engineer.Well);
            Assert.AreEqual(field, engineer.Field);
        }

        [TestMethod]
        public void DrillField_MethodExecution_IsEngDrillTrue()
        {
            // Arrange
            Engineer engineer = new Engineer("Михаил Носков", Engineer.WorkType.Drill, new Well(0001,true), new Field());

            // Act
            engineer.DrillField(engineer.Field);

            // Assert
            Assert.IsTrue(engineer.IsEngDrill);
        }

        [TestMethod]
        public void ExtractWell_MethodExecution_IsEngExtractTrue()
        {
            // Arrange
            Engineer engineer = new Engineer("Михаил Носков", Engineer.WorkType.Extract, new Well(0001, true), new Field());

            // Act
            engineer.ExtractWell(engineer.Well);

            // Assert
            Assert.IsTrue(engineer.IsEngExtract);
        }

        [TestMethod]
        public void NotDrillField_MethodExecution_IsEngDrillFalse()
        {
            // Arrange
            Engineer engineer = new Engineer("Михаил Носков", Engineer.WorkType.Drill, new Well(0001, false), new Field());
            engineer.IsEngDrill = true; // Assume drilling was started

            // Act
            engineer.NotDrillField();

            // Assert
            Assert.IsFalse(engineer.IsEngDrill);
        }

        [TestMethod]
        public void NotExtractWell_MethodExecution_IsEngExtractFalse()
        {
            // Arrange
            Engineer engineer = new Engineer("Михаил Носков", Engineer.WorkType.Extract, new Well(0001, false), new Field());
            engineer.IsEngExtract = true; // Assume extraction was started

            // Act
            engineer.NotExtractWell(engineer.Well);

            // Assert
            Assert.IsFalse(engineer.IsEngExtract);
        }
    }
}