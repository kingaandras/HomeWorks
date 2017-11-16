using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main()
        {
            var calculatorItems = new CalculatorItems();
            try
            {
                Console.Write("Kérem az első számot: ");
                calculatorItems.firstNumberText = Console.ReadLine();

                Console.Write("Kérem a 2. számot: ");
                calculatorItems.secondNumberText = Console.ReadLine();

                Console.Write("Kérem az operátort: ");
                calculatorItems.operationText = Console.ReadLine();

                Console.WriteLine();

                var returnedCalculatorItems = new CalculatorExecutor(calculatorItems).Run();

                Console.Write($"Eredmény: {returnedCalculatorItems.result}");
            }
            catch (Exception exception)
            {                 
                Console.Write(exception.Message);   
            }
            Console.ReadKey();
        }
    }
}
