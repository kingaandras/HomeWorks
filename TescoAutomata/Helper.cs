using System;
using System.Collections.Generic;

namespace TescoAutomata
{
    public class Helper
    {
        private readonly List<int> MoneyList = new List<int> {20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5};
        private int[] ResultList = new int[20001];
        

        public double ReadSum()
        {
            Console.Write("Mennyit: ");
            var readSum = Console.ReadLine();

            var readValue = 0.0;

            if ((readSum == null) || (readSum == string.Empty) || (readSum == "0"))
            {
                Console.WriteLine("Üres vagy 0 lett. Kilépek");
                Console.ReadKey();

                return readValue;
            }

            if (readSum.Contains(","))
            {
                readSum = readSum.Replace(",", ".");
            }

            try
            {
                readValue = double.Parse(readSum);

                if (readValue < 0) readValue *= -1;
            }
            catch (Exception)
            {
                Console.Write("Nem helyes szám!");
                Console.ReadKey();
            }

            return readValue;
        }

        //tries to give as many from the money type as possible
        //returns the remaining sum
        private long GiveMoney(long tot, int money)
        {
            var currentTotal = tot;

            // Console.WriteLine($"jelenlegi összeg: {currentTotal}, pénznem: {money}");
            ResultList[money] = 0;

            while (currentTotal >= money)
            {
                currentTotal = currentTotal - money;
                ResultList[money]++;
            }

            return currentTotal;
        }

        //gets a long number without rounding to 5 or 0
        //iterates through MoneyList
        //calculates the number of papers and coins to return
        public void ReturnMoney(long total)
        {
            var remaining = total;
            var i = 0;

            while ((remaining >= 5) && (i < MoneyList.Count))
            {
                //try all the money types

                remaining = GiveMoney(remaining, MoneyList[i]);
                i++;
            }
        }

        public void WriteReturnedMoney()
        {
            for (var i = 20000; i > 0; i--)
            {
                if (ResultList[i] > 0) Console.WriteLine($"{i} x {ResultList[i]}");
            }
        }
    }
}