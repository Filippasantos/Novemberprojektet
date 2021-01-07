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
            int coins = 100;
            Random generator = new Random();
            int index;
            int howManyLeft;
            string answer;

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
            System.Console.WriteLine("You choose by typing either 'yes' or 'no'.");
            Console.ReadLine();
            Console.Clear();

            string game = "buy";

            while(game != "end")
            {
                while (game == "buy")
                {
                    System.Console.WriteLine("Would you like to buy a woman?");
                    answer = Console.ReadLine();
                    answer.ToLower();
                    
                    if (answer == "yes") //yes
                    {
                        index = generator.Next(theWomen.Count);

                        System.Console.WriteLine("A random woman was chosen for you, her name is " + /*lös detta*/ + ".");
                        System.Console.WriteLine("This woman costs " + theWomen[index].originalPrice + ".");
                        System.Console.WriteLine("You have " + coins + " coins.");

                        if (coins < theWomen[index].originalPrice)
                        {
                            System.Console.WriteLine("You don't have enough money.");
                            Console.ReadLine();

                        }
                        else
                        {
                            System.Console.WriteLine("Do you want to buy this woman?");
                            answer = Console.ReadLine();
                            answer.ToLower();

                            if (answer == "yes")
                            {
                                
                            }
                            else if (answer == "no")
                            {
                                Choice(game);
                                Console.Clear();
                            }
                            else
                            {
                                System.Console.WriteLine("Type either 'yes' or 'no'.");
                                answer = Console.ReadLine();
                                answer.ToLower();
                            }

                        }
                    }
                    else if(answer == "no") //no
                    {
                        Choice(game);
                        Console.Clear();
                    }
                    else
                    {
                        System.Console.WriteLine("Type either 'yes' or 'no'");
                        answer = Console.ReadLine();
                        answer.ToLower();
                    }
                    
                    System.Console.WriteLine("This woman costs " + ".");
                    howManyLeft = theWomen.Count;
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

        static string Choice (string whatToDo)
        {
            System.Console.WriteLine("What would you like to do?");
            System.Console.WriteLine("* 'buy' - buy new women.");
            System.Console.WriteLine("* 'work' - earn money by making your women work for you.");
            System.Console.WriteLine("* 'sell' - sell one of your women.");
            System.Console.WriteLine("* 'rescue' - attempt to rescue a woman.");
            System.Console.WriteLine("OBS! 'sell' and 'rescue' won't work due to a lazy programmer.");

            whatToDo = Console.ReadLine();
            whatToDo.ToLower();
                if (whatToDo != "buy" /*&& WhatToDo != "sell" && whatToDo != "rescue"*/ && whatToDo!= "work")
                {
                    System.Console.WriteLine("You can't do that. Try again:");
                    whatToDo = Console.ReadLine();
                    whatToDo.ToLower();
                }
            
            return whatToDo;
                        
        }

    }
}

//Idéas- return?, able to make your brothel more famous and classy?, get "better" girls with a classier brothel.
//finish "sell" and "rescue".
//you should be able to choose a woman depending on what trait you want to focus on for your brothel, ex. age or race.