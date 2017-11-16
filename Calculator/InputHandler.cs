using System;
using System.Linq;

namespace Calculator
{
    public class InputHandler
    {
        private CalculatorItems calculatorItems;

        /// <summary>
        /// Validates the inputs and converts them to double and char
        /// </summary>
        /// <param name="receivedCalculatorItems"></param>
        public InputHandler(CalculatorItems receivedCalculatorItems)
        {
            calculatorItems = receivedCalculatorItems;
        }

        /// <summary>
        /// Returns a cleaned CalculatorItems object
        /// </summary>
        /// <returns>the calculatorItems object</returns>
        public CalculatorItems CleanCalculatorItems()
        {
            try
            {
                calculatorItems.firstNumber = ConvertToNmber(calculatorItems.firstNumberText);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            try
            {
                calculatorItems.secondNumber = ConvertToNmber(calculatorItems.secondNumberText);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            try
            {
                calculatorItems.operation = ConvertToOperator(calculatorItems.operationText);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            if ((calculatorItems.operation == '/') && (Math.Abs(calculatorItems.secondNumber) <= double.Epsilon))
                throw new Exception("0-val való osztás miatt hibás az input");

            return this.calculatorItems;
        }

        /// <summary>
        /// Converts the string inputs to double
        /// </summary>
        /// <param name="input">the number as string</param>
        /// <returns>the double value or exception</returns>
        private double ConvertToNmber(string input)
        {
            double doubleValue;
            try
            {
                doubleValue = Convert.ToDouble(input);

            }
            catch (Exception)
            {

                throw new Exception($"hibás szám: {input}");
            }
            return doubleValue;
        }

        /// <summary>
        /// Converts the string input to operator character
        /// </summary>
        /// <param name="op">the operator as string</param>
        /// <returns>operator as character or exception</returns>
        private char ConvertToOperator(string op)
        {
            var allowedOperators = "+-/*^";

            if (op.Length > 1)
                throw new Exception($"hibás operátor {op}");

            if (allowedOperators.Any(t => t == op[0]))
            {
                return op[0];
            }

            throw new Exception($"hibás operátor {op}");
        }
    }
}
