using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatureSim
{
    public class Dragon: Creature, IFly
    {
        public Dragon(string _name): base(_name) { }

        void IFly.Soar()
        {
            //what happens when method is called
            //throw new NotImplementedException();
        }
    }
}