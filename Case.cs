using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class Case
    {
        public enum CaseType { Ecole, Gare, Maison, Chemin };
        public int X;
        public int Y;
        public CaseType Type;
        public string Description;
        public ClassMonstre monstre; 
        public Items Items;

        public Case(int x, int y, CaseType t, string D)
        {
            X = x;
            Y = y;
            Type = t;
            Description = D;
            Random r = new Random(DateTime.Now.Millisecond);

            

            if (r.Next() % 10 > 5)
            {
                Items = new Potion("soin", "potion de soin", 1, 2, Potion.PotionType.Heal);// exemple
            }
             
            else
                Items = null;
        }
        public void StartFight()
        {

        }
    }
}





