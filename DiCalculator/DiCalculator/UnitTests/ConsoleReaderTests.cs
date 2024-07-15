using DiCalculatorDomain.ConsoleReader;
using DiCalculatorDomain.Enums;
using FluentAssertions;
using Moq;

namespace UnitTests;

public class ConsoleReaderTests
{
    [Theory]
    [InlineData(Operation.Add)]
    [InlineData(Operation.Subtract)]
    [InlineData(Operation.Multiply)]
    [InlineData(Operation.Divide)]
    public void ConsoleReader_ReadOperation_Ok(Operation operation)
    {
        // Arrange
        var mockReader = new Mock<TextReader>();
        mockReader.SetupSequence(r => r.ReadLine())
            .Returns(((int)operation).ToString()) // Operation
            .Returns("1") // First number
            .Returns("1"); // Second number

        var consoleReader = new ConsoleReader(mockReader.Object);

        // Act
        var result = consoleReader.ReadCalculation();

        // Assert
        result.Operation.Should().Be(operation);
        result.FirstNumber.Should().Be(1);
        result.SecondNumber.Should().Be(1);
    }
}