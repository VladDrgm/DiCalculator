// Project 1: Simple Calculator
//
// Objective:
//
//  Implement a basic calculator using dependency injection to isolate calculator operations from the main application logic.
//
//     Interfaces:
//         ICalculator with methods for addition, subtraction, multiplication, and division.
//     Classes:
//         Calculator implementing ICalculator.
//         Program class for user input and output, using dependency injection to obtain a ICalculator instance.
//
// Focus: Basic dependency injection setup, constructor injection.

using DiCalculatorApi;
using DiCalculatorDomain.Calculator;
using DiCalculatorDomain.ConsoleReader;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.AddSingleton<ICalculator, Calculator>();
        services.AddSingleton<IConsoleReader, ConsoleReader>();
    })
    .Build();

var program = new ProgramRunner(host.Services.GetRequiredService<ICalculator>(), host.Services.GetRequiredService<IConsoleReader>());

program.Run();