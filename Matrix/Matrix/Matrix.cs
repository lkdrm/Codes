namespace MatrixTrace
{
    /// <summary>
    /// Matrix implementation
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Get/Set matrix row
        /// </summary>
        public int MatrixRow { get; set; }

        /// <summary>
        /// Get/Set matrix column
        /// </summary>
        public int MatrixColumn { get; set; }

        /// <summary>
        /// Empty matrix
        /// </summary>
        public int[,] MatrixNumbers;

        /// <summary>
        /// Matrix trace numbers
        /// </summary>
        private static readonly List<int> _matrixTraceNumbers = new();

        /// <summary>
        /// Create matrix
        /// </summary>
        public void MakeMatrix()
        {
            MatrixNumbers = new int[MatrixRow, MatrixColumn];

            var randomNumbers = new Random();

            for (int i = 0; i < MatrixRow; i++)
            {
                for (int j = 0; j < MatrixColumn; j++)
                {
                    MatrixNumbers[i, j] = randomNumbers.Next(101);
                }
            }
        }

        /// <summary>
        /// Read numbers from matrix.
        /// </summary>
        public void ReadMatrix()
        {
            for (int i = 0; i < MatrixRow; i++)
            {
                for (int j = 0; j < MatrixColumn; j++)
                {
                    if (i.Equals(j))
                    {
                        var currentNumber = MatrixNumbers[i, j];

                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Black;
                        _matrixTraceNumbers.Add(currentNumber);
                        Console.Write(currentNumber);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write($"{MatrixNumbers[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Read and count matrix trace.
        /// </summary>
        /// <returns>Sum of numbers</returns>
        public static int FindMatrixTrace()
        {
            Console.WriteLine("Numbers of matrix trace:");

            foreach (var number in _matrixTraceNumbers)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(number);
                Console.ResetColor();
                Console.Write(" ");
            }

            Console.WriteLine();

            return _matrixTraceNumbers.Sum();
        }

        /// <summary>
        /// Reading matrix-numbers by snake method.
        /// </summary>
        public void SnakeReading()
        {
            SnakeMoveRight();
            SnakeMoveDown();
            SnakeMoveLeft();
            SnakeMoveMid();
        }

        /// <summary>
        /// Move right
        /// </summary>
        private void SnakeMoveRight()
        {
            var currentNumber = 0;

            while (currentNumber < MatrixColumn - 1)
            {
                Console.Write(MatrixNumbers[0, currentNumber] + " ");
                currentNumber++;
            }
        }

        /// <summary>
        /// Move down
        /// </summary>
        private void SnakeMoveDown()
        {
            var currentNumber = 0;

            while (currentNumber < MatrixRow)
            {
                Console.Write(MatrixNumbers[currentNumber, MatrixColumn - 1] + " ");
                currentNumber++;
            }
        }

        /// <summary>
        /// Move left
        /// </summary>
        private void SnakeMoveLeft()
        {
            var currentNumber = MatrixColumn - 2;

            while (currentNumber >= 0)
            {
                Console.Write(MatrixNumbers[MatrixRow - 1, currentNumber] + " ");
                currentNumber--;
            }
        }

        /// <summary>
        /// Move middle
        /// </summary>
        private void SnakeMoveMid()
        {
            var currentNumber = 0;

            while (currentNumber < MatrixColumn - 1)
            {
                Console.Write(MatrixNumbers[MatrixRow - 2, currentNumber] + " ");
                currentNumber++;
            }
        }
    }
}
