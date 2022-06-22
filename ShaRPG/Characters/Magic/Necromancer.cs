using Enums;
using Equipment.Armors.Robe;
using Equipment.Weapons.Blunt;
using Interfaces;
using ShaRPG;
using ShaRPG.Characters;

namespace Characters.Magic
{
    public class Necromancer : Character, IAttack, IDefend
    {
        private readonly ClothRobe DEFAULT_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Necromancer() : this(Constants.Necromancer.LEVEL, Constants.Necromancer.NAME)
        {

        }

        public Necromancer(int _level, string _name) : this(_level, Constants.Necromancer.HEALTH_POINTS, _name)
        {

        }

        public Necromancer(int _level, int _health, string _name)
        {
            base.Level = _level;
            base.HealthPoints = _health;
            base.AbilityPoints = Constants.Necromancer.MANA_POINTS;
            base.Name = _name;
            base.Faction = Constants.Necromancer.FACTION;
            base.Armor = DEFAULT_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.IsDead = false;
            base.Score = 0;
        }

        public override int Attack() //ShadowRage
        {
            return base.Weapon.DamagePoints + (4 * Level); 
        }

        public override void SpecialAttack() //LifeDrain
        {

        }

        public override void Defend () //VampiricTouch
        {
            base.AbilityPoints--;
            base.Armor.ArmorClass += 4;
            Tools.ColorfulWriteLine($"{this.Name} used Vampiric Touch! (Robe armor +4)", ConsoleColor.DarkMagenta);
        }
        public void LifeDrain(Character _enemy)
        {
            base.AbilityPoints--;
            base.HealthPoints += 10;
            _enemy.HealthPoints -= 10;
            Tools.ColorfulWriteLine($"{this.Name} used Life Drain! (HP +10, Enemy HP -10)", ConsoleColor.DarkMagenta);

        }
    }
}