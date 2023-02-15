using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatureSim
{
    public class Phoenix: Creature, IFly
    {
        public Phoenix(string _name) : base(_name) { }

        void IFly.Soar()
        {
            //throw new NotImplementedException();
        }
    }
}