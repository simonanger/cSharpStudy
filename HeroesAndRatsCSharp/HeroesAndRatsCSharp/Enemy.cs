using System;
namespace HeroesAndRatsCSharp
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set;}
        public int AttackValue { get; set; }

        public Enemy(string name, int health, int attackValue)
        {
            this.Name = name;
            this.Health = health;
            this.AttackValue = attackValue;
        }
    }
}
