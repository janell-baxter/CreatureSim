using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatureSim
{
    public class Fox: Creature
    {
        public Fox(string _name) : base(_name) { }
        public override void Move()
        {
            base.Move();
            Console.WriteLine( $"{Name} dances slickly across the the space.");

        }
    }
}