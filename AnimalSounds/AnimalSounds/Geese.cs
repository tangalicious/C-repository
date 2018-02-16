using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Geese : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "Goose";
        }

        public string GetAnimalSound()
        {
            return "HONK!";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
