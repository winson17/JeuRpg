using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuxRpg
{
    class Items
    {
        public string Name;
        public string Description;
        public float Value;
        public float Weight;


        public Items(string name, string desc, float v, float w)
        {
            Name = name;
            Description = desc;
            Value = v;
            Weight = w;
        }
        public void print()
        {
            Console.WriteLine(Name + " : " + Description);

        }
        public virtual void PickUp()
        {
            Console.WriteLine("vous avez ramassé : " + Name);
        }
        public virtual void Use()
        {
            Console.WriteLine("vous avez utilisé : " + Name);
        }
    }
}
