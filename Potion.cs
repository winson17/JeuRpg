using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class Potion : Items
    {
        public enum PotionType { Heal, Defence, Attack }

        public PotionType Type;

        public Potion(string name, string desc, float v, float w, PotionType t)
            : base(name, desc, v, w)
        {
            Type = t;
        }

        public override void PickUp()
        {
            base.PickUp();
            Console.WriteLine("vous avez une nouvelle potion");
        }
        public override void Use()
        {
            base.Use();
            Console.WriteLine("vous avez utilisé une nouvelle potion");
        }
    }
}
