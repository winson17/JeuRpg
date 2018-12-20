using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class fille : ClassHero
    {
        public int Energie;

        public fille(string n) : base(n)
        {

            Energie = 10;
            Pv = 100;
            Force = 5;
            Taille = 1;
            Endurance = 85;
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

