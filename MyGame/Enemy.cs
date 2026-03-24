using System;


namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }
        public string SetName(string name)
        {

            if (name.Length >= 8)
            {
                this.name = name.Substring(0, 8).Trim();
            }
            else
            {
                this.name = name;
            }
            return this.name;
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
        public void PickPowerUp(PowerUp power, float v)
        {
            if (power == PowerUp.Health)
            {

                if (v <= 100)
                    this.health += v;
            }
            else if (power == PowerUp.Shield)
            {
                if (v <= 100)
                    this.shield += v;
            }
        }
    }
}