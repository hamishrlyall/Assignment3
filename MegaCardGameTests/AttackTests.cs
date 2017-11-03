 using MegaCardGame2000;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGameTests
{
    [TestClass()]
    public class AttackTests
    {
        [TestMethod()]
        public void NormalAttackTest()
        {
            //Arrange
            var vTest = new NormalAttack(10);
            //Act
            //Assert
            Assert.AreEqual(10, vTest.DamageAmount);
        }
        [TestMethod()]
        public void BackstabTest()
        {
            //Arrange
            var vTest = new Backstab();
            //Act
            //Assert
            Assert.AreEqual(33.33, vTest.successChance);
        }
        [TestMethod()]
        public void BackstabCalculateSuccessTest()
        {
            //Arrange
            SpecialAttack vTest = new Backstab();
            //Act
            //Assert
            if (vTest.Successful == true)
            {
                Assert.AreEqual(20, vTest.DamageAmount);
            }
            else
            {
                Assert.AreEqual(5, vTest.DamageAmount);
            }
        }
        [TestMethod()]
        public void BeserkTest()
        {
            //Arrange
            var vTest = new Beserk();
            //Act
            //Assert
            Assert.AreEqual(33.33, vTest.successChance);
        }
        [TestMethod()]
        public void BeserkCalculateSuccessTest()
        {
            //Arrange
            SpecialAttack vTest = new Beserk();
            //Act
            //Assert
            if (vTest.Successful == true)
            {
                Assert.AreEqual(30, vTest.DamageAmount);
            }
            else
            {
                Assert.AreEqual(0, vTest.DamageAmount);
            }
        }
        [TestMethod()]
        public void FireballTest()
        {
            //Arrange
            var vTest = new Fireball();
            //Act
            //Assert
            Assert.AreEqual(50, vTest.successChance);
        }
        [TestMethod()]
        public void FirebasllCalculateSuccessTest()
        {
            //Arrange
            SpecialAttack vTest = new Fireball();
            //Act
            //Assert
            if (vTest.Successful == true)
            {
                Assert.AreEqual(40, vTest.DamageAmount);
            }
            else
            {
                Assert.AreEqual(10, vTest.DamageAmount);
            }
        }
    }

}
