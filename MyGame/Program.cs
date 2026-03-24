using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
          Enemy e1 = new Enemy("Darth Vader");
          e1.PickPowerUp(PowerUp.Health, 101);
          e1.PickPowerUp(PowerUp.Shield, 5);
          e1.TakeDamage(5);
          Console.WriteLine(e1.GetHealth());
          Console.WriteLine(e1.GetShield());
        }
    }
}
