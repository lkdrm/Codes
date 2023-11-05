namespace TwoSum
{
    /// <summary>
    /// Two Sum implementation
    /// </summary>
    public class MakeCount
    {
        /// <summary>
        /// Array of numbers
        /// </summary>
        public List<int> Numbers = new();

        /// <summary>
        /// Sum of two numbers
        /// </summary>
        private int SumOfNumbers { get; set; }

        /// <summary>
        /// Will be used to find a index
        /// </summary>
        private int UsedFirstNumber = 0;

        /// <summary>
        /// Will be used to find a index
        /// </summary>
        private int UsedSecondNumber = 0;

        /// <summary>
        /// Will count numbers and return from list current target number
        /// </summary>
        /// <param name="targetNumber">Which number must be returned</param>
        public string FindTargetNumber(int targetNumber)
        {
            for (int i = 0; i < Numbers.Count; i++)
            {
                for (int j = 1; j < Numbers.Count; j++)
                {
                    if (Numbers.Count > 2 && Numbers[i] == Numbers[j])
                    {
                        continue;
                    }

                    SumOfNumbers = Numbers[i] + Numbers[j];
                    UsedFirstNumber = Numbers[i];
                    UsedSecondNumber = Numbers[j];

                    if (SumOfNumbers == targetNumber)
                    {
                        break;
                    }
                }

                if (SumOfNumbers == targetNumber)
                {
                    SumOfNumbers = 0;
                    break;
                }
            }

            if (Numbers.Count < 3)
            {
                return "[0,1]";

            }
            else
            {
                return $"[{Numbers.IndexOf(UsedFirstNumber)},{Numbers.IndexOf(UsedSecondNumber)}]";
            }
        }

        /// <summary>
        /// Will count numbers used array and return from array current target number
        /// </summary>
        /// <param name="numbers">Array of numbers</param>
        /// <param name="targetNumber">Which number must be returned</param>
        /// <returns>Indexes which was used to find a sum of target number</returns>
        public string FindTargetNumber(int[] numbers, int targetNumber)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if (numbers.Length > 2 && numbers[i] == numbers[j])
                    {
                        continue;
                    }

                    SumOfNumbers = numbers[i] + numbers[j];
                    UsedFirstNumber = numbers[i];
                    UsedSecondNumber = numbers[j];

                    if (SumOfNumbers == targetNumber)
                    {
                        break;
                    }
                }

                if (SumOfNumbers == targetNumber)
                {
                    SumOfNumbers = 0;
                    break;
                }
            }

            if (numbers.Length < 3)
            {
                return "[0,1]";
            }
            else
            {
                return $"[{Array.FindIndex(numbers, n => n.Equals(UsedFirstNumber))},{Array.FindIndex(numbers, n => n.Equals(UsedSecondNumber))}]";
            }
        }
    }
}