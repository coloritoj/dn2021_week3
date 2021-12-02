using System;

// This is like an extended version of the Mammals project from before
namespace Mammals2
{
    class Mammal
    {
        public string TypeOfHair; // Generally when you are naming properties, you want to give it some kind of qualifier/quantifier such as "TypeOfx" or "NumberOfy"
        public int NumberOfTeeth;

        public Mammal(string toHair, int noTeeth) // the "no" means "number of"
        {
            TypeOfHair = toHair;
            NumberOfTeeth = noTeeth;
        }
    }

    class Cat : Mammal // The colon makes the class Cat inherit/derive from Mammal
    {
        public int RetractClawsCount;

        public Cat(int countClaws, string toHair, int noTeeth) : base(toHair, noTeeth) // The : base (toHair, noTeeth) is calling the Mammal constructor above
        {
            RetractClawsCount = countClaws;
        }
    }

    class Dog : Mammal // Dog also inherits from Mammal
    {
        public int NumberOfTricks;
        public bool IsDomesticated;

        public Dog() : base("none selected", 32) // This is a shortcut/alternative to what we did for the cat constructor above with the :base ... This is hardcoding the values for TypeOfHair and NumberOfTeeth
        {
            NumberOfTricks = 0;
            IsDomesticated = true;
        }
    }

    // NOTE FROM JEFF: Inheritance isn't really used much anymore these days to write classes. The reason is because almost everything is database-driven these days.

    class Program
    {
        static void Main(string[] args)
        {
            Dog Nellie = new Dog();
            Console.WriteLine("Before we set anything, let's print everything out");
            Console.WriteLine(Nellie.NumberOfTricks);
            Console.WriteLine(Nellie.NumberOfTeeth);
            Console.WriteLine(Nellie.TypeOfHair);
            Console.WriteLine(Nellie.IsDomesticated);
            Console.WriteLine("\n\n");


            Nellie.NumberOfTricks = 3;
            Nellie.IsDomesticated = true;
            Nellie.TypeOfHair = "Soft and Long";
            Nellie.NumberOfTeeth = 20;

            Cat DonaldDuck = new Cat(0, "Soft and Short", 18);

            Cat MickeyMouse = new Cat(16, "Soft and Longhaired", 18);

            // NEW CONCEPT BELOW; unrelated to what's above
        }
    }
}

