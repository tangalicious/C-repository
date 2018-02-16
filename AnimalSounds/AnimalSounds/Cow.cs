using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Cow : IAnimalSounds
    {
        //Cow goes "MOOO"
        public string GetAnimalName()
        {
            return "Cow";
        }

        public string GetAnimalSound()
        {
            return "MOOO";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
