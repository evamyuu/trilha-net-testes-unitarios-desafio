namespace UnitTests.Challenge.Console.Services
{
    /// <summary>
    /// Provides methods for performing validations on strings.
    /// </summary>
    public class StringValidations
    {
        /// <summary>
        /// Returns the number of characters in a string.
        /// </summary>
        /// <param name="text">The input string.</param>
        /// <returns>The number of characters in the input string.</returns>
        public int ReturnCharacterCount(string text)
        {
            var characterCount = text.Length;
            return characterCount;
        }

        /// <summary>
        /// Checks if a string contains a specified substring.
        /// </summary>
        /// <param name="text">The input string to search within.</param>
        /// <param name="searchString">The substring to search for.</param>
        /// <returns>True if the substring is found in the string, false otherwise.</returns>
        public bool ContainsCharacter(string text, string searchString)
        {
            var contains = text.Contains(searchString);
            return contains;
        }

        /// <summary>
        /// Checks if a string ends with a specified suffix.
        /// </summary>
        /// <param name="text">The input string.</param>
        /// <param name="searchString">The suffix to search for.</param>
        /// <returns>True if the string ends with the specified suffix, false otherwise.</returns>
        public bool TextEndsWith(string text, string searchString)
        {
            var endsWith = text.EndsWith(searchString);
            return endsWith;
        }
    }
}