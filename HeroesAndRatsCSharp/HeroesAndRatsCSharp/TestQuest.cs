using NUnit.Framework;
using System;
namespace HeroesAndRatsCSharp
{
    [TestFixture()]
    public class TestQuest
    {
        private Quest quest;
        [SetUp]
        public void setUp()
        {
            quest = new Quest("Destroy the Mako Reactor", 1, 100, false);
        }

        [Test()]
        public void TestQuestHasName()
        {
            Assert.AreEqual("Destroy the Mako Reactor", quest.Name);
        }

        [Test()]
        public void TestQuestHasDifficulty()
        {
            Assert.AreEqual(1, quest.Difficulty);
        }

        [Test()]
        public void TestQuestHadReward()
        {
            Assert.AreEqual(100, quest.Reward);
        }

        [Test()]
        public void TestQuestIsIncomplete()
        {
            Assert.AreEqual(false, quest.Completed);
        }
    }
}
