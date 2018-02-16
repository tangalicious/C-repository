using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Pig : IAnimalSounds
    {
        //Pig goes "OINK"
        public string GetAnimalName()
        {
            return "Pig";
        }

        public string GetAnimalSound()
        {
            return "OINK!";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
