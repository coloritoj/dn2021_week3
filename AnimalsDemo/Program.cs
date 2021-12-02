using System;
using System.Collections.Generic;
// Jeff said to kind of 'copy' what he did for this demo for today's lab.
// Today's lab IS due tomorrow.

namespace AnimalsDemo
{
    
    class Animal
    {
        //
        // Animal has one member:
        //      NumberOfCells
        //

        public int NumberOfCells;

        public Animal()
        {
            NumberOfCells = 0;
        }

        public Animal(int noCells)
        {
            NumberOfCells = noCells;
        }

        public override string ToString()
        {
            return $"This animal has {NumberOfCells} cells.";
        }

        public static List<Animal> Animals = new List<Animal>(); // The static word is key here
    }

    class Bird : Animal
    {
        //
        // Bird has two members:
        //      NumberOfCells (which it derives from Animal)
        //      LengthOfBeak
        //

        public int LengthOfBeak;

        public Bird() // When you first create a class of Bird, it first creates a class of Animal with a constructor
        {
            LengthOfBeak = 1;
        }

        public Bird(int loBeak, int noCells) : base(noCells) // I THINK what's happening here is that the int noCells for Bird (on the left) is deriving the noCells from the base (Animal) which is on the right
        {
            LengthOfBeak = loBeak;
        }

        public override string ToString()
        {
            return $"This bird has {NumberOfCells} cells and its beak is {LengthOfBeak} inches long.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Animal a1 = new Animal(1000);
            Animal.Animals.Add(a1);

            Animal a2 = new Animal(5000);
            Animal.Animals.Add(a2);

            Bird b1 = new Bird(20, 10000);
            Animal.Animals.Add(b1); // Bird is added to the same list of Animals

            foreach (Animal anim in Animal.Animals)
            {
                Console.WriteLine(anim); // When you don't have a ToString() it prints out the type.
            }
        }
    }
}
