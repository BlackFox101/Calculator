using CalculatorLib;
using System;
using Xunit;

namespace CalculatorLibTests
{
    public class SimpleCalculatorTests
    {
        [Fact]
        public void Calculate_2Multi5_Return10()
        {
            // Arrange
            ICalculator calculator = new SimpleCalculator( new MultiOperation() );

            // Act
            int result = calculator.Calculate( "2 * 5" );

            // Assert
            Assert.Equal(10, result);
        }
    }
}
