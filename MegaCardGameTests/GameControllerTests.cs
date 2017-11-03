using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MegaCardGame2000;
namespace MegaCardGameTests
{
    [TestClass]
    public class GameControllerTests
    {
        [TestMethod()]
        public void GameControllerTest()
        {
            //Arrange
            var vTest = new GameController("Test Name", "Mage");
            //Act
            //Assert
            Assert.AreEqual("Test Name", vTest.Player.CharacterName);
        }
        [TestMethod()]
        public void GCChooseNormalAttack()
        {
            //Arrange
            var vTest = new GameController("Test Name", "Mage");
            //Act
            vTest.ChooseNormalAttack();
            //Assert
            Assert.AreEqual(90, vTest.Player.CurrentHitPoints);
        }
        [TestMethod()]
        public void GCChooseSpecialAttack()
        {
            //Arrange
            var vTest = new GameController("Test Name", "Mage");
            //Act
            vTest.ChooseSpecialAttack();
            //Assert
            if (vTest.Player.SpecialAttack.Successful == true)
            {
                Assert.AreEqual(40, vTest.Player.Attack.DamageAmount);
            }
            else
            {
                Assert.AreEqual(10, vTest.Player.Attack.DamageAmount);
            }
        }
    }
}
