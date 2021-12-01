using System;
using System.Collections.Generic;
​
namespace ClassDemoWithAntonio
{
    class Pen // When you omit an access modifier, by default it is set to private
    {
        private double Length;
        private string Color;
        private double InkLevel;
        private string PenType;
​
        public Pen(double length, string color, double inkLevel, string penType)
        {
            Length = length;
            Color = color;
            InkLevel = inkLevel;
            PenType = penType;
        }
​
        public void PrintPen()
        {
            Console.WriteLine($"Length: {Length}, Color: {Color}, Ink Level: {InkLevel}, Type: {PenType}");
        }
​
        public void UseInk()
        {
            InkLevel -= 0.1;
        }
    }
​
​
    class Program
    {
        static void Main(string[] args)
        {
            // initialize pen list
            List<Pen> myPens = new List<Pen>()
            {
                new Pen(5,"yellow",3.0,"fountain"),
                new Pen(5.0, "green", 99.0, "fancy"),
                new Pen(5, "blue", 9.2, "gel")
            };
​
            Console.WriteLine("Print out initial values");
            myPens[0].PrintPen();
​
            Console.WriteLine("");
​
            Console.WriteLine("Now let's UseInk 10 times.");
            for (int i = 0; i < 10; i++)
            {
                myPens[0].UseInk();
            }
​
            Console.WriteLine("\nPrint out values after using ink:");
​
            myPens[0].PrintPen();
​
        }
    }
}