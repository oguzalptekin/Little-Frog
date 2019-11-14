using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Little_Frog
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = new string[51];
            Random rnd = new Random();
            int[] section = new int[7] { 0, 8, 17, 25, 34, 42, 50 };
            int[] carPlace = new int[6];
            bool carcoming = false;
            string deleteThis;

            //For determining car places on the road
            for (int i = 0; i <= 5; i++)
            {
                carPlace[i] = rnd.Next(section[i], section[i + 1]);
            }

            //Line creating loop
            for (int i = 0; i <= 50; i++)
            {
                //Checks if there is a car on that line or not
                for (int a = 0; a <= 5; a++)
                {
                    //if there is a car on that point
                    if (i == carPlace[a] || (i - 1) == carPlace[a])
                    {
                        //Places the car
                        line1[i] = "1";
                    }
                }
                //if there isn't a car in that point
                if (line1[i] == null)
                {
                    //Places the road
                    line1[i] = "-";
                }
                Console.Write(line1[i]);
            }

            //now its time for it to flow
            //Pseudo solution
            while (carcoming == false)
            {
                Console.Clear();
                for (int i = 0; i <= 49; i++)
                {
                    if (i == 0)
                    {
                        //deleteThis = line1[50];
                        line1[50] = line1[i];
                        //line1[i] = deleteThis; //ilk baştaki değere göre sürekli 1 veya - üretilmesine neden oluyor!
                        line1[i] = line1[i + 1];
                    }
                    else
                    {
                        line1[i] = line1[i + 1];
                    }
                    Console.Write(line1[i]);
                }
                Thread.Sleep(500);
            }

        }
    }
}