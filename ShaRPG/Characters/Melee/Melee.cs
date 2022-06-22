using ShaRPG.Characters;

namespace Characters.Melee
{
    public abstract class Melee : Character
    {
        private int abilityPoints;

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
    }
}
