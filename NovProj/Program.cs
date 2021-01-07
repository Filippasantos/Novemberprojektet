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
            int money = 100;

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

            List<Women> yourWomen = new List<Women>();

            Console.WriteLine("You work in a brothel in Russia, year 1982. Your job is to buy and sell women.");
            Console.ReadLine();
            System.Console.WriteLine("You will start by buying your first woman, you start with 100 coins.");
            Console.ReadLine();
            System.Console.WriteLine("You play by clicking either 'y' (yes) or 'n' (no).");
            Console.ReadLine();
            Console.Clear();

            string game = "buy";

            while(game != "end")
            {
                while (game == "buy")
                {
                    System.Console.WriteLine("Would you like to buy a woman?");
                    
                    if (Console.ReadKey().Key == ConsoleKey.Y) //yes
                    {
                        System.Console.WriteLine("Do you want to ");
                    }
                    else if(Console.ReadKey().Key == ConsoleKey.N) //no
                    {
                        System.Console.WriteLine("What would you like to do?");
                        System.Console.WriteLine("* 'buy' - buy new women.");
                        System.Console.WriteLine("* 'work' - earn money by making your women work for you.");
                        System.Console.WriteLine("* 'sell' - sell one of your women.");
                        System.Console.WriteLine("* 'rescue' - attempt to rescue a woman.");
                        game = Console.ReadLine();
                        game.ToLower();
                        if (game != "buy" && game != "sell" && game != "rescue" && game!= "work")
                        {
                            System.Console.WriteLine("You can't do that. Try again:");
                            game = Console.ReadLine();
                            game.ToLower();
                        }
                        Console.Clear();
                    }
                    
                    System.Console.WriteLine("This woman costs " + ".");
                    int howManyLeft = theWomen.Count;
                    System.Console.WriteLine("There are '" + howManyLeft + "' women left that you can buy.");
                    Console.ReadLine();
                }
                while (game == "work")
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

//Idéas- return?, able to make your brothel more famous and classy?, get "better" girls with a classier brothel.
//finish "sell" and "rescue".