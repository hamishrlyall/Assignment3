using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame2000
{
    class Character
    {
        public string CharacterName;

        public double BaseDamage;

        public double MaxHitPoints;

        public double CurrentHitPoints;

        public NormalAttack NormalAttack;

        public CharacterState Characterstate;

        public event PropertyChangedEventHandler PropertyChanged;

        public void Character(string pCharacterName)
        {
        }

        public void TakeDamage(double pDamageAmount)
        {
        }

        public void MakeNormalAttack(Character pAttacker, Character pVictim)
        {
        }

        public void OnPropertyChanged(string propertyName)
        {
        }
    }
}
