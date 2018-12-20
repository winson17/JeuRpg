using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class Ynov : ClassMonstre
    {
        public int Energie;

        public Ynov(string n) : base(n)
        {
            Energie = 10;
            Pv = 50;
            Force = 2;
            Taille = 1;
            Endurance = 20;
        }
        public int MakeSomeMagie()
        {
            Energie--;
            if(Energie <=0)
            {
                return 0;
            }
            return 5;

        }
        public override int Attack()
        {
            return MakeSomeMagie();
        }
    }
}
