using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{

    //Interfaces allow you to show commonalities between different classes without affecting or addressing their essential qualities. 
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            BIRDS birb = new BIRDS();
            Cat kitty = new Cat();
            Cow spot = new Cow();
            Duck Donald = new Duck();
            Geese Henry = new Geese();
            Horse James = new Horse();
            Pig Bacon = new Pig();
            Rooster Richard = new Rooster();
            Sheep Mary = new Sheep();
            Turkey Gary = new Turkey();
            Clarinet Clarence = new Clarinet();

            IAnimalSounds[] animals =
            {
                dog, birb, kitty, spot, Donald, Henry, James, Bacon, Richard, Mary, Gary, Clarence
            };

            foreach(IAnimalSounds animal in animals) {
                string animalName = animal.GetAnimalName();
                string animalSound = animal.GetAnimalSound();
                string message = $"A(n) {animalName} says {animalSound}.";
                Console.WriteLine(message);
            }

            Console.ReadKey();

            //Interfaces allow you to show commonalities between different classes without affecting or addressing their essential qualities. 
        }
    }
}
