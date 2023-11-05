using NUnit.Framework;

namespace TwoSum.Tests
{
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Check if FindTargetNumber return correct used indexes from List 
        /// </summary>
        [Test]
        public void ReturnedIndexesFromList()
        {
            var findNumber = new MakeCount();
            findNumber.Numbers.AddRange(new[] { 2, 5, 5, 11, });
            var result = findNumber.FindTargetNumber(10);
            var usedNumbers = $"[{result[0]},{result[1]}]";
            Assert.That(usedNumbers, Is.EqualTo("[1,2]"));
        }

        /// <summary>
        /// Check if FindTargetNumber return correct used indexes from Array
        /// </summary>
        [Test]
        public void ReturnedIndexesFromArray()
        {
            var findNumbers = new MakeCount();
            var sendingArray = new int[] { 2, 5, 5, 11 };
            var result = findNumbers.FindTargetNumber(sendingArray, 10);
            var usedNumbers = $"[{result[0]},{result[1]}]";
            Assert.That(usedNumbers, Is.EqualTo("[1,2]"));
        }
    }
}