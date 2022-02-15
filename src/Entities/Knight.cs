namespace Desafios.src.Entities
{
    public class Knight : HeroShape
    {
        public Knight(string HeroName, int HeroLevel, string HeroType, int HeroHp, int HeroMp) : base(HeroName, HeroLevel, HeroType, HeroHp, HeroMp)
        {
            
        }
        public override string Attack()
        
        {
            return this.HeroName + " Lançou o seu ataque de Espada!";
        }

        public string Attack(int Bonus1)
        {
            if(Bonus1 > 10)
            {
                return this.HeroName + " Lançou o seu ataque de Espada com bônus " + Bonus1;
            }
            else
            {
                return this.HeroName + " Lançou o seu ataque de Espada com bônus " + Bonus1;
            }
            
        }
    }
}