using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreatureSim
{
    public class Planet
    {
        List<Creature> Creatures= new List<Creature>()
        {
            new Phoenix("Petra the Phoenix"){Skin = SkinType.Feathers },
            new Dragon("Torch the Dragon"){Skin = SkinType.Scales },
            new Fox("Tails the Fox"){Skin = SkinType.Fur }

        } ;

        public void Run()
        {
            foreach (Creature creature in Creatures)
            {
                Console.WriteLine(creature.Name);
                creature.Move();
               
                if (creature is IFly)
                {
                    //something special because it can fly
                    IFly c = (IFly)creature;
                    c.Soar();
                }
               
            }
        }

    }
}