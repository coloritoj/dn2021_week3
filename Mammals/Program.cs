using System;

namespace Mammals
{
    class Mammal
    {
        public string TypeOfHair; // Generally when you are naming properties, you want to give it some kind of qualifier/quantifier such as "TypeOfx" or "NumberOfy"
        public int NumberOfTeeth;
    }

    class Cat : Mammal // The colon makes the class Cat inherit/derive from Mammal
    {
        public int RetractClawsCount;
    }

    class Dog : Mammal // Dog also inherits from Mammal
    {
        public int NumberOfTricks;
        public bool IsDomesticated;
    }

    // NOTE FROM JEFF: Inheritance isn't really used much anymore these days to write classes. The reason is because almost everything is database-driven these days.

    class Program
    {
        static void Main(string[] args)
        {
            Dog Nellie = new Dog();
            Nellie.NumberOfTricks = 3;
            Nellie.IsDomesticated = true;
            Nellie.TypeOfHair = "Soft and Long";
            Nellie.NumberOfTeeth = 20;

            Cat DonaldDuck = new Cat();
            DonaldDuck.RetractClawsCount = 0;
            DonaldDuck.TypeOfHair = "Soft and Short";
            DonaldDuck.NumberOfTeeth = 18;

            Cat MickeyMouse = new Cat();
            MickeyMouse.RetractClawsCount = 16;
            MickeyMouse.TypeOfHair = "Soft and Longhaired";
            MickeyMouse.NumberOfTeeth = 18;

            // NEW CONCEPT BELOW; unrelated to what's above
        }
    }
}
