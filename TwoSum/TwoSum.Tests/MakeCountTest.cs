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
            findNumber.Numbers.AddRange(new[] { 1, 2, 3 });

            var returnedNumbers = findNumber.FindTargetNumber(5);
            var expectedNumbers = "[1,2]";

            Assert.That(returnedNumbers, Is.EqualTo(expectedNumbers));
        }

        /// <summary>
        /// Check if FindTargetNumber return correct used indexes from Array
        /// </summary>
        [Test]
        public void ReturnedIndexesFromArray()
        {
            var findNumbers = new MakeCount();

            var sendingArray = new int[] { 1, 2, 3 };
            var returnedNumbers = findNumbers.FindTargetNumber(sendingArray, 5);
            var expectedResult = "[1,2]";

            Assert.That(returnedNumbers, Is.EqualTo(expectedResult));
        }
    }
}