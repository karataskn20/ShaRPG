namespace Equipment.Weapons.Slash
{
    public class Sword : Slash
    {
        public Sword()
        {
            base.DamagePoints = 12; // 2d6
        }
        public void Bloodthirst()
        {
            throw new NotImplementedException();
        }
    }
}
