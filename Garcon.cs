using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class Garcon : ClassHero
    {
        public int Energie;

        public Garcon(string n) : base(n)
        {
            Energie = 15;
            Pv = 100;
            Force = 100;
            Taille = 1;
            Endurance = 75;
        }
        public int MakeSomePunch()
        {
            Endurance--;
            if (Endurance <= 0)
            {
                return 0;
            }
            return 5;

        }
        public override int Attack()
        {
            return MakeSomePunch();
        }

    }
}
