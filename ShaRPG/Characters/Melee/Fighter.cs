using Equipment.Armors.Heavy;
using Equipment.Weapons.Slash;
using Interfaces;
using ShaRPG;
using ShaRPG.Characters;

namespace Characters.Melee
{
    public class Fighter : Character, IAttack, IDefend
    {
        private readonly Chainmail DEFAULT_ARMOR = new Chainmail();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        public Fighter() : this(Constants.Fighter.LEVEL,Constants.Fighter.NAME)
        {

        }
        
        public Fighter(int _level, string _name) : this(_level, Constants.Fighter.HEALTH_POINTS, _name)
        {

        }

        public Fighter(int _level, int _health, string _name)
        {
            base.Level = _level;
            base.HealthPoints = _health;
            base.AbilityPoints = Constants.Fighter.ABILITY_POINTS;
            base.Name = _name;
            base.Faction = Constants.Fighter.FACTION;
            base.Armor = DEFAULT_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsDead = false;
            base.Score = 0;
        }

        public override int Attack() //Strike
        {
            return base.Weapon.DamagePoints;
        }

        public override void SpecialAttack() //Execute
        {
            base.AbilityPoints--;
            base.Weapon.DamagePoints += 2 * Level;
            Tools.ColorfulWriteLine($"{this.Name} used Execute! (Axe damage +2 * Level)", ConsoleColor.Yellow);
        }

        public override void Defend() //HardenSkin
        {
            base.AbilityPoints--;
            base.Armor.ArmorClass += 5;
            Tools.ColorfulWriteLine($"{this.Name} used Harden Skin! (Chainmail armor +5)", ConsoleColor.Yellow);
        }
    }
}