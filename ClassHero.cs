using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class ClassHero
    {
        // public enum HeroGenre { Garçon, Fille, Trans };
        public string Name;
        // public HeroGenre Genre;
        protected int Pv;
        protected int Force;
        protected int Endurance;
        protected int Taille;
        public Items[] Inventaire;
        public static Case[,] Position;
       // public string genre;

        public ClassHero(string n)
        {
            Name = n;
            Inventaire = new Items[10];
            Inventaire[0] = new Potion("Soin", "Une potion de soin", 1, 2, Potion.PotionType.Heal);

        }
        public virtual int Damage(int degats)
        {
            Pv -= degats;
            if (Pv <= 0)
            {
                Console.WriteLine("Dead");
            }
            return Pv;
        }

        public static ClassHero whosTheBest(ClassHero[] h)
        {
            ClassHero Best = h[0];
            for (int i = 1; i < h.Length; i++)
            {
                if (h[0].Force > Best.Force)
                {
                    Best = h[1];
                }
            }
            return Best;
        }
     
        public virtual int Attack()
        {
            return 1;
        }
    }

}  

