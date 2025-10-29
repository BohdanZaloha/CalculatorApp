namespace CalculatorApp
{
    internal class CalculatorService
    {
        public static bool TryExecute(OperationType operationType, decimal firstOperand, decimal secondOperand, out decimal result, out string? error)
        {
            error = null;
            result = 0;

            var operation = OperationFactory.Create(operationType);

            try
            {
                result = operation.Execute(firstOperand, secondOperand);
                return true;
            }
            catch (DivideByZeroException)
            {
                error = "cannot divide using zero";
                return false;
            }
            catch (Exception ex)
            {
                error = $"error - {ex.Message}";
                return false;
            }
        }
    }
}
