using Equipment.Armors.Light;
using Equipment.Weapons.Blunt;
using Interfaces;
using ShaRPG;
using ShaRPG.Characters;

namespace Characters.Magic
{
    public class Druid : Character, IAttack, IDefend
    {
        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Druid() : this(Constants.Druid.LEVEL, Constants.Druid.NAME)
        {

        }

        public Druid(int _level, string _name) : this(_level, Constants.Druid.HEALTH_POINTS, _name)
        {

        }

        public Druid(int _level, int _health, string _name)
        {
            base.Level = _level;
            base.HealthPoints = _health;
            base.AbilityPoints = Constants.Druid.MANA_POINTS;
            base.Name = _name;
            base.Faction = Constants.Druid.FACTION;
            base.Armor = DEFAULT_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsDead = false;
            base.Score = 0;
        }

        public override int Attack() //Moonfire
        {
            return base.Weapon.DamagePoints + (4 * Level);
        }

        public override void SpecialAttack() //Starburst
        {
            base.AbilityPoints--;
            base.Weapon.DamagePoints += 5;
            Tools.ColorfulWriteLine($"{this.Name} used Starburst! (Magic damage +5)", ConsoleColor.Green);
        }

        public override void Defend() //NaturesCall
        {
            base.AbilityPoints--;
            base.HealthPoints += 25;
            Tools.ColorfulWriteLine($"{this.Name} used Nature's Call! (HP +25)", ConsoleColor.Green);
        }
    }
}