namespace AddTwoNumbers

{
    /// <summary>
    /// MakeCount implementation
    /// </summary>
    public class MakeCount
    {
        /// <summary>
        /// Get two lists and make count
        /// </summary>
        /// <param name="firstList">First list</param>
        /// <param name="secondList">Second list</param>
        /// <returns>Reverse sum char list</returns>
        public char[] TakeAndCount(char[] firstList, char[] secondList)
        {
            var countResult = int.Parse(string.Join("", firstList)) + int.Parse(string.Join("", secondList));

            return countResult.ToString().Reverse().ToArray();
        }
    }
}
