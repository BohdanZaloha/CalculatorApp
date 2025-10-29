using CalculatorApp.Interfaces;

namespace CalculatorApp.Operations
{
    internal class AddOperation : IOperation
    {
        public decimal Execute(decimal firstOperand, decimal secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
