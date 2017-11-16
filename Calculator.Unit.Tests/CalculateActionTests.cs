using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Unit.Tests
{
    [TestClass]
    public class CalculateActionTests
    {
        [TestMethod]
        public void AddingTwoNumbersShouldReturnCorrectNumber()
        {
            //Arrange
            var calculatorItems = new CalculatorItems
            {
                firstNumber = 1234.567,
                secondNumber = 1,
                operation = '+'
            };

            var expectedResult = calculatorItems.firstNumber + calculatorItems.secondNumber;

            //Act
            try
            {
                var result = new CalculateAction(calculatorItems).Execute();

                //Assert
                Assert.IsTrue(Math.Abs(result.result - expectedResult) <= double.Epsilon);
            }
            catch (Exception exception)
            {
               throw new Exception(exception.Message);
            }
        }

        [TestMethod]
        public void SubstractingTwoNumbersShouldReturnCorrectNumber()
        {
            //Arrange
            var calculatorItems = new CalculatorItems
            {
                firstNumber = 1234.567,
                secondNumber = 1,
                operation = '-'
            };

            var expectedResult = calculatorItems.firstNumber - calculatorItems.secondNumber;

            //Act
            try
            {
                var result = new CalculateAction(calculatorItems).Execute();

                //Assert
                Assert.IsTrue(Math.Abs(result.result - expectedResult) <= double.Epsilon);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        
        [TestMethod]
        public void MultiplyingTwoNumbersShouldReturnCorrectNumber()
        {
            //Arrange
            var calculatorItems = new CalculatorItems
            {
                firstNumber = 1234.567,
                secondNumber = 1.2,
                operation = '*'
            };

            var expectedResult = calculatorItems.firstNumber * calculatorItems.secondNumber;

            //Act
            try
            {
                var result = new CalculateAction(calculatorItems).Execute();

                //Assert
                Assert.IsTrue(Math.Abs(result.result - expectedResult) <= double.Epsilon);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [TestMethod]
        public void DividingingTwoNumbersShouldReturnCorrectNumber()
        {
            //Arrange
            var calculatorItems = new CalculatorItems
            {
                firstNumber = 1234.567,
                secondNumber = 1.2,
                operation = '/'
            };

            var expectedResult = calculatorItems.firstNumber / calculatorItems.secondNumber;

            //Act
            try
            {
                var result = new CalculateAction(calculatorItems).Execute();

                //Assert
                Assert.IsTrue(Math.Abs(result.result - expectedResult) <= double.Epsilon);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [TestMethod]
        public void PoweringTwoNumbersShouldReturnCorrectNumber()
        {
            //Arrange
            var calculatorItems = new CalculatorItems
            {
                firstNumber = 1234.567,
                secondNumber = 2,
                operation = '^'
            };

            var expectedResult = Math.Pow(calculatorItems.firstNumber, calculatorItems.secondNumber);

            //Act
            try
            {
                var result = new CalculateAction(calculatorItems).Execute();

                //Assert
                Assert.IsTrue(Math.Abs(result.result - expectedResult) <= double.Epsilon);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        [TestMethod]
        public void DivindingByZeroShouldReturnInfinity()
        {
            //Arrange
            var calculatorItems = new CalculatorItems
            {
                firstNumber = 1234.567,
                secondNumber = 0,
                operation = '/'
            };

            //Act
            try
            {
                var expectedResult = new CalculateAction(calculatorItems).Execute();
                //Assert
                Assert.IsTrue(double.IsInfinity(expectedResult.result));
            }
            catch (Exception exception)
            {
                throw  new Exception(exception.Message);
            }
        }
    }
}
