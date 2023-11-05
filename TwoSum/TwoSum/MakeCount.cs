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
        /// Will count numbers and return from list current target number
        /// </summary>
        /// <param name="targetNumber">Which number must be returned</param>
        public int[] FindTargetNumber(int targetNumber)
        {
            for (int i = 0; i < Numbers.Count; i++)
            {
                for (int j = 1; j < Numbers.Count; j++)
                {
                    if ((Numbers[i] + Numbers[j]).Equals(targetNumber))
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        else
                        {
                            return new int[] { i, j };
                        }
                    }
                }
            }

            return new int[] { -1, -1 };
        }

        /// <summary>
        /// Will count numbers used array and return from array current target number
        /// </summary>
        /// <param name="numbers">Array of numbers</param>
        /// <param name="targetNumber">Which number must be returned</param>
        /// <returns>Indexes which was used to find a sum of target number</returns>
        public int[] FindTargetNumber(int[] numbers, int targetNumber)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    if ((numbers[i] + numbers[j]).Equals(targetNumber))
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        else
                        {
                            return new int[] { i, j };
                        }
                    }
                }
            }

            return new int[] { -1, -1 };
        }
    }
}