using System;
using System.Collections.Generic;

namespace HeroesAndRatsCSharp
{
    public class Hero
    {
        public string Name { get; set; }
        public int HealthValue { get; set; }
        public int Wallet { get; set; }
        public List<Quest> Quests { get; set; }
        public List<Quest> CompletedQuests { get; set; }
        public List<Weapon> WeaponsList { get; set; }

        public Hero(string name, int healthValue, int wallet)
        {
            this.Name = name;
            this.HealthValue = healthValue;
            this.Wallet = wallet;
            this.Quests = new List<Quest>();
            this.CompletedQuests = new List<Quest>();
            this.WeaponsList = new List<Weapon>();
        }

        public void AcceptQuest(Quest quest)
        {
            Quests.Add(quest);
        }

        public void CompleteQuest(Quest quest)
        {
            foreach (Quest item in Quests.ToArray())
            {
                if (item.Name == quest.Name)
                {
                    quest.Completed = true;
                    Quests.Remove(quest);
                    CompletedQuests.Add(quest);
                    Wallet += quest.Reward;
                }
            }
        }

        public void TakeWeapon(Weapon weapon)
        {
            WeaponsList.Add(weapon);
        }

        public void Attack(Weapon weapon, Enemy enemy)
        {
            foreach (Weapon search in WeaponsList) 
            {
                if (search.Name == weapon.Name)
                {
                    enemy.Health -= weapon.AttackValue;
                }
                if (WeaponsList.Count == 0)
                {
                    HealthValue -= enemy.AttackValue;
                }
            }
        }

        public void RandomAttack(Weapon weapon, Enemy enemy)
        {
            Random randomNumber = new Random();
            var result = randomNumber.Next(0,10);

            if (result % 2 == 0)
            {
                enemy.Health -= weapon.AttackValue;
                Console.WriteLine(this.Name + " attacked " + enemy.Name);
            } else {
                HealthValue -= enemy.AttackValue;
                Console.WriteLine(this.Name + " attacked and missed! " + enemy.Name + " retaliated.");
            }
        }
    }
}
