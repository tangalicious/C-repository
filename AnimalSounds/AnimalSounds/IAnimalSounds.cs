using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{

    //Interfaces allow you to show commonalities between different classes without affecting or addressing their essential qualities. 
    interface IAnimalSounds
    {
        string GetAnimalName();
        string ToPrint();
        string GetAnimalSound();
    }
}
