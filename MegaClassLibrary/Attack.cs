using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame2000
{
    public class Attack
    {
        public double DamageAmount;
    }
    public class NormalAttack : Attack
    {
        public NormalAttack (double pBaseDamage)
        {
            DamageAmount = pBaseDamage;

        }
    }
    public class SpecialAttack : Attack
    {
        public double successChance;

        public double damageMultiplier;

        public bool Successful;

    }
    public class Backstab : SpecialAttack
    {
        public Backstab() : base()
        {
            successChance = 33.33;
            if (Successful == true)
            {
                DamageAmount = 20;
            }
            else
            {
                DamageAmount = 5;
            }
        }

        public void CalculateSuccess()
        {

        }
    }
    public class Beserk : SpecialAttack
    {
        public Beserk() : base()
        {
            successChance = 33.33;
            if (Successful == true)
            {
                DamageAmount = 30;
            }
            else
            {
                DamageAmount = 0;
            }
        }
        public void CalculateSuccess()
        {

        }
    }
    public class Fireball : SpecialAttack
    {
        public Fireball() : base()
        {
            CalculateSuccess();
            successChance = 50;
            if (Successful == true)
            {
                DamageAmount = 40;
            }
            else
            {
                DamageAmount = 10;
            }

        }
        public void CalculateSuccess()
        {
            Random random = new Random();
            int roll = random.Next(1, 2);

                if (roll == 2)
                {
                    Successful = true;
                }
                else
                {
                    Successful = false;
                }
        }
    }
}


