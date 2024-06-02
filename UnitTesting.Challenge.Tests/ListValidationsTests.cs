using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Challenge.Console.Services;

namespace UnitTests.Challenge.Tests
{
    /// <summary>
    /// Contains unit tests for the ListValidations class.
    /// </summary>
    public class ListValidationsTests
    {
        private ListValidations _validations = new ListValidations();

        /// <summary>
        /// Tests the RemoveNegativeNumbers method of the ListValidations class.
        /// </summary>
        [Fact]
        public void ShouldRemoveNegativeNumbersFromList()
        {
            // Arrange
            var list = new List<int> { 5, -1, -8, 9 };
            var expected = new List<int> { 5, 9 };

            // Act
            var result = _validations.RemoveNegativeNumbers(list);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Tests the ListContainsNumber method of the ListValidations class.
        /// </summary>
        [Fact]
        public void ShouldContainNumber9InList()
        {
            // Arrange
            var list = new List<int> { 5, -1, -8, 9 };
            var numberToFind = 9;

            // Act
            var result = _validations.ListContainsNumber(list, numberToFind);

            // Assert
            Assert.True(result);
        }

        /// <summary>
        /// Tests the ListContainsNumber method of the ListValidations class when number is not in list.
        /// </summary>
        [Fact]
        public void ShouldNotContainNumber10InList()
        {
            // Arrange
            var list = new List<int> { 5, -1, -8, 9 };
            var numberToFind = 10;

            // Act
            var result = _validations.ListContainsNumber(list, numberToFind);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// Tests the MultiplyListNumbers method of the ListValidations class.
        /// </summary>
        [Fact]
        public void ShouldMultiplyElementsInListBy2()
        {
            // Arrange
            var list = new List<int> { 5, 7, 8, 9 };
            var expected = new List<int> { 10, 14, 16, 18 };

            // Act
            var result = _validations.MultiplyListNumbers(list, 2);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Tests the ReturnGreaterNumberInList method of the ListValidations class.
        /// </summary>
        [Fact]
        public void ShouldReturn9AsGreaterNumberInList()
        {
            // Arrange
            var list = new List<int> { 5, -1, -8, 9 };

            // Act
            var result = _validations.ReturnGreaterNumberInList(list);

            // Assert
            Assert.Equal(9, result);
        }

        /// <summary>
        /// Tests the ReturnSmallestNumberInList method of the ListValidations class.
        /// </summary>
        [Fact]
        public void ShouldReturnNegative8AsSmallestNumberInList()
        {
            // Arrange
            var list = new List<int> { 5, -1, -8, 9 };

            // Act
            var result = _validations.ReturnSmallestNumberInList(list);

            // Assert
            Assert.Equal(-8, result);
        }
    }
}
