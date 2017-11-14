using System;
namespace HeroesAndRatsCSharp
{
    public class Quest
    {
        public string Name { get; set; }
        public int Difficulty { get; set; }
        public int Reward { get; set; }
        public bool Completed { get; set; }

        public Quest(string name, int difficulty, int reward, bool completed)
        {
            this.Name = name;
            this.Difficulty = difficulty;
            this.Reward = reward;
            this.Completed = completed;
        }
    }
}
