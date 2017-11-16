using System;

namespace Calculator
{
    public class CalculatorExecutor
    {
        private CalculatorItems calculatorItems;

        public CalculatorExecutor(CalculatorItems receivedCalculatorItems)
        {
            this.calculatorItems = receivedCalculatorItems;
        }

        /// <summary>
        /// Calls the InputHander cleaning.
        /// Calls the CalculateAction execute method.
        /// The result is returned in the CalculatorItems.result field.
        /// </summary>
        public CalculatorItems Run()
        {
            try
            {
                var inputHandler = new InputHandler(calculatorItems);
                this.calculatorItems = new CalculateAction(inputHandler.CleanCalculatorItems()).Execute();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
            return this.calculatorItems;
        }
    }
}
