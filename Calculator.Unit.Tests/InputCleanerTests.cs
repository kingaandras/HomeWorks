using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Unit.Tests
{
    [TestClass]
    public class InputCleanerTests
    {
        [TestMethod]
        public void ValidFirstNumberTextShouldReturnCorrectFirstNumberDouble()
        {
            //Arrange
            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "1234.567",
                secondNumberText = "1234.567",
                operationText = "+"
            };

            //Act
            var result = new InputHandler(calculatorItems).CleanCalculatorItems();

            //Assert
            Assert.IsTrue(Math.Abs(result.firstNumber - 1234.567) < double.Epsilon);
        }

        [TestMethod]
        public void ValidSecondNumberTextShouldReturnCorrectSecondNumberDouble()
        {
            //Arrange
            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "1234.567",
                secondNumberText = "1234.567",
                operationText = "+"
            };

            //Act
            var result = new InputHandler(calculatorItems).CleanCalculatorItems();

            //Assert
            Assert.IsTrue(Math.Abs(result.secondNumber - 1234.567) < double.Epsilon);
        }

        [TestMethod]
        public void ValidOperationTextShouldReturnCorrectOperationChar()
        {
            //Arrange
            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "1234.567",
                secondNumberText = "1234.567",
                operationText = "+"
            };

            //Act
            var result = new InputHandler(calculatorItems).CleanCalculatorItems();

            //Assert
            Assert.IsTrue(result.operation.Equals('+'));
        }

        [TestMethod]
        public void InvalidFirstNumberShouldReturnException()
        {
            //Arrange
            CalculatorItems result;

            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "xxx",
                secondNumberText = "1234.567",
                operationText = "+"
            };

            //Act
            try
            {
                result = new InputHandler(calculatorItems).CleanCalculatorItems();
            }
            catch (Exception exception)
            {
                //Assert
                Assert.IsTrue(exception.Message.Contains("hibás szám"));
            } 
        }

        [TestMethod]
        public void InvalidSecondNumberShouldReturnException()
        {
            //Arrange
            CalculatorItems result;

            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "1234.567",
                secondNumberText = "xxx",
                operationText = "+"
            };

            //Act
            try
            {
                result = new InputHandler(calculatorItems).CleanCalculatorItems();
            }
            catch (Exception exception)
            {
                //Assert
                Assert.IsTrue(exception.Message.Contains("hibás szám"));
            }
        }

        [TestMethod]
        public void InvalidOperationShouldReturnException()
        {
            //Arrange
            CalculatorItems result;

            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "1234.567",
                secondNumberText = "1234.567",
                operationText = "x"
            };

            //Act
            try
            {
                result = new InputHandler(calculatorItems).CleanCalculatorItems();
            }
            catch (Exception exception)
            {
                //Assert
                Assert.IsTrue(exception.Message.Contains("hibás operátor"));
            }
        }

        [TestMethod]
        public void TooLongOperationShouldReturnException()
        {
            //Arrange
            CalculatorItems result;

            var calculatorItems = new CalculatorItems
            {
                firstNumberText = "1234.567",
                secondNumberText = "1234.567",
                operationText = "xxx"
            };

            //Act
            try
            {
                result = new InputHandler(calculatorItems).CleanCalculatorItems();
            }
            catch (Exception exception)
            {
                //Assert
                Assert.IsTrue(exception.Message.Contains("hibás operátor"));
            }
        }

    }
}
