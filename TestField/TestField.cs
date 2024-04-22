namespace Tests
{
    [TestClass]
    public class TestField
    {
        [TestMethod]
        public void IdFieldTest()
        {
            // Arrange
            Field field = new Field();

            // Act
            field.IdField = 00001;

            // Assert
            Assert.AreEqual(00001, field.IdField);
        }
    }
}