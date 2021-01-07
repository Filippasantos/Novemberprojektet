using System;
using Raylib_cs;
using System.Threading;
using System.Collections.Generic;

namespace NovProj
{
    class Program
    {
        static void Main(string[] args)
        {   
            Women Anastasia = new Women();
            Women Galina = new Women();
            Women Yelena = new Women();
            Women Manya = new Women();
            Women Nadia = new Women();
            Women Vera = new Women();

            List<Women> theWomen = new List<Women>();
            theWomen.Add(Vera);
            theWomen.Add(Anastasia);
            theWomen.Add(Galina);
            theWomen.Add(Yelena);
            theWomen.Add(Manya);
            theWomen.Add(Nadia);

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
                    int howManyLeft = theWomen.GetRange();//hur kan ja se hur många som är kvar
                    System.Console.WriteLine("There are " + );

                    System.Console.WriteLine("This woman costs " + woman01.originalPrice + ".");
                    Console.ReadLine();
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