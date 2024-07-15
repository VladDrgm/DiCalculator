using DiCalculatorDomain.Enums;

namespace DiCalculatorDomain.ConsoleReader;

public interface IConsoleReader
{
    DiCalculation.DiCalculation ReadCalculation();
}