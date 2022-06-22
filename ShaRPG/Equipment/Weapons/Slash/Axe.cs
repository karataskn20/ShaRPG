namespace Equipment.Weapons.Slash
{
    public class Axe : Slash
    {
        public Axe()
        {
            base.DamagePoints = 8; // 1d8
        }
        public void Slash()
        {
            throw new NotImplementedException();
        }
    }
}
