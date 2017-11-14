using NUnit.Framework;
using System;
namespace HeroesAndRatsCSharp
{
    [TestFixture()]
    public class TestHero
    {
        private Hero cloud;
        private Quest quest1;
        private Weapon weapon;
        private Enemy sephiroth;

        [SetUp]
        public void setUp()
        {
            cloud = new Hero("Cloud", 100, 1000);
            quest1 = new Quest("Destroy the Mako Reactor", 1, 100, false);
            weapon = new Weapon("Buster Sword", 100);
            sephiroth = new Enemy("Sephiroth", 500, 60);
        }

        [Test()]
        public void TestHeroHasName()
        {
            Assert.AreEqual("Cloud", cloud.Name);
        }

        [Test()]
        public void TestHeroHasHealth()
        {
            Assert.AreEqual(100, cloud.HealthValue);
        }

        [Test()]
        public void TestHeroMoney()
        {
            Assert.AreEqual(1000, cloud.Wallet);
        }

        [Test()]
        public void TestQuestsStartEmpty()
        {
            Assert.AreEqual(0, cloud.Quests.Count);
        }

        [Test()]
        public void TestCompletedQuestsStartEmpty()
        {
            Assert.AreEqual(0, cloud.CompletedQuests.Count);
        }

        [Test()]
        public void TestWeaponsListStartsEmpty()
        {
            Assert.AreEqual(0, cloud.WeaponsList.Count);
        }

        [Test()]
        public void TestHeroCanAcceptQuests()
        {
            cloud.AcceptQuest(quest1);
            Assert.AreEqual(1, cloud.Quests.Count);
            Assert.AreEqual("Destroy the Mako Reactor", cloud.Quests[0].Name);
        }

        [Test()]
        public void TestCompleteQuestAddsToCompletedList()
        {
            cloud.AcceptQuest(quest1);
            cloud.CompleteQuest(quest1);
            Assert.AreEqual(1, cloud.CompletedQuests.Count);
        }

        [Test()]
        public void TestCompleteQuestsMoveFromQuestsList()
        {
            cloud.AcceptQuest(quest1);
            cloud.CompleteQuest(quest1);
            Assert.AreEqual(0, cloud.Quests.Count);
        }

        [Test()]
        public void TestCompletedQuestUpdatesWallet()
        {
            cloud.AcceptQuest(quest1);
            cloud.CompleteQuest(quest1);
            Assert.AreEqual(1100, cloud.Wallet); 
        }

        [Test()]
        public void TestHeroCanTakeWeapon()
        {
            cloud.TakeWeapon(weapon);
            Assert.AreEqual(1, cloud.WeaponsList.Count);
        }

        [Test()]
        public void TestHeroCanAttackEnemy()
        {
            cloud.TakeWeapon(weapon);
            cloud.Attack(weapon, sephiroth);
            Assert.AreEqual(400, sephiroth.Health);
        }

        [Test()]
        public void TestRandomAttack()
        {
            cloud.RandomAttack(weapon, sephiroth);
        }
    }
}
