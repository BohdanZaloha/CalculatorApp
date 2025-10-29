using CalculatorApp.Interfaces;
namespace CalculatorApp.Operations
{
    internal class SubtractOperation : IOperation
    {
        public decimal Execute(decimal firstOperand, decimal secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
