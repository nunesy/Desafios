namespace Desafios.src.Entities
{
    public class Ninja : HeroShape
    {
        public Ninja(string HeroName, int HeroLevel, string HeroType, int HeroHp, int HeroMp) : base(HeroName, HeroLevel, HeroType, HeroHp, HeroMp)
        {

        }

        public override string Attack()
        
        {
            return this.HeroName + " Lançou o seu ataque de voadora de fogo!";
        }
        public override string Defense()
        
        {
            return this.HeroName + " Defendeu com seus braços de aço!";
        }

        public string Attack(int Bonus4)
        {
            if(Bonus4 > 10)
            {
                return this.HeroName + " ataque de estrelas de fogo com bônus de " + Bonus4;
            }
            else
            {
                return this.HeroName + " ataque de estrelas de fogo com bônus de " + Bonus4;
            }
        }
    }
}