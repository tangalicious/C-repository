﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    class Cat : IAnimalSounds
    {
        public string GetAnimalName()
        {
           return "Cat";
        }

        public string GetAnimalSound()
        {
            return "MEOW!";
        }

        public string ToPrint()
        {
            throw new NotImplementedException();
        }
    }
}
