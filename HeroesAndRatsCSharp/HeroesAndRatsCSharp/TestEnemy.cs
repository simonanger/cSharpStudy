using NUnit.Framework;
using System;
namespace HeroesAndRatsCSharp
{
    [TestFixture()]
    public class TestEnemy
    {
        private Enemy sephiroth;
        [SetUp]
        public void setUp()
        {
            sephiroth = new Enemy("Sephiroth", 500, 60);
        }

        [Test()]
        public void TestEnemyHasName()
        {
            Assert.AreEqual("Sephiroth", sephiroth.Name);
        }

        [Test()]
        public void TestEnemyHasHealth()
        {
            Assert.AreEqual(500, sephiroth.Health);
        }

        [Test()]
        public void TestEnemyHasAttackValue()
        {
            Assert.AreEqual(60, sephiroth.AttackValue);
        }
    }
}
