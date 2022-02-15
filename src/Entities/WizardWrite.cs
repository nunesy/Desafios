namespace Desafios.src.Entities
{
    public class WizardWrite : HeroShape
    {
        public WizardWrite(string HeroName, int HeroLevel, string HeroType, int HeroHp, int HeroMp) : base(HeroName, HeroLevel, HeroType, HeroHp, HeroMp)
        {
        }

        public override string Attack()
        
        {
            return this.HeroName + " Lançou a sua Magia!";
        }
        public override string Defense()
        
        {
            return this.HeroName + " Defendeu se tornando invisível com sua capa branca!";
        }

        public string Attack(int Bonus2)
        {
            if(Bonus2 > 10)
            {
                return this.HeroName + " Lançou a sua Super Magia com bônus de " + Bonus2;
            }
            else
            {
                return this.HeroName + " Lançou a sua Magia com bônus de " + Bonus2;
            }
            
        }
    }
}