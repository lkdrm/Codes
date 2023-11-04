using NUnit.Framework;

namespace Anagram.Tests
{
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// If reverse correctly.
        /// </summary>
        [Test]
        public void ReverseWordTest()
        {
            var reverseWord = Anagram.ReverseWords("Number");

            Assert.That(reverseWord, Is.EqualTo("rebmuN"));
        }

        /// <summary>
        /// If reverse correctly strings with using spaces.
        /// </summary>
        [Test]
        public void ReverseWordWithSpaces() 
        {
            var reverseWord = Anagram.ReverseWords("Word with space");

            Assert.That(reverseWord, Is.EqualTo("droW htiw ecaps"));
        }

        /// <summary>
        /// If return empty string.
        /// </summary>
        [Test]
        public void ReverseWordSpaceString()
        {
            var reverseWord = Anagram.ReverseWords(" ");

            Assert.That(reverseWord, Is.EqualTo(" "));
        }

        /// <summary>
        /// If reverse correctly strings with using numbers.
        /// </summary>
        [Test]
        public void ReverseWordWithNumbers()
        {
            var reverseWord = Anagram.ReverseWords("Its f4u");

            Assert.That(reverseWord, Is.EqualTo("stI u4f"));
        }

        /// <summary>
        /// If reverse correctly strings with using numbers and punctuations.
        /// </summary>
        [Test]
        public void ReverseWordWithNumbersAndPunctuations()
        {
            var reverseWord = Anagram.ReverseWords("!Warning, using correct5 and p5and28. Why?");

            Assert.That(reverseWord, Is.EqualTo("!gninraW, gnisu tcerroc5 dna d5nap28. yhW?"));
        }
    }
}