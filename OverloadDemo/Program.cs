using System;
// C# looks at the parameters to determine if a method overload already exists. It doesn't care about return types, only the parameters passed in.
namespace OverloadDemo
{

    class Rectangle
    {
        private double Width;
        private double Height;

        // Default constructor (this name means "no parameters")
        public Rectangle()
        {
            Width = 10;
            Height = 10;
        }

        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }

        public Rectangle (string W, string H)
        {
            Width = double.Parse(W);
            Height = double.Parse(H);
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {

        static void PrintSomething()
        {
            Console.WriteLine("Nothing to print");
        }

        static void PrintSomething(string text)
        {
            Console.WriteLine($"The string is {text}");
        }

        static void PrintSomething(int number) // This is a separate function from what's above. This is called NAME OVERLOADING. More specifically, this example is FUNCTION OVERLOADING or METHOD OVERLOADING.
        {
            Console.WriteLine($"The integer is {number}");
        }

        static void PrintSomething(bool tf) // This is also a separate function from what's above. This is another overload.
        {
            Console.WriteLine($"The bool is {tf}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // From a technical sense, there's really a BUNCH of Console.WriteLines that take in different arguments. It just gives the ILLUSION of there being just "one" Console.WriteLine...
            Console.WriteLine(3);
            Console.WriteLine(true);

            PrintSomething("Hello"); // This calls the PrintSomething(string) function
            PrintSomething(3); // This calls the PrintSomething(int) function
            PrintSomething(true); // This calls the PrintSomething(bool) function
            PrintSomething(); // This calls the PrintSomething() function

            Rectangle rect1 = new Rectangle(10.0, 20.0);
            Console.WriteLine(rect1.GetArea()); // Expecting 200

            Rectangle rect2 = new Rectangle();
            Console.WriteLine(rect2.GetArea()); // Expecting 100

            Rectangle rect3 = new Rectangle("50.0", "60.0");
            Console.WriteLine(rect3.GetArea()); // Expecting 3000 -- Note: This one is taking in 'doubles' written as strings
        }
    }
}
