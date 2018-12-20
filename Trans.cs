using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class Trans : ClassHero
    {
        public int Energie; 

        public Trans(string n) : base(n)
        {
            Energie = 12;
            Pv = 80;
            Force = 90;
            Taille = 1;
            Endurance = 85;
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
