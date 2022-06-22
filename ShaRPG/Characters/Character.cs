using Enums;
using Equipment.Armors;
using Equipment.Weapons;
using Interfaces;

namespace ShaRPG.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private bool isDead;
        private int score;
        private int level;
        private int healthPoints;
        private int abilityPoints;
        private string name;
        private Faction faction;
        private Armor armor;
        private Weapon weapon;

        public bool IsDead
        {
            get { return this.isDead; }
            set { this.isDead = value; }
        }
        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }
        public int Level
        {
            get { return level;}
            set
            {
                this.level = value;
                //if (value >= 1 && value <= 20)
                //{
                //    level = value;
                //}
                //else
                //{
                //    throw new ArgumentOutOfRangeException(string.Empty, "Level can not be less than 1 or more than 20");
                //}
            }
        }
        public int HealthPoints
        {
            get { return this.healthPoints; }
            set
            {
                this.healthPoints = value;
                //if (value >= 0)
                //{
                //    this.healthPoints = value;
                //}
                //else
                //{
                //    throw new ArgumentOutOfRangeException(string.Empty, "Health must be more than 0");
                //}
            }
        }
        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    abilityPoints = value;
                }
                else
                {
                    //throw new ArgumentOutOfRangeException(string.Empty, "Ability Points can not be less than 0 or more than 20");
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 28)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Name must be 3 - 18 words long.");
                }
            }
        }
        public Faction Faction
        {
            get { return this.faction; }
            set { this.faction = value; }
        }


        public Armor Armor
        {
            get { return this.armor; }
            set { this.armor = value; }
        }

        public Weapon Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }


        public abstract int Attack();

        public abstract void SpecialAttack();

        public abstract void Defend();

        public void KillEnemy()
        {
            score++;
            level++;
        }

        public void TakeDamage(int damage, string attacker, Character type)
        {
            int damageTaken = this.Armor.ArmorClass == 0 ? damage : (damage - this.Armor.ArmorClass / 4);
            if (damage >= this.Armor.ArmorClass / 2)
            {
                this.HealthPoints -= damageTaken;

                if (HealthPoints <= 0)
                {
                    this.IsDead = true;
                }
            }
            else
            {
                Console.WriteLine($"{attacker} missed!");
            }
            if (IsDead)
            {
                Tools.TypeSpecificColorfulCW($"{this.name} recieved {damageTaken} damage from {attacker}, and got obliterated!", type);
            }
            else
            {
                Tools.TypeSpecificColorfulCW($"{this.name} recieved {damageTaken} damage from {attacker}, and has {this.HealthPoints} health points!", type);
            }
        }
    }
}