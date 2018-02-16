using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Rooster : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "Rooster";
        }

        public string GetAnimalSound()
        {
            return "COCKADOODLE DOO";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
