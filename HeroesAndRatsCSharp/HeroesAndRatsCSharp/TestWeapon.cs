using NUnit.Framework;
using System;
namespace HeroesAndRatsCSharp
{
    [TestFixture()]
    public class TestWeapon
    {
        private Weapon weapon;
        [SetUp]
        public void setUp()
        {
            weapon = new Weapon("Buster Sword", 100);
        }

        [Test()]
        public void TestWeaponHasName()
        {
            Assert.AreEqual("Buster Sword", weapon.Name);
        }

        [Test()]
        public void TestWeaponHasAttackValue()
        {
            Assert.AreEqual(100, weapon.AttackValue);
        }
    }
}
