using System;
namespace HeroesAndRatsCSharp
{
    public class Weapon
    {
        public string Name { get; set; }
        public int AttackValue { get; set; }

        public Weapon(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}
