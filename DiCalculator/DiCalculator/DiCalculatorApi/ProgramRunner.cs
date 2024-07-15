using DiCalculatorDomain.Calculator;
using DiCalculatorDomain.ConsoleReader;
using DiCalculatorDomain.Enums;

namespace DiCalculatorApi;

public class ProgramRunner
{
    private readonly ICalculator _calculator;
    private readonly IConsoleReader _consoleReader;
    
    public ProgramRunner(ICalculator calculator, IConsoleReader consoleReader)
    {
        _calculator = calculator;
        _consoleReader = consoleReader;
    }
    
    public void Run()
    {
        do
        {
            var calculation = _consoleReader.ReadCalculation();
            int? result = null;

            switch (calculation.Operation)
            {
                case null:
                    break;
                case Operation.Add:
                    result =_calculator.Add(calculation.FirstNumber, calculation.SecondNumber);
                    break;
                case Operation.Subtract:
                    result =_calculator.Subtract(calculation.FirstNumber, calculation.SecondNumber);
                    break;
                case Operation.Multiply:
                    result =_calculator.Multiply(calculation.FirstNumber, calculation.SecondNumber);
                    break;
                case Operation.Divide:
                    result =_calculator.Divide(calculation.FirstNumber, calculation.SecondNumber);
                    break;
            }

            if (result is not null) Console.WriteLine($"Result: {result}");
        }
        while (true);
    }
    
    
}