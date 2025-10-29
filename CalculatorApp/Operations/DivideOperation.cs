using CalculatorApp.Interfaces;
namespace CalculatorApp.Operations
{
    internal class DivideOperation : IOperation
    {
        public decimal Execute(decimal firstOperand, decimal secondOperand)
        {
            if (secondOperand != 0)
            {
                return firstOperand / secondOperand;
            }
            throw new DivideByZeroException();
        }
    }
}
