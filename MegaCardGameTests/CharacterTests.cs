using MegaCardGame2000;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MegaCardGameTests
{
    [TestClass()]
    public class CharacterTests
    {
        [TestMethod()]
        public void PlayerCharacterTest()
        {
            //Arrange
            var vTest = new PlayerCharacter("Test Name");

            //Act

            //Assert
            Assert.AreEqual("Test Name", vTest.CharacterName);

        }
        [TestMethod()]
        public void MakeNormalAttackTest()
        {
            //Arrange

        }
        /*[TestMethod()]
        public void PCMakeSpecialAttackTest()
        {
            //Arrange
            var vTest = new GameController("Test Name", "Mage");
            //Act
            vTest.Player.MakeSpecialAttack(Player, Enemy);
            //Assert
            if (vTest.Successful == true)
            {
                Assert.AreEqual(40, vTest.DamageAmount);
            }
            else
            {
                Assert.AreEqual(10, vTest.DamageAmount);
            }
        }*/
        [TestMethod()]
        public void NonPlayerCharacterTest()
        {
            //Arrange
            var vTest = new NonPlayerCharacter("TestName");
            //Act
            //Assert
            Assert.AreEqual("TestName", vTest.CharacterName);
        [TestMethod()]
        public void NPCSetEnemyTypeTest()
        {
            //Arrange
            var vTest = new NonPlayerCharacter("Test Name");
            //Act
            //Assert
            if (vTest.randomNumber == 0)
            {
                //Assert.AreEqual(vTest.NonPlayerCharacterType);
                Assert.AreEqual("Rat", vTest.CharacterName);
                Assert.AreEqual(10, vTest.BaseDamage);
                Assert.AreEqual(40, vTest.MaxHitPoints);
                Assert.AreEqual(40, vTest.CurrentHitPoints);
            }
            else if (vTest.randomNumber == 1)
            {
                //Assert.AreEqual(nonPlayerCharacterTypes.xml, vTest.NonPlayerCharacterType);
                Assert.AreEqual("Ogre", vTest.CharacterName);
                Assert.AreEqual(20, vTest.BaseDamage);
                Assert.AreEqual(100, vTest.MaxHitPoints);
                Assert.AreEqual(100, vTest.CurrentHitPoints);
            }
            else
            {
                //Assert.AreEqual(nonPlayerCharacterTypes.xml, vTest.NonPlayerCharacterType);
                Assert.AreEqual("Dragon", vTest.CharacterName);
                Assert.AreEqual(40, vTest.BaseDamage);
                Assert.AreEqual(150, vTest.MaxHitPoints);
                Assert.AreEqual(150, vTest.CurrentHitPoints);
            }
        }
        [TestMethod()]
        public void MageTest()
        {
            //Arrange
            var vTest = new Mage("Test Name");
            //Act
            //Assert
            Assert.AreEqual("Test Name", vTest.CharacterName);
        }

        [TestMethod()]
        public void TheifTest()
        {
            //Arrange
            var vTest = new Thief("Test Name");
            //Act
            //Assert
            Assert.AreEqual("Test Name", vTest.CharacterName);
        }

        [TestMethod()]
        public void WarriorTest()
        {
            //Arrange
            var vTest = new Warrior("Test Name");
            //Act
            //Assert
            Assert.AreEqual("Test Name", vTest.CharacterName);
        }
        /*[TestMethod()]
        public void TakeDamageTest()
        {
            //Arrange
            var vTest = new NonPlayerCharacter("TestName");
            var vTestEnemy.CurrentHealth = 10;
            var vTestNormalAttack = new NormalAttack(10);
            //Act
            vTestEnemy.TakeDamage(vTestNormalAttack.DamageAmount);
            //Assert
            Assert.AreEqual(10, vTest.NormalAttack.DamageAmount);
            Assert.AreEqual(0, vTestEnemy.CurrentHealth);
        }*/
    }
}
