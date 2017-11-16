using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Integration.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddingTwoNumbersShouldReturnCorrectResult()
        {

            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "33333.3333",
                secondNumberText = "77777.7777",
                operationText = "+"
            };

            var expectedResult = Convert.ToDouble(calculatorItems.firstNumberText) +
                                 Convert.ToDouble(calculatorItems.secondNumberText);

            try
            {
                var returnedCalculatorItems = new CalculatorExecutor(calculatorItems).Run();
                Assert.IsTrue(Math.Abs(returnedCalculatorItems.result - expectedResult) <= double.Epsilon);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [TestMethod]
        public void SubstractingTwoNumbersShouldReturnCorrectResult()
        {
            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "77777.7777",
                secondNumberText = "33333.3333",
                operationText = "-"
            };

            var expectedResult = Convert.ToDouble(calculatorItems.firstNumberText) -
                                 Convert.ToDouble(calculatorItems.secondNumberText);

            try
            {
                var returnedCalculatorItems = new CalculatorExecutor(calculatorItems).Run();
                Assert.IsTrue(Math.Abs(returnedCalculatorItems.result - expectedResult) <= double.Epsilon);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [TestMethod]
        public void DividingTwoNumbersShouldReturnCorrectResult()
        {
            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "77777.7777",
                secondNumberText = "33333.3333",
                operationText = "/"
            };

            var expectedResult = Convert.ToDouble(calculatorItems.firstNumberText)/
                                 Convert.ToDouble(calculatorItems.secondNumberText);

            try
            {
                var returnedCalculatorItems = new CalculatorExecutor(calculatorItems).Run();
                Assert.IsTrue(Math.Abs(returnedCalculatorItems.result - expectedResult) <= double.Epsilon);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [TestMethod]
        public void MultiplyingTwoNumbersShouldReturnCorrectResult()
        {
            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "2.22222",
                secondNumberText = "33333.3333",
                operationText = "*"
            };

            var expectedResult = Convert.ToDouble(calculatorItems.firstNumberText)*
                                 Convert.ToDouble(calculatorItems.secondNumberText);

            try
            {
                var returnedCalculatorItems = new CalculatorExecutor(calculatorItems).Run();
                Assert.IsTrue(Math.Abs(returnedCalculatorItems.result - expectedResult) <= double.Epsilon);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [TestMethod]
        public void PoweringTwoNumbersShouldReturnCorrectResult()
        {
            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "2.22222",
                secondNumberText = "3.0",
                operationText = "^"
            };

            var expectedResult = Math.Pow(Convert.ToDouble(calculatorItems.firstNumberText),
                Convert.ToDouble(calculatorItems.secondNumberText));

            try
            {
                var returnedCalculatorItems = new CalculatorExecutor(calculatorItems).Run();
                Assert.IsTrue(Math.Abs(returnedCalculatorItems.result - expectedResult) <= double.Epsilon);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [TestMethod]
        public void DividingByZeroShouldBeHandledByCode()
        {
            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "1",
                secondNumberText = "0",
                operationText = "/"
            };

            try
            {
                var returnedCalculatorItems = new CalculatorExecutor(calculatorItems).Run();
            }
            catch (Exception exception)
            {
                Assert.IsTrue(exception.Message.Contains("0-val"));
            }
        }
    }
}
 