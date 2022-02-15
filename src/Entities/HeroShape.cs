using System;
namespace Desafios.src.Entities
{
    public abstract class HeroShape
    {
        public HeroShape(string HeroName, int HeroLevel, string HeroType, int HeroHp, int HeroMp)
        {
            this.HeroName = HeroName;
            this.HeroLevel = HeroLevel;
            this.HeroType = HeroType;
            this.HeroHp = HeroHp;
            this.HeroMp = HeroMp;
        }

       public string? HeroName;
       public int HeroLevel;
       public string? HeroType;
       public int HeroHp;
       public int HeroMp;

        public override string ToString()
        {
            return this.HeroName + " Lv:" + this.HeroLevel + " Type:" + this.HeroType + " HP:" + this.HeroHp+ " MP:" + this.HeroMp;
        }

        public virtual string Attack() => this.HeroName + "";
        public virtual string Defense() => this.HeroName + "";
    }
}