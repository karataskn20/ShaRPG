namespace Equipment.Weapons
{
    public abstract class Weapon : Equipment
    {
        private int damagePoints;

        public int DamagePoints
        {
            get
            {
                return damagePoints;
            }
            set
            {
                if (value >= 1)
                {
                    damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage of a weapon can not be less than 1");
                }
            }
        }
    }
}
