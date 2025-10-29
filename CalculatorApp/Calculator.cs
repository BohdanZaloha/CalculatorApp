using CalculatorApp.HelperMethods;

namespace CalculatorApp
{
    internal class Calculator
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Calculator started");
                bool continueWorking = true;
                while (continueWorking)
                {
                    Console.WriteLine("Write the first number");
                    decimal firstOperand = Helper.ReadDecimal();

                    Console.WriteLine("write the second number");
                    decimal secondOperand = Helper.ReadDecimal();

                    Console.WriteLine("Select your operation");
                    Console.WriteLine($" 1 - {nameof(OperationType.Add)} \n 2 - {nameof(OperationType.Subtract)} \n 3 - {nameof(OperationType.Multiply)} \n 4 - {nameof(OperationType.Divide)}");

                    if (!int.TryParse(Console.ReadLine(), out int command))
                    {
                        Console.WriteLine("Only numbers are allowed!");
                        return;
                    }
                    var operation = (OperationType)command;

                    if (CalculatorService.TryExecute(operation, firstOperand, secondOperand, out var result, out var error))
                    {
                        Console.WriteLine($"the result is {Math.Round(result, 17)}");
                    }
                    else
                    {
                        Console.WriteLine(error);
                    }

                    Console.WriteLine("write exit to stop using calculation");
                    if (Console.ReadLine()?.Trim() == "exit")
                        continueWorking = false;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"such operation does not exist \n{ex.Message}");
            }
            catch
            {
                Console.WriteLine("Unexpected error");
            }
        }
    }
}
