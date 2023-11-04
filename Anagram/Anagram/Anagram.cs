namespace Anagram
{
    /// <summary>
    /// Anagram - reversing string.
    /// </summary>
    public class Anagram
    {
        /// <summary>
        /// Reverse string from input.
        /// </summary>
        /// <param name="inputText">Input text/string.</param>
        /// <returns>Reversed string.</returns>
        public static string ReverseWords(string inputText)
        {
            var splitText = inputText.Split(" ");

            string[] reversedArray = new string[splitText.Length];
            
            var e = 0;

            foreach(var word in splitText)
            {
                List<char> charWords = word.ToList();
                List<char> numberAndPunctuations = new List<char>();
                List<char> reversedChars= new List<char>();
                
                for(var i=charWords.Count-1; i>-1; i--) 
                {
                    if (Char.IsNumber(charWords[i]) || Char.IsPunctuation(charWords[i]))
                    {
                        numberAndPunctuations.Add(charWords[i]);
                    }
                    else
                    {
                        reversedChars.Add(charWords[i]);
                    }
                }

                for(var element=numberAndPunctuations.Count-1; element>-1; element--) 
                {
                    reversedChars.Insert(charWords.FindIndex(e => e.Equals(numberAndPunctuations[element])),numberAndPunctuations[element]);
                }
                
                charWords.Clear();
                numberAndPunctuations.Clear();

                reversedArray[e] = string.Join("",reversedChars);
                e++;
            }
            return string.Join(" ", reversedArray);
        }
    }
}
