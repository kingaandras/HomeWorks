using System;

//másik hf: Teszkós automata: megadsz egy összeget, dobja ki a program, consolról, hogy mennyit ad vissza
//pl.: 10-esből visszaadott 3 darabot.
//+ kerekítünk magyarországon ezt is vegyük bele 

//+ feladat: copy másik projektbe: lehető legkevesebb pénzérmét adja vissza

namespace TescoAutomata
{
    public class Program
    {

        static void Main()
        {
            var helper = new Helper();

            while (true)
            {
                try
                {
                    Console.Clear();

                    var sum = helper.ReadSum();

                    var sumLong = (long)(Math.Round(sum / 5, MidpointRounding.ToEven) * 5);

                    Console.WriteLine($"kerekítve: {sumLong}");
                   
                    helper.ReturnMoney(sumLong);

                    helper.WriteReturnedMoney();
                    Console.ReadKey();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.ReadKey();
                }
            }
        }

    }
}
