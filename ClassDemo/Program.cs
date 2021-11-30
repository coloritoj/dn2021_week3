using System;
using System.Collections.Generic;

namespace ClassDemo
{
    class Pen
    {
        public double Length;
        public string Color;
        public double InkLevel;
        public string PenType;

        public void PrintPen()
        {
            Console.WriteLine($"Length: {Length}, Color: {Color}, Ink Level: {InkLevel}, Type: {PenType}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Pen firstPen = new Pen();
            firstPen.Length = 5;
            firstPen.Color = "red";
            firstPen.InkLevel = 9.2;
            firstPen.PenType = "gel";

            Pen secondPen = new Pen();
            secondPen.Length = 6;
            secondPen.Color = "blue";
            secondPen.InkLevel = 0.5;
            secondPen.PenType = "ballpoint";

            Pen thirdPen = new Pen();
            thirdPen.Length = 5;
            thirdPen.Color = "blue";
            thirdPen.InkLevel = 9.2;
            thirdPen.PenType = "gel";

            Console.WriteLine("First pen:");
            // Console.WriteLine(firstPen.Length);
            // Console.WriteLine(firstPen.Color);
            firstPen.PrintPen();

            Console.WriteLine("Second pen:");
            secondPen.PrintPen();

            Console.WriteLine("Third pen:");
            thirdPen.PrintPen();

            List<Pen> myPens = new List<Pen>();
            myPens.Add(firstPen);
            myPens.Add(secondPen);
            myPens.Add(thirdPen);

            Console.WriteLine("Here are all the pens in the list:");
            foreach (Pen nextPen in myPens)
            {
                nextPen.PrintPen();
            }
        }
    }
}
