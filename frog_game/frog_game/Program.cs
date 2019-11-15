using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                int opt;
                ConsoleKeyInfo answer;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();

                Console.WriteLine(" ~ A D V E N T U R O U S  F R O G ~\n\n1) PLAY\n\n2) RULES\n\n3) EXIT");
                Console.Write("\nPlease choose an option: ");
                opt = Convert.ToInt32(Console.ReadLine());
                Console.Clear();



                if (opt == 1)
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    int frogx = 53, frogy = 13;
                    ConsoleKeyInfo cki;
                    int counter = 0, level = 1, score = 0, life = 1; //require elements
                    string direction = "";
                    int car_type2 = 2, car_type_1 = 10;
                    Console.CursorVisible = false;
           

                    int car_1 = 10, car_2 = 2; //car variables
                    string[] line1 = new string[52];
                    string[] line2 = new string[52];
                    string[] line3 = new string[52];
                    string[] line4 = new string[52];
                    Random rnd = new Random();
                    int[] section = new int[7] { 1, 8, 17, 25, 34, 42, 49 };
                    int[] car_type = new int[] { 1, 2 };
                    int[] car_length = new int[] { 2, 3, 4 };
                    int car_length_rnd = rnd.Next(0, car_length.Length);
                    int[] carPlace = new int[6];
                    bool carcoming = false;
                    Console.CursorVisible = false;
                    int carcounter;


                    //For determining car places on the road
                    for (int i = 0; i <= 5; i++)
                    {
                        carPlace[i] = rnd.Next(section[i], section[i + 1]);
                    }

                    //Line creating loop
                    for (int i = 0; i <= 51; i++)
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
                        //Console.Write(line1[i]);
                    }
                    //For determining car places on the road
                    for (int i = 0; i <= 5; i++)
                    {
                        carPlace[i] = rnd.Next(section[i], section[i + 1]);
                    }
                    for (int i = 0; i <= 51; i++)
                    {
                        //Checks if there is a car on that line or not
                        for (int a = 0; a <= 5; a++)
                        {
                            //if there is a car on that point
                            if (i == carPlace[a] || (i - 1) == carPlace[a])
                            {
                                //Places the car
                                line2[i] = "1";
                            }
                        }
                        //if there isn't a car in that point
                        if (line2[i] == null)
                        {
                            //Places the road
                            line2[i] = "-";
                        }
                        //Console.Write(line1[i]);
                    }
                    //For determining car places on the road
                    for (int i = 0; i <= 5; i++)
                    {
                        carPlace[i] = rnd.Next(section[i], section[i + 1]);
                    }
                    for (int i = 0; i <= 51; i++)
                    {
                        //Checks if there is a car on that line or not
                        for (int a = 0; a <= 5; a++)
                        {
                            //if there is a car on that point
                            if (i == carPlace[a] || (i - 1) == carPlace[a])
                            {
                                //Places the car
                                line3[i] = "1";
                            }
                        }
                        //if there isn't a car in that point
                        if (line3[i] == null)
                        {
                            //Places the road
                            line3[i] = "-";
                        }
                        //Console.Write(line1[i]);
                    }
                    //For determining car places on the road
                    for (int i = 0; i <= 5; i++)
                    {
                        carPlace[i] = rnd.Next(section[i], section[i + 1]);
                    }
                    for (int i = 0; i <= 51; i++)
                    {
                        //Checks if there is a car on that line or not
                        for (int a = 0; a <= 5; a++)
                        {
                            //if there is a car on that point
                            if (i == carPlace[a] || (i - 1) == carPlace[a])
                            {
                                //Places the car
                                line4[i] = "1";
                            }
                        }
                        //if there isn't a car in that point
                        if (line4[i] == null)
                        {
                            //Places the road
                            line4[i] = "-";
                        }
                        //Console.Write(line1[i]);
                    }

                    ////now its time for it to flow
                    ////Pseudo solution
                    //while (carcoming == false)
                    //{
                    //    Console.Clear();
                    //    for (int i = 0; i <= 49; i++)
                    //    {
                    //        line1[i] = line1[i + 1];
                    //        Console.Write(line1[i]);
                    //    }


                    //    //Carcounter
                    //    carcounter = 0;
                    //    for (int i = 0; i <= 49; i++)
                    //    {
                    //        if (line1[i] == "1" && line1[i + 1] == "-" || line1[i] == "2" && line1[i + 1] == "-")
                    //        {
                    //            carcounter++;
                    //        }
                    //    }
                    //}


                    while (true)
                    {
                        //LEVEL PART -NOT FINISHED-

                        bool flag_level = true;

                        if (frogy == 3)
                        {

                            frogx = 53;
                            frogy = 13;
                            level += 1;
                            if (level > 6)
                            {
                                flag_level = false;
                            }
                            car_1 -= 2;
                            car_2 += 2;
                            if (counter > 60)
                            {
                                score = score + 0;
                            }
                            else
                            {
                                score = score + (60 - counter);
                            }
                            Thread.Sleep(500);
                        }


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
                            Console.Write("--");
                            cursorx = cursorx + 2;
                        }


                        for (int a = 1; a <= 4; a++)
                        {
                            cursory = cursory + 2;
                            cursorx = 3;
                            for (int i = 0; i <= 51; i++)
                            {
                                switch (a)
                                {
                                    case 1:
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.WriteLine(line1[i]);
                                        cursorx = cursorx + 2;
                                        break;
                                    case 2:
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.WriteLine(line2[i]);
                                        cursorx = cursorx + 2;
                                        break;
                                    case 3:
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.WriteLine(line3[i]);
                                        cursorx = cursorx + 2;
                                        break;
                                    case 4:
                                        Console.SetCursorPosition(cursorx, cursory);
                                        Console.WriteLine(line4[i]);
                                        cursorx = cursorx + 2;
                                        break;
                                }
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


                        //Code that makes cars move
                        for (int i = 0; i <= 49; i++)
                        {
                            line1[i] = line1[i + 1];

                        }
                        for (int i = 0; i <= 49; i++)
                        {
                            line2[i] = line2[i + 1];

                        }
                        for (int i = 50; i >= 1; i--)
                        {
                            line3[i] = line3[i - 1];

                        }
                        for (int i = 50; i >= 1; i--)
                        {
                            line4[i] = line4[i - 1];

                        }


                        //Carcounter - Need Fix
                        carcounter = 0;
                        for (int i = 0; i <= 49; i++)
                        {
                            if (line1[i] == "1" && line1[i + 1] == "-" || line1[i] == "2" && line1[i + 1] == "-")
                            {
                                carcounter++;
                            }
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
                        }

                        if (flag_level == false)
                        {
                            Console.Clear();
                            break;

                        }
                        Thread.Sleep(500);
                    }


                    Console.SetCursorPosition(55, 11);
                    Console.WriteLine("GAME OVER");
                    Console.SetCursorPosition(52, 13);
                    Console.WriteLine("Your Score: " + score);


                    Console.ReadLine();

                }
                if (opt == 2)
                {

                    Console.WriteLine("\n\n\n RULES:\n\n * Initially, the frog has one life." +
                        " If the frog manages to cross the road, its life count and the level of the game are increased by one." +
                        "\n\n * At each level, the score is calculated as follows. At the start of the game the player has 60 points." +
                        "The score of the level depends on the time that the frog takes to cross the road.The score is calculated as  60 - time taken by the frog to cross." +
                        "Then, the final point is obtained by adding all the scores gained in each level.\n\n *If a frog is hit by a vehicle," +
                        " it loses one life and returns to the starting position," +
                        " if it has any life left. If the frog has no life count left, the game is lost and over.\n\n " +
                        "* The frog always starts to move from the middle of the road. (The 25th square)\n\n * Throughout the game, there should always be a total of 12 cars in each direction." +
                        "\n\n * Type - 2 vehicles are twice as fast as Type - 1 vehicles.\n\n * If there is only 1 space between the fast vehicle and the slow vehicle, " +
                        "the fast vehicle can pass to the empty lane  in the same direction and over - take the car in front of it.If there is no empty square on  the other lane, " +
                        "it has to   reduce its speed to the speed of the vehicle ahead and stay on its own lane.\n\n * A vehicle that reaches the end of the lane is removed from the road." +
                        " A new vehicle is created at the start position  on one of the lanes in the same direction.The size of the created vehicle is random and " +
                        "the  type of the vehicle depends on the rules of the played level.");
                    Console.ReadLine();

                }
                else if (opt == 3)
                {
                    while (true)
                    {
                        Console.WriteLine("Are you sure you want to exit :( ?\n\nYES(press 1)      NO(press 2)");
                        answer = Console.ReadKey();
                        if (answer.Key != ConsoleKey.D1 && answer.Key != ConsoleKey.D2)
                            Console.WriteLine("Invalid key");
                        else if (answer.Key == ConsoleKey.D2)
                            break;
                        else if (answer.Key == ConsoleKey.D1)
                            Console.WriteLine("\n            BYE!");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }

                }
                else
                    Console.WriteLine("Invalid choice");
            }
            Console.ReadKey();
        }
    }
}








