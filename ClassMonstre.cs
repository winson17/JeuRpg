using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class ClassMonstre
    {
        //public enum MonstreJob { Ynov, RER , MalaiseVoyageur };
        public string Name;
        //public MonstreJob Job;
        protected int Pv;
        protected int Force;
        protected int Endurance;
        protected int Taille;

       // public Items[] Inventaire;

        public ClassMonstre(string n)
        {
            Name = n;
           // Job = j;

           /** if (j == MonstreJob.Ynov)
            {
                Pv = 50;
                Force = 100;
                Endurance = 60;
                Taille = 2;

            }

            else if (j == MonstreJob.RER)
            {
                Pv = 150;
                Force = 75;
                Endurance = 85;
                Taille = 1;
            }

            else if (j == MonstreJob.MalaiseVoyageur)
            {
                Pv = 20;
                Force = 10;
                Endurance = 70;
                Taille = 1;
            }**/

            //Inventaire = new Items[10];
            //Inventaire[0] = new Potion("Soin", "Une potion de soin", 1, 2, Potion.PotionType.Heal);

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

        public static ClassMonstre whosTheBest(ClassMonstre[] h)
        {
            ClassMonstre Best = h[0];
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

        /**public void Competence()
        {
            switch (Job)
            {
                case MonstreJob.Ynov:
                    break;
                case MonstreJob.RER:
                    break;
                case MonstreJob.MalaiseVoyageur:
                    break;
            }

        }**/
    }
}
