using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MegaCardGame2000
{
    public class GameController
    {
        //Properties
        public PlayerCharacter Player;
        public NonPlayerCharacter Enemy;


        //Constructor
        public GameController(string pPlayerName, string pPlayerClass)
        {

            if (pPlayerClass.ToLower() == "Mage")
            {
                Player = new Mage(pPlayerName);

            }
            else if (pPlayerClass.ToLower() == "Warrior")
            {
                Player = new Warrior(pPlayerName);
            }
            else
            {
                Player = new Thief(pPlayerName);
            }
           

            // this is for testing only, random selection needs to be introduced
            Enemy = new NonPlayerCharacter("Goblin");
        }

        public void ChooseNormalAttack()
        {
            Player.CurrentHitPoints -= 10;
        }

        public void ChooseSpecialAttack()
        {
            Player.MakeSpecialAttack(Player, Enemy);
        }

        public void DetermineGameState()
        {

        }

    }
}
