using System;
using Raylib_cs;
using System.Threading;

namespace NovProj
{
    class Program
    {
        static void Main(string[] args)
        {   

            Console.WriteLine("You work in a brothel in Russia, year 1982. Your job is to buy and sell women.");
            Console.ReadLine();
            System.Console.WriteLine("You will start by buying your first woman.");
            Thread.Sleep(3500);
            System.Console.WriteLine("Good luck.");
            Console.ReadLine();
            Console.Clear();

            string game = "buy";

            while(game != "end")
            {
                while (game == "buy")
                {
                    
                }
                while (game == "sell")
                {
                    
                }
                while (game == "rescue")
                {
                    
                }
            }
            
        }
    }
}

//Idéer- return?, göra oddsen att få "sämre" tjejer mindre ju kändare ens bordell är, kunna bli känd.