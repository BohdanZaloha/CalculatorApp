namespace CalculatorApp.HelperMethods
{
    public static class Helper
    {
        public static decimal ReadDecimal()
        {
            while (true)
            {
                if (decimal.TryParse(Console.ReadLine(), out decimal value))
                {
                    return value;
                }

                Console.WriteLine("This is not a valid number! Try entering a number");
            }

        }
    }
}
