using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{

    class Clarinet : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "clarinet";
        }

        public string GetAnimalSound()
        {
            return "NOISEY! NOISEY! NOISEY!";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
