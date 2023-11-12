using System;

namespace Calculator
{
    /// <summary>
    /// Implementation for Calculation operations
    /// </summary>
    class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or Sets first number
        /// </summary>
        public string? Number { get; set; }

        /// <summary>
        /// Gets or Sets second number
        /// </summary>
        public string? SecondNumber { get; set; }

        /// <summary>
        /// Gets parameter if need to switch 
        /// <br>From setting first number to second</br>
        /// </summary>
        public bool SwitchNumber = false;

        /// <summary>
        /// Gets or Sets mathematic method
        /// </summary>
        public string? MathMethod { get; set; }

        /// <summary>
        /// Gets parameter if comma was set to number
        /// </summary>
        public bool WasSetComma = false;

        /// <summary>
        /// Used method to sets numbers
        /// <br>Bool state using when first number was set.</br>
        /// </summary>
        /// <param name="number">Number</param>
        public void SetNumber(int number)
        {
            if (!SwitchNumber)
            {
                Number += number;
            }
            else
            {
                SecondNumber += number;
            }
        }

        /// <summary>
        /// Used to show user number
        /// </summary>
        /// <returns>Number</returns>
        public string ShowNumber()
        {
            if (!SwitchNumber)
            {
                return Number;
            }
            else
            {
                return SecondNumber;
            }
        }

        /// <summary>
        /// Used to set mathematic symbol
        /// </summary>
        /// <param name="method">Mathematic symbol</param>
        public void SetMathMethod(string method)
        {
            MathMethod = method;
            SwitchNumber = true;
        }

        /// <summary>
        /// Used to compile numbers
        /// </summary>
        /// <returns>Sum of both numbers</returns>
        public string MakeCountNumbers()
        {
            string result = string.Empty;
            
            switch (MathMethod)
            {
                case "+":
                    result = (double.Parse(Number) + double.Parse(SecondNumber)).ToString();
                    Number = result;
                    SecondNumber = string.Empty;
                    break;
                case "-":
                    result = (double.Parse(Number) - double.Parse(SecondNumber)).ToString();
                    Number = result;
                    SecondNumber = string.Empty;
                    break;
                case "/":
                    result = (double.Parse(Number) / double.Parse(SecondNumber)).ToString();
                    Number = result;
                    SecondNumber = string.Empty;
                    break;
                case "*":
                    result = (double.Parse(Number) * double.Parse(SecondNumber)).ToString();
                    Number = result;
                    SecondNumber = string.Empty;
                    break;
                case "%":
                    result = (double.Parse(Number) * (double.Parse(SecondNumber) / 100)).ToString();
                    break;
            }
            return result;
        }

        /// <summary>
        /// Removing the last element from numbers
        /// </summary>
        public void RemoveLastElement()
        {
            if (!SwitchNumber)
            {
                if (Number.Length > 0)
                {
                    Number = Number.Remove(Number.Length - 1, 1);
                }
            }
            else
            {
                if (SecondNumber.Length > 0)
                {
                    SecondNumber = SecondNumber.Remove(Number.Length - 1, 1);
                }
            }
        }

        /// <summary>
        /// Change number polarity
        /// </summary>
        public void ChangePolarity()
        {
            char[] reversed;
            if (!SwitchNumber)
            {
                if (Number.Contains('-'))
                {
                    Number = Number.Remove(0, 1);
                }
                else
                {
                    Number += '-';
                    reversed = Number.ToCharArray();
                    Array.Reverse(reversed);
                    Number = new string(reversed);
                }
            }
            else
            {
                if (SecondNumber.Contains('-'))
                {
                    SecondNumber = SecondNumber.Remove(0, 1);
                }
                else
                {
                    SecondNumber += '-';
                    reversed = SecondNumber.ToCharArray();
                    Array.Reverse(reversed);
                    SecondNumber = new string(reversed);
                }
            }
        }

        /// <summary>
        /// Clear application
        /// </summary>
        public void MakeDefaultValues()
        {
            Number = string.Empty;
            SecondNumber = string.Empty;
            SwitchNumber = false;
            WasSetComma = false;
        }
    }
}
