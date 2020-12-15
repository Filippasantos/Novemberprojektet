using System;

namespace NovProj
{
    public class Women
    {
        public int totalClients;
        public int age;
        public string skinColor;
        public bool std;
        public int originalPrice;
        public int ownPrice;
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


        }

        public void clientPlus()
        {
            totalClients++;
        }

        public void getPrice()
        {

        }

        public void setOwnPrice()
        {

        }

    }
}
