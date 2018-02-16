using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class BIRDS : IAnimalSounds
    {
        //Birds go "CHIRP"
        public string GetAnimalName()
        {
            return "Bird";
        }

        public string GetAnimalSound()
        {
            return "WE ARE LEGION. DO NOT PROVOKE US";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
