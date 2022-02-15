namespace Desafios.src.Entities
{
    public class WizardBlack : HeroShape
    {
        public WizardBlack(string HeroName, int HeroLevel, string HeroType, int HeroHp, int HeroMp) : base(HeroName, HeroLevel, HeroType, HeroHp, HeroMp)
        {

        }

        public override string Attack()
        
        {
            return this.HeroName + " Lançou a sua Magia Negra!";
        }
        public override string Defense()
        
        {
            return this.HeroName + " Defendeu com sua fumaça dissipadora!";
        }

        public string Attack(int Bonus3)
        {
            if(Bonus3 > 10)
            {
                return this.HeroName + " Lançou a sua Super Poção Negra com bônus de " + Bonus3;
            }
            else
            {
                return this.HeroName + " Lançou a sua Poção Negra com bônus de " + Bonus3;
            }
        }
    }
}