using Enums;
using Equipment.Armors.Heavy;
using Equipment.Weapons.Blunt;
using Interfaces;
using ShaRPG;
using ShaRPG.Characters;

namespace Characters.Melee
{
    public class Paladin : Character, IAttack, IDefend
    {
        private readonly Chainmail DEFAULT_ARMOR = new Chainmail();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        public Paladin() : this(Constants.Paladin.LEVEL, Constants.Paladin.NAME)
        { 
        
        }
        
        public Paladin(int _level, string _name) : this(_level, Constants.Paladin.HEALTH_POINTS, _name)
        {

        }

        public Paladin(int _level, int _health, string _name)
        {
            base.Level = _level;
            base.HealthPoints = _health;
            base.AbilityPoints = Constants.Paladin.ABILITY_POINTS;
            base.Name = _name;
            base.Faction = Constants.Paladin.FACTION;
            base.Weapon = DEFAULT_WEAPON;
            base.Armor = DEFAULT_ARMOR;
            base.IsDead = false;
            base.Score = 0;
        }

        public override int Attack() //HolyBlow
        {
            return base.Weapon.DamagePoints;
        }
        public override void SpecialAttack() //PurifySoul
        {
            base.AbilityPoints--;
            base.HealthPoints += 10;
            Tools.ColorfulWriteLine($"{this.Name} used Purification! (HP +10 * Level)", ConsoleColor.DarkYellow);            
        }
        public override void Defend() //RighteousWings
        {
            base.AbilityPoints--;
            base.Armor.ArmorClass += 5;
            Tools.ColorfulWriteLine($"{this.Name} used Divine Wings! (Plate Armor +5)", ConsoleColor.DarkYellow);
        }
    }
}