using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enemy loki = new Enemy("Loki");

            loki.SetName("   Grindalokki   ");
            Console.WriteLine($"Name is {loki.GetName()} and HP is {loki.GetHealth()}");
        }
    }
}
