namespace Sports
{
    using System;
    using System.Collections.Generic;
    public class SportPlayerHandler
    {
        private static void Main()
        {
            var sportPlayerList = new List<SportPlayer>(4);

            sportPlayerList.Add(new SportPlayer("First"));
            sportPlayerList.Add(new SportPlayer("Second"));
            sportPlayerList.Add(new SportPlayer("Third"));
            sportPlayerList.Add(new SportPlayer("Fourth"));

            sportPlayerList[0].AddNewResult(10);
            sportPlayerList[0].AddNewResult(8);
           
            sportPlayerList[1].AddNewResult(5);
            sportPlayerList[1].AddNewResult(6);

            sportPlayerList[2].AddNewResult(4);
            sportPlayerList[2].AddNewResult(9);

            sportPlayerList[3].AddNewResult(1);
            sportPlayerList[3].AddNewResult(3);


            foreach (var player in sportPlayerList)
            {
                Console.WriteLine(player.PrintData());
            }
           
            Console.WriteLine("WR: " + SportPlayer.wR);

            Console.ReadLine();
        }
    }
}