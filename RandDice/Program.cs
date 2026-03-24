using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);
            Random r1 = new Random(s);
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                total += r1.Next(1, 7);
            }
            Console.Write(total);
        }
    }
}
