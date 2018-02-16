using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Duck : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "Duck";
        }

        public string GetAnimalSound()
        {
            return "QUACK!";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
