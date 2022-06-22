using ShaRPG.Characters;

namespace Characters.Magic
{
    public abstract class Caster : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get
            {
                return manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    manaPoints = value;
                }
                else
                {
                    //throw new ArgumentOutOfRangeException(string.Empty, "Ability Points can not be less than 0 or more than 20");
                }
            }
        }
    }
}
