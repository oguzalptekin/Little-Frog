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
            Console.CursorVisible = false;
            int frogx = 53, frogy = 13;
            ConsoleKeyInfo cki;
            int counter = 0, level = 1, score = 0, life = 1; //require elements
            string direction = "";
            int car_type_2 = 2, car_type_1 = 1;
            string[] line1 = new string[51];
            Random rnd = new Random();
            int[] section = new int[7] { 0, 8, 17, 25, 34, 42, 50 };
            int[] carPlace = new int[6];
            bool carcoming = false;
            Console.CursorVisible = false;
            int carcounter;


            //For determining car places on the road
            for (int i = 0; i <= 5; i++)
            {
                carPlace[i] = rnd.Next(section[i], section[i + 1]);
            }

            ////Line creating loop
            //for (int i = 0; i <= 50; i++)
            //{
            //    //Checks if there is a car on that line or not
            //    for (int a = 0; a <= 5; a++)
            //    {
            //        //if there is a car on that point
            //        if (i == carPlace[a] || (i - 1) == carPlace[a])
            //        {
            //            //Places the car
            //            line1[i] = "1";
            //        }
            //    }
            //    //if there isn't a car in that point
            //    if (line1[i] == null)
            //    {
            //        //Places the road
            //        line1[i] = "-";
            //    }
            //    Console.Write(line1[i]);
            //}

            while (true)
            {
                Console.SetCursorPosition(1, 1);
                Console.WriteLine("Time: " + counter);
                Console.SetCursorPosition(12, 1);
                Console.WriteLine("Level: " + level);
                Console.SetCursorPosition(30, 1);
                Console.WriteLine("Score: " + score);
                Console.SetCursorPosition(65, 1);
                Console.WriteLine("Life: " + life);
                Console.SetCursorPosition(80, 1);
                Console.WriteLine("Frog Direction: " + direction);

                Console.SetCursorPosition(1, 5);
                Console.WriteLine("R1");
                Console.SetCursorPosition(1, 7);
                Console.WriteLine("R2");
                Console.SetCursorPosition(1, 9);
                Console.WriteLine("R3");
                Console.SetCursorPosition(1, 11);
                Console.WriteLine("R4");

                Console.SetCursorPosition(107, 5);
                Console.WriteLine("<<<");
                Console.SetCursorPosition(107, 7);
                Console.WriteLine("<<<");
                Console.SetCursorPosition(107, 9);
                Console.WriteLine(">>>");
                Console.SetCursorPosition(107, 11);
                Console.WriteLine(">>>");






                //Print Road
                int cursorx = 3, cursory = 3;

                for (int i = 3; i <= 54; i++)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    Console.WriteLine("--");
                    cursorx = cursorx + 2;
                }


                for (int a = 1; a <= 4; a++)
                {
                    cursory = cursory + 2;
                    cursorx = 3;
                    for (int i = 3; i <= 54; i++)
                    {
                        Console.SetCursorPosition(cursorx, cursory);
                        Console.WriteLine(". ");
                        cursorx = cursorx + 2;
                    }
                }
                cursory = cursory + 2;
                cursorx = 3;
                for (int y = 3; y <= 54; y++)
                {
                    Console.SetCursorPosition(cursorx, cursory);
                    Console.WriteLine("--");
                    cursorx = cursorx + 2;
                }

                //Frog Movement
                Console.SetCursorPosition(frogx, frogy);
                Console.WriteLine("F");
                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey(true);

                    if (cki.Key == ConsoleKey.RightArrow && frogx < 103)
                    {
                        Console.SetCursorPosition(frogx, frogy);
                        Console.WriteLine("");
                        frogx += 2;
                        counter++;
                        direction = "Right ";
                    }

                    if (cki.Key == ConsoleKey.LeftArrow && frogx > 3)
                    {
                        Console.SetCursorPosition(frogx, frogy);
                        Console.WriteLine("");
                        frogx -= 2;
                        counter++;
                        direction = "Left  ";
                    }

                    if (cki.Key == ConsoleKey.UpArrow && frogy > 3)
                    {
                        Console.SetCursorPosition(frogx, frogy);
                        Console.WriteLine("");
                        frogy -= 2;
                        counter++;
                        direction = "Up    ";
                    }

                    if (cki.Key == ConsoleKey.DownArrow && frogy < 12)
                    {
                        Console.SetCursorPosition(frogx, frogy);
                        Console.WriteLine("");
                        frogy += 2;
                        counter++;
                        direction = "Down  ";
                    }
                    if (cki.Key == ConsoleKey.Escape)
                        break;

                    while (Console.KeyAvailable)
                    {
                        cki = Console.ReadKey();
                    }


                }
                Thread.Sleep(500);


            }
            Console.ReadLine();
        }
    }
}
