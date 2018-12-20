using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class RER : ClassMonstre
    {
        public int Energie;

        public RER(string n) : base(n)
        {
            Energie = 10;
            Pv = 150;
            Force = 75;
            Endurance = 85;
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
  

