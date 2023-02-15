using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatureSim
{
    public enum SkinType
    {
        Feathers,
        Scales,
        Fur,
        Other
    }
    public class Creature
    {
        private string name;
        private int clawNumber;
        private SkinType skin;

        public string Name { get => name; set => name = value; }
        public SkinType Skin { get => skin; set => skin = value; }

        public Creature(string _name)
        {
            Name = _name;
        }
        //public Creature() { }

        public virtual void Move()
        {
            string output = $"{Name} moves!";
            Console.WriteLine(output);
           
        }
    }
}