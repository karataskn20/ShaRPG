using Enums;
using Equipment.Armors.Light;
using Equipment.Weapons.Slash;
using Interfaces;
using ShaRPG;
using ShaRPG.Characters;

namespace Characters.Melee
{
    public class Rogue : Character, IAttack, IDefend
    {
        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Rogue() : this(Constants.Rogue.LEVEL, Constants.Rogue.NAME)
        {

        }

        public Rogue(int _level, string _name) : this(_level, Constants.Rogue.HEALTH_POINTS, _name)
        {

        }

        public Rogue(int _level, int _health, string _name)
        {
            base.Level = _level;
            base.HealthPoints = _health;
            base.AbilityPoints = Constants.Rogue.ABILITY_POINTS;
            base.Name = _name;
            base.Faction = Constants.Rogue.FACTION;
            base.Armor = DEFAULT_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsDead = false;
            base.Score = 0;
        }

        public override int Attack() //Raze
        {
            this.AbilityPoints--;
            return base.Weapon.DamagePoints + Level;
        }

        public override void SpecialAttack() //BleedingSlash
        {
            this.AbilityPoints--;
            base.Weapon.DamagePoints += (8 * Level);
            Tools.ColorfulWriteLine($"{this.Name} used Bleeding Slash! (Sword damage +8 * Level)", ConsoleColor.Gray);
        }

        public override void Defend() //SneakingBoost
        {
            base.Armor.ArmorClass += 5 * Level;
            Tools.ColorfulWriteLine($"{this.Name} used Sneaking Boost! (Leather Vest +5 * Level)", ConsoleColor.Gray);
        }
    }
}