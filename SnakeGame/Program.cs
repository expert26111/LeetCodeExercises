using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WindowHeight = 16;
        Console.WindowWidth = 32;
        int screenwidth = Console.WindowWidth;
        int screenheight = Console.WindowHeight;
        Random randomnummer = new Random();
        pixel hoofd = new pixel();
        hoofd.xpos = screenwidth / 2;
        hoofd.ypos = screenheight / 2;
        hoofd.schermkleur = ConsoleColor.Red;
        string movement = "RIGHT";
        List<int> positieX = new List<int>();
        List<int> positieY = new List<int>();
        int obstakelX = randomnummer.Next(1, screenwidth);
        int obstakelY = randomnummer.Next(1, screenheight);
        DateTime tijdje = DateTime.Now;
        string buttonpressed = "no";
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(obstakelX, obstakelY);
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(screenwidth / 2, screenheight / 2);
            Console.Write("º");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 1);
            Console.Write("Score: " + (positieX.Count - 1));
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(hoofd.xpos, hoofd.ypos);
            Console.Write("■");
            Console.SetCursorPosition(obstakelX, obstakelY);
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Gray;
            for (int i = 0; i < screenwidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
            }
            for (int i = 0; i < screenwidth; i++)
            {
                Console.SetCursorPosition(i, screenheight - 1);
                Console.Write("■");
            }
            for (int i = 0; i < screenheight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
            }
            for (int i = 0; i < screenheight; i++)
            {
                Console.SetCursorPosition(screenwidth - 1, i);
                Console.Write("■");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(obstakelX, obstakelY);
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(hoofd.xpos, hoofd.ypos);
            Console.Write("■");
            ConsoleKeyInfo info = Console.ReadKey();
            // do not allow the snake to move into the opposite direction instantly
            if (info.Key.Equals(ConsoleKey.UpArrow) && movement != "DOWN" && buttonpressed == "no")
            {
                movement = "UP";
                buttonpressed = "yes";
            }
            else if (info.Key.Equals(ConsoleKey.DownArrow) && movement != "UP" && buttonpressed == "no")
            {
                movement = "DOWN";
                buttonpressed = "yes";
            }
            else if (info.Key.Equals(ConsoleKey.LeftArrow) && movement != "RIGHT" && buttonpressed == "no")
            {
                movement = "LEFT";
                buttonpressed = "yes";
            }
            else if (info.Key.Equals(ConsoleKey.RightArrow) && movement != "LEFT" && buttonpressed == "no")
            {
                movement = "RIGHT";
                buttonpressed = "yes";
            }
            else
            {
                buttonpressed = "no";
            }
            positieX.Add(hoofd.xpos);
            positieY.Add(hoofd.ypos);
            switch (movement)
            {
                case "UP":
                    hoofd.ypos--;
                    break;
                case "DOWN":
                    hoofd.ypos++;
                    break;
                case "LEFT":
                    hoofd.xpos--;
                    break;
                case "RIGHT":
                    hoofd.xpos++;
                    break;
            }
            if (hoofd.xpos == obstakelX && hoofd.ypos == obstakelY)
            {
                obstakelX = randomnummer.Next(1, screenwidth - 2);
                obstakelY = randomnummer.Next(1, screenheight - 2);
            }
            else
            {
                positieX.RemoveAt(0);
                positieY.RemoveAt(0);
            }
            for (int i = 0; i < positieX.Count - 1; i++)
            {
                if (positieX[i] == hoofd.xpos && positieY[i] == hoofd.ypos)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("Your score is: " + (positieX.Count - 1));
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            if (hoofd.xpos == 0 || hoofd.xpos == screenwidth - 1 || hoofd.ypos == 0 || hoofd.ypos == screenheight - 1)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Game Over!");
                Console.WriteLine("Your score is: " + (positieX.Count - 1));
                Console.ReadLine();
                Environment.Exit(0);
            }
            Thread.Sleep(100);
        }
    }

    public class pixel
    {
        public int xpos { get; set; }
        public int ypos { get; set; }
        public ConsoleColor schermkleur { get; set; }
    }
}