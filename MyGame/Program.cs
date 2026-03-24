using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
           int n = int.Parse(args[0]);
           Enemy[] enemies = new Enemy[n];
           for (int i = 0; i < n; i++)
           {
            Console.Write($"Nome do inimigo {i+1}:");
            string name = Console.ReadLine();
            enemies[i] = new Enemy(name);
           }
           for (int i = 0; i < enemies.Length; i++)
           {
            Console.WriteLine($"{enemies[i].GetName()} {enemies[i].GetHealth()} {enemies[i].GetShield()}");
           }
        }
    }
}
