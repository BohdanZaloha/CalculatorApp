using CalculatorApp.Interfaces;
using CalculatorApp.Operations;

namespace CalculatorApp
{
    public static class OperationFactory
    {
        private static readonly IOperation _add = new AddOperation();
        private static readonly IOperation _subtract = new SubtractOperation();
        private static readonly IOperation _multiply = new MultiplyOperation();
        private static readonly IOperation _divide = new DivideOperation();

        public static IOperation Create(OperationType type)
        {
            switch (type)
            {
                case OperationType.Add:
                    return _add;
                case OperationType.Subtract:
                    return _subtract;
                case OperationType.Multiply:
                    return _multiply;
                case OperationType.Divide:
                    return _divide;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), "Unknown Operation type");
            }
        }
    }
}
