namespace UnitTests.Challenge.Console.Services
{
    /// <summary>
    /// Provides methods for performing validations on lists of integers.
    /// </summary>
    public class ListValidations
    {
        /// <summary>
        /// Removes negative numbers from the given list.
        /// </summary>
        /// <param name="list">The list of integers from which negative numbers will be removed.</param>
        /// <returns>A list containing only positive integers.</returns>
        public List<int> RemoveNegativeNumbers(List<int> list)
        {
            var listWithoutNegatives = list.Where(x => x > 0);
            return listWithoutNegatives.ToList();
        }

        /// <summary>
        /// Checks if the given list contains a specific number.
        /// </summary>
        /// <param name="list">The list of integers to be checked.</param>
        /// <param name="number">The number to search for in the list.</param>
        /// <returns>True if the number is found in the list, false otherwise.</returns>
        public bool ListContainsNumber(List<int> list, int number)
        {
            var contains = list.Contains(number);
            return contains;
        }

        /// <summary>
        /// Multiplies each number in the list by a specified number.
        /// </summary>
        /// <param name="list">The list of integers to be multiplied.</param>
        /// <param name="number">The multiplier.</param>
        /// <returns>A list containing the result of multiplying each element of the original list by the specified number.</returns>
        public List<int> MultiplyListNumbers(List<int> list, int number)
        {
            var multipliedList = list.Select(x => x * number).ToList();
            return multipliedList;
        }

        /// <summary>
        /// Returns the greater number from the given list.
        /// </summary>
        /// <param name="list">The list of integers.</param>
        /// <returns>The greater number in the list.</returns>
        public int ReturnGreaterNumberInList(List<int> list)
        {
            return list.Max();
        }

        /// <summary>
        /// Returns the smallest number from the given list.
        /// </summary>
        /// <param name="list">The list of integers.</param>
        /// <returns>The smallest number in the list.</returns>
        public int ReturnSmallestNumberInList(List<int> list)
        {
            return list.Min();
        }
    }
}
