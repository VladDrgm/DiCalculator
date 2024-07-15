using DiCalculatorDomain.Calculator;
using FluentAssertions;

namespace UnitTests;

public class CalculatorTests
{
    [Fact] 
    public void Calculator_Add_OK()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 4;
        var b = 5;
        // Act
        var result = calculator.Add(a, b);
        // Assert
        result.Should().Be(9);
    }
    
    [Fact] 
    public void Calculator_Subtract_OK()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 9;
        var b = 4;
        // Act
        var result = calculator.Subtract(a, b);
        // Assert
        result.Should().Be(5);
    }
    
    [Fact] 
    public void Calculator_Multiply_OK()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 4;
        var b = 5;
        // Act
        var result = calculator.Multiply(a, b);
        // Assert
        result.Should().Be(20);
    }
    
    [Fact] 
    public void Calculator_Divide_OK()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 20;
        var b = 4;
        // Act
        var result = calculator.Divide(a, b);
        // Assert
        result.Should().Be(5);
    }
}