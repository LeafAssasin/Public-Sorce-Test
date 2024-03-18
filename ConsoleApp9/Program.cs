using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
            int a = 5;
            for (int i = 1; i <= 5; i++)
            {
                a--;
                for (int l = 0; l < a; l++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */

            /*
            int y = 2000;
            double t = 20;
            Console.WriteLine($"{y} = {Math.Round(t, 2)}");
            while (t < 50)
            {
                y++;
                t = t + t * 0.20;
                Console.WriteLine($"{y} = {Math.Round(t, 2)}");
            }
            Console.WriteLine($"През {y} година реколтата е над 50 тона.");
            Console.ReadLine();
            */

            int y = 2000;
            double t = 20;
            Console.WriteLine($"{y} = {Math.Round(t, 2)}");
            while (t < 900)
            {
                y++;
                t = t + t * 0.20;
                Console.WriteLine($"{y} = {Math.Round(t, 2)}");
            }
            Console.WriteLine($"През {y} година реколтата е над 900 тона.");
            Console.ReadLine();
        }
    }
}
