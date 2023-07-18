using Aufgabe1.Controllers;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Aufgabe1.Tests
{
    [TestFixture]
    public class FizzBuzzControllerTests
    {
        [Test] // valid input test
        // compare FizzBuzz of 15 with the expected output
        public void GetFizzBuzzForPositiveNumber()
        {
            // Arrange
            var controller = new FizzBuzzController ();
            string number = "15";
            FizzBuzz[] expectedResult = { new FizzBuzz(3), new FizzBuzz(5) , new FizzBuzz(6), new FizzBuzz(9), new FizzBuzz(10), new FizzBuzz(12), new FizzBuzz(15) };
            string expectedJson = JsonSerializer.Serialize(expectedResult);

            // Act
            FizzBuzz[] actualResult = controller.Get(number);
            string actualJson = JsonSerializer.Serialize(actualResult);

            // Assert
            Assert.That(actualJson, Is.EqualTo(expectedJson));
        }

        [Test] // input equal to 0 test
        // compare FizzBuzz of 0 with the expected output which is empty
        public void GetFizzBuzzForZero()
        {
            // Arrange
            var controller = new FizzBuzzController();
            string number = "0";
            string expectedResult = "Id value must be bigger than 0";

            // Act
            string actualResult = controller.Get(number);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test] // not valid input (negative) test
        // result should be empty 
        public void GetFizzBuzzForNegativeNumber()
        {
            // Arrange
            var controller = new FizzBuzzController();
            string number = "-1";
            string expectedResult = "Id value must be bigger than 0";

            // Act
            string actualResult = controller.Get(number);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test] // not valid input (not a number) test
        // result should be empty 
        public void FizzBuzzForNotNumericInput()
        {
            // Arrange
            var controller = new FizzBuzzController();
            string number = "12a1";
            string expectedResult = "Id value must be of type int, got non-numeric";

            // Act
            string actualResult = controller.Get(number);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test] // empty input test
        // result should be empty 
        public void GetFizzBuzzForEmptyInput()
        {
            // Arrange
            var controller = new FizzBuzzController();
            string number = "";
            string expectedResult = "id can't be empty";

            // Act
            string actualResult = controller.Get(number);

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}