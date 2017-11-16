using System;

namespace Calculator
{
    public class CalculateAction
    {
        private CalculatorItems calculatorItems;

        public CalculateAction(CalculatorItems receivedCalculatorItems)
        {
            calculatorItems = receivedCalculatorItems;
        }

        /// <summary>
        /// Does the actual calculation. 
        /// </summary>
        /// <returns>the calculated number in the calculatorItems.result field or exception</returns>
        public CalculatorItems Execute()
        {
            switch (calculatorItems.operation)
            {
                case '+':
                    calculatorItems.result = calculatorItems.firstNumber + calculatorItems.secondNumber;
                    break;
                case '-':
                    calculatorItems.result = calculatorItems.firstNumber - calculatorItems.secondNumber;
                    break;
                case '*':
                    calculatorItems.result = calculatorItems.firstNumber * calculatorItems.secondNumber;
                    break;
                case '/':
                    calculatorItems.result = calculatorItems.firstNumber/calculatorItems.secondNumber;
                    break;
                case '^':
                    calculatorItems.result = Math.Pow(calculatorItems.firstNumber, calculatorItems.secondNumber);
                    break;
            }
            return calculatorItems;
        }
    }
}
