using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TchapsTech.Unitests.Calculator.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void When_Add_Return_ValidResult()
        {
            // Arrange 
            int x = 1;
            int y = 2;
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(x, y);

            // Assert
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(1, 4, -3)]
        [InlineData(10, 5, 5)]
        [InlineData(14, 4, 10)]
        public void When_Substract_Return_ValidResult(int x, int y, int expectedResult) 
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Substract(x, y);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void When_Divide_Return_ValidObject_Result()
        {
            // Arrange
            var calculator = new Calculator();
            var a = 5;
            var b = 10;

            // Act
            var result = calculator.Divide(a, b);

            // Assert
            Assert.Equal("0.5", result.Result);
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public void When_Divide_Return_DivideByZero()
        {
            // Arrange
            var calculator = new Calculator();
            var a = 5;
            var b = 0;

            // Act
            var result = calculator.Divide(a, b);

            // Assert
            Assert.Null(result.Result);
            Assert.False(result.IsSuccess);
            Assert.Equal("DivideByZero", result.Error);
        }

        [Fact]
        public void When_DivideByZero_ThrowException()
        {
            // Arrange
            var a = 5;
            var b = 0;
            var calculator = new Calculator();

            // Act
            Assert.Throws<DivideByZeroException>(() => calculator.DivideWithException(a, b)); 
        }

        [Fact]
        public void When_DivideByZero_Should_Return_ValidResult()
        {
            // Arrange
            var a = 10;
            var b = 2;
            var calculator = new Calculator();

            // Act
            var result = calculator.DivideWithException(a, b);

            // Assert
            Assert.Equal(5, result);
        }
    }
}
