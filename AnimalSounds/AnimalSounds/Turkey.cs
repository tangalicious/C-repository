using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Turkey : IAnimalSounds
    {
        public string GetAnimalName()
        {
            return "Turkey";
        }

        public string GetAnimalSound()
        {
            return "My name is Gary and I am a person. I implore you to stop slaughtering my species by the millions";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
