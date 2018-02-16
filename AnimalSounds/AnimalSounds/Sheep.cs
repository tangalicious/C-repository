using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Sheep : IAnimalSounds
    {
        //Sheep goes "BAAA"
        public string GetAnimalName()
        {
            return "Sheep";
        }

        public string GetAnimalSound()
        {
            return "BAAA";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
