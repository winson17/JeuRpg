using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class MalaiseV : ClassMonstre
    {
        public int Energie;
        public MalaiseV(string n) : base(n)
        { 
            Pv = 20;
            Force = 10;
            Endurance = 70;
            Taille = 1;
        }
        public int MakeSomeMagie()
        {
            Energie--;
            if (Energie <= 0)
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
