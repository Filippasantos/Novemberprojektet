using System;
using System.Collections.Generic;

namespace NovProj
{
    public class Women
    {
        public int totalClients;
        public int age;
        public int skill;
        public string skinColor;
        public bool std;
        public int originalPrice;
        public int ownPrice;
        public List<string> colors = new List<string>();
        Random generator = new Random();


        public Women()
        {   
            int hiLo = generator.Next(0, 100);
            if (hiLo < 10)
            {
                totalClients = generator.Next(0,14);
            }
            else if (hiLo > 10 && hiLo < 50)
            {
                totalClients = generator.Next(15, 40);
            }
            else if (hiLo > 50)
            {
                totalClients = generator.Next(41, 100);
            }

            age = generator.Next(17, 60);
            colors.Add("Black");
            colors.Add("White");
            colors.Add("Hispanic");
            colors.Add("Asian");
            int whichSkin = generator.Next(3);
            skinColor = colors[whichSkin];

            int trueOrFalse = generator.Next(2);
            if (trueOrFalse == 0)
            {
                std = false;
            }
            else
            {
                std = true;
            }

            skill = generator.Next(20, 50);
        }

        public void clientPlus()
        {
            totalClients++;
        }

        public void getPrice()
        {
            originalPrice = 100;
            int hiLo = generator.Next(0, 100);

            if (hiLo > 5 && hiLo < 50)
            {
                originalPrice -= generator.Next(5, 13);
            }
            else if (hiLo > 50)
            {
                originalPrice -= generator.Next(20, 40);
            }

            if (age > 35)
            {
                originalPrice -= generator.Next(10, 20);
            }

            if(std == true)
            {
                originalPrice -= generator.Next(20, 40);
            }

        }

        public void setOwnPrice()
        {
            int trueOrFalse = generator.Next(2);
            if (trueOrFalse == 0)
            {
                ownPrice = originalPrice + generator.Next(50);
            }
            else
            {
                ownPrice = originalPrice - generator.Next(30); //man vinner på att försöka slumpa
            }
        }

    }
}
