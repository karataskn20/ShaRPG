using Enums;
using Equipment.Armors.Robe;
using Equipment.Weapons.Blunt;
using Interfaces;
using ShaRPG;
using ShaRPG.Characters;

namespace Characters.Magic
{
    public class Wizard : Character, IAttack, IDefend
    {
        private readonly ClothRobe DEFAULT_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Wizard() : this(Constants.Wizard.LEVEL, Constants.Wizard.NAME)
        {

        }

        public Wizard(int _level, string _name) : this(_level, Constants.Wizard.HEALTH_POINTS, _name)
        {

        }

        public Wizard(int _level, int _health, string _name)
        {
            base.Level = _level;
            base.HealthPoints = _health;
            base.AbilityPoints = Constants.Wizard.MANA_POINTS;
            base.Name = _name;
            base.Faction = Constants.Wizard.FACTION;
            base.Weapon = DEFAULT_WEAPON;
            base.Armor = DEFAULT_ARMOR;
            base.IsDead = false;
            base.Score = 0;

        }

        public override int Attack() //Fireball
        {
            return base.Weapon.DamagePoints + (7 * Level); // Dice Roll, Fire Attack
        }

        public override void SpecialAttack() //ArcaneWrath
        {
            base.AbilityPoints--;
            base.Weapon.DamagePoints += 7;
            Tools.ColorfulWriteLine($"{this.Name} used Arcane Wrath! (Staff damage +7)", ConsoleColor.Blue);
        }

        public override void Defend() //Meditation
        {
            base.AbilityPoints--;
            base.HealthPoints += 15;
            Tools.ColorfulWriteLine($"{this.Name} used Meditation! (HP +15)", ConsoleColor.Blue);
        }
    }
}