namespace Equipment.Armors
{
    public abstract class Armor : Equipment
    {
        private int armorClass;

        public int ArmorClass
        {
            get
            {
                return armorClass;
            }
            set
            {
                if (value >= 0)
                {
                    armorClass = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor Class can not be less than 0");
                }
            }
        }
    }
}
