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

            Vera.name = "Vera";
            Anastasia.name = "Anastasia";
            Galina.name = "Galina";
            Yelena.name = "Yelena";
            Manya.name = "Manya";
            Nadia.name = "Nadia";

            List<Women> yourWomen = new List<Women>();

            Console.WriteLine("You work in a brothel in Russia, year 1986. Your job is to buy and sell women.");
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
                    if (theWomen.Count > 0)
                    {
                        System.Console.WriteLine("Would you like to buy a woman?");
                        answer = Console.ReadLine();
                        answer.ToLower();
                    
                    if (answer == "yes") //yes
                    {
                        index = generator.Next(theWomen.Count);

                        System.Console.WriteLine("A random woman was chosen for you, her name is " + theWomen[index].name + ".");
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
                                System.Console.WriteLine("You bought " + theWomen[index].name + ".");
                                
                                
                                System.Console.WriteLine("She costs " + theWomen[index].originalPrice);
                                coins -= theWomen[index].originalPrice;
                                yourWomen.Add(theWomen[index]);
                                theWomen.Remove(theWomen[index]);
                                System.Console.WriteLine("You now have " + coins + " coins left.");
                                Console.ReadLine();
                                howManyLeft = theWomen.Count;
                                System.Console.WriteLine("There are " + howManyLeft + " women left that you can buy.");
                                Console.ReadLine();
                                game = Choice(game);
                                Console.Clear();
                            }
                            else if (answer == "no")
                            {
                                game = Choice(game);
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
                        game = Choice(game);
                        Console.Clear();
                    }
                    else
                    {
                        System.Console.WriteLine("Type either 'yes' or 'no'");
                        answer = Console.ReadLine();
                        answer.ToLower();
                    }
                    }
                    else
                    {
                        System.Console.WriteLine("There are no women left to buy.");
                        Console.ReadLine();
                        Console.Clear();
                        game = Choice(game);
                        Console.Clear();
                    }
                    
                }
                while (game == "work")
                {
                    System.Console.WriteLine("You want to make one of your women work for you?");
                    System.Console.WriteLine("These are the women you own:");

                    for (int i = 0; i < yourWomen.Count; i++)
                    {
                        System.Console.Write(yourWomen[i].name + ", ");
                    }
                    Console.ReadLine();

                    System.Console.WriteLine("One of your women will work for you..");
                    Console.ReadLine();
                    int randomWoman = generator.Next(0, yourWomen.Count);
                    System.Console.WriteLine(yourWomen[randomWoman].name + " made you " + yourWomen[randomWoman].skill + " this day.");
                    coins += yourWomen[randomWoman].skill;
                    System.Console.WriteLine("You now have " + coins + " coins left.");
                    Console.ReadLine();
                    Console.Clear();
                    game = Choice(game);
                    Console.Clear();
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
                while (whatToDo != "buy" /*&& WhatToDo != "sell" && whatToDo != "rescue"*/ && whatToDo != "work")
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


//jag kan inte köpa Nadia
