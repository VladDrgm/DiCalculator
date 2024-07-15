using DiCalculatorDomain.Enums;

namespace DiCalculatorDomain.ConsoleReader;

public class ConsoleReader : IConsoleReader
{
    private readonly TextReader _reader;

    public ConsoleReader(TextReader reader)
    {
        _reader = reader;
    }
    
    public ConsoleReader() : this(Console.In) {}
    
    
    
    public DiCalculation.DiCalculation ReadCalculation()
    {
        var operation = ReadOperation();
        var firstNumber = ReadNumber();
        var secondNumber = ReadNumber();
        
        return new DiCalculation.DiCalculation(operation, firstNumber, secondNumber);
    }
    
    private Operation? ReadOperation()
    {
        Console.WriteLine("Welcome to the Calculator!");
        Console.WriteLine("Select an operation to perform:");
        Console.WriteLine("Press 1 to Add");
        Console.WriteLine("Press 2 to Subtract");
        Console.WriteLine("Press 3 to Multiply");
        Console.WriteLine("Press 4 to Divide");
        var input = _reader.ReadLine();
        if (int.TryParse(input, out var operation))
        {
            if (operation < 1 || operation > 4)
            {
                Console.WriteLine("Invalid operation. Please enter a number between 1 and 4.");
            }
            else
            {
                return (Operation)operation;
            }
        }
        
        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
        return null;
    }
    
    private int ReadNumber()
    {
        Console.WriteLine("Enter the number:");
        var input = _reader.ReadLine();
        if (int.TryParse(input, out var number))
        {
            return number;
        }
        
        Console.WriteLine("Invalid input. Please enter a number.");
        return 0;
    }
}
