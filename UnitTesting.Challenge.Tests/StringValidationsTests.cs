using UnitTests.Challenge.Console.Services;

namespace UnitTests.Challenge.Tests
{
    /// <summary>
    /// Contains unit tests for the StringValidations class.
    /// </summary>
    public class StringValidationsTests
    {
        private StringValidations _validations = new StringValidations();

        /// <summary>
        /// Tests the ReturnCharacterCount method of the StringValidations class.
        /// </summary>
        [Fact]
        public void ShouldReturnCharacterCount6ForWordMatrix()
        {
            // Arrange
            var text = "Matrix";
            var expected = 6;

            // Act
            var result = _validations.ReturnCharacterCount(text);

            // Assert
            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Tests the ContainsCharacter method of the StringValidations class.
        /// </summary>
        [Fact]
        public void ShouldContainTheWordAnyInText()
        {
            // Arrange
            var text = "This is any text";
            var searchString = "any";

            // Act
            var result = _validations.ContainsCharacter(text, searchString);

            // Assert
            Assert.True(result);
        }

        /// <summary>
        /// Tests the ContainsCharacter method of the StringValidations class when the word is not in text.
        /// </summary>
        [Fact]
        public void ShouldNotContainTheWordTestInText()
        {
            // Arrange
            var text = "This is any text";
            var searchString = "test";

            // Act
            var result = _validations.ContainsCharacter(text, searchString);

            // Assert
            Assert.False(result);
        }

        /// <summary>
        /// Tests the TextEndsWith method of the StringValidations class.
        /// </summary>
        [Fact]
        public void ShouldEndWithTheWordSearchInText()
        {
            // Arrange
            var text = "Beginning, middle, end of the searched text";
            var searchString = "searched text";

            // Act
            var result = _validations.TextEndsWith(text, searchString);

            // Assert
            Assert.True(result);
        }
    }
}
