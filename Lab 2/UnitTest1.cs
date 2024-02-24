using NUnit.Framework;
namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            // Add another test
            // Arrange
            int firstAngle = 40;
            int secondAngle = 40;
            int thirdAngle = 100;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        // Add more test methods as needed to cover different scenarios
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage2()
        {
            // Add another test
            // Arrange
            int firstAngle = 50;
            int secondAngle = 50;
            int thirdAngle = 80;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage3()
        {
            // Add another test
            // Arrange
            int firstAngle = 70;
            int secondAngle = 60;
            int thirdAngle = 50;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage4()
        {
            // Add another test
            // Arrange
            int firstAngle = 40;
            int secondAngle = 30;
            int thirdAngle = 110;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage5()
        {
            // Add another test
            // Arrange
            int firstAngle = -50;
            int secondAngle = 50;
            int thirdAngle = 80;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is invalid.", result);
        }
    }
}

