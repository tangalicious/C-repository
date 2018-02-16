using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Horse : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "Horse";
        }

        public string GetAnimalSound()
        {
           return "NEIGH!";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
