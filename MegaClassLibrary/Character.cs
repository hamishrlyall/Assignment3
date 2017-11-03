using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MegaCardGame2000;


namespace MegaCardGame2000
{
    public class Character
    {
        // Properties
        public string CharacterName { get; set; }

        public double BaseDamage { get; set; }

        public double MaxHitPoints { get; set; }

        public double CurrentHitPoints { get; set; }

        public NormalAttack NormalAttack { get; set; }

        public CharacterState CharacterState { get; set; }

        //constructor
        public Character(string pCharacterName/*, double pBaseDamage, double pMaxHitPoints, double pCurrentHitPoints, NormalAttack pNormalAttack, CharacterState pCharacterState*/)
        {
            CharacterName = pCharacterName;
            /*BaseDamage = pBaseDamage;
            MaxHitPoints = pMaxHitPoints;
            CurrentHitPoints = pCurrentHitPoints;
            NormalAttack = pNormalAttack;
            CharacterState = pCharacterState;*/
        }

        // Events
        public event PropertyChangedEventHandler PropertyChanged;


        //Methods
        public void TakeDamage(double pDamageAmount)
        {
            pDamageAmount = NormalAttack.DamageAmount;
        }

        public void MakeNormalAttack(Character pAttacker, Character pVictim)
        {
            

        }

        public void OnPropertyChanged(string propertyName)
        {
        }
    }

    public class CharacterState
    {
    }

    public class PlayerCharacter : Character
    {
        public PlayerCharacter(string pCharacterName ) : base(pCharacterName)
        {
            MaxHitPoints = 100;
            CurrentHitPoints = 100;
            BaseDamage = 10;
        }

        public void MakeSpecialAttack(Character pAttacker, Character pVictim)
        {
            Fireball fireball = new Fireball();

        }
    }

    public class NonPlayerCharacter : Character
    {
        public NonPlayerCharacter(string pCharacterName) : base(pCharacterName)
        {
            SetEnemyType();
            if (randomNumber == 0)
            {
                CharacterName = "Rat";
                BaseDamage = 10;
                MaxHitPoints = 40;
                CurrentHitPoints = 40;
            }
            else if (randomNumber == 1)
            {
                CharacterName = "Ogre";
                BaseDamage = 20;
                MaxHitPoints = 100;
                CurrentHitPoints = 100;
            }
            else
            {
                CharacterName = "Dragon";
                BaseDamage = 40;
                MaxHitPoints = 150;
                CurrentHitPoints = 150;
            }

        }

        public NonPlayerCharacterType nonPlayerCharacterType;
        public int randomNumber;

        public void SetEnemyType()
        {
            Random random = new Random();
            randomNumber = random.Next(0, 2);
            /*XmlDocument doc = new XmlDocument();
            doc.Load("nonPlayerCharacterTypes.xml");
            foreach(XmlNode node in doc.DocumentElement)
            {                
                //string CharacterName = node.Attributes[0].InnerText;
                if (randomNumber == 0);
                { 
                    /*foreach (XmlNode child in node.ChildNodes)
                    {
                        nonPlayerCharacterType.Add(child.InnerText);
                    }
                }
                else if (randomNumber == 1);
                {
                    
                }
                else
                {

                }
            //}*/
        }

        public class NonPlayerCharacterType
        {

        }
    }

    public class Mage : PlayerCharacter
    {
        public Fireball Fireball;
        public Mage(string pCharacterName) : base(pCharacterName)
        {

        }
    }
    public class Thief : PlayerCharacter
    {
        public Backstab Backstab;
        public Thief(string pCharacterName) : base(pCharacterName)
        {

        }
    }

    public class Warrior : PlayerCharacter
    {
        public Beserk Beserk;
        public Warrior(string pCharacterName) : base(pCharacterName)
        {

        }
    }
}
