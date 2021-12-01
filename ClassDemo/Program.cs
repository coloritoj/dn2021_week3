using System;
using System.Collections.Generic;

namespace ClassDemo
{
    class Pen // When you omit an access modifier, by default it is set to private
    {
        public double Length;
        public string Color;
        public double InkLevel;
        public string PenType;

        public Pen(double length, string color, double inkLevel, string penType)
        {
            Length = length;
            Color = color;
            InkLevel = inkLevel;
            PenType = penType;
        }

        public void PrintPen()
        {
            Console.WriteLine($"Length: {Length}, Color: {Color}, Ink Level: {InkLevel}, Type: {PenType}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /* Pen firstPen = new Pen();
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
            thirdPen.PenType = "gel";*/

            Pen antoniosPen = new Pen(5, "green", 8.8, "fountain");




            Console.WriteLine("First pen:");
            // Console.WriteLine(firstPen.Length);
            // Console.WriteLine(firstPen.Color);
            //firstPen.PrintPen();

            Console.WriteLine("Second pen:");
            //secondPen.PrintPen();

            Console.WriteLine("Third pen:");
            //thirdPen.PrintPen();

            List<Pen> myPens = new List<Pen>();
            //myPens.Add(firstPen);
            //myPens.Add(secondPen);
            //myPens.Add(thirdPen);
            myPens.Add(antoniosPen);

            Console.WriteLine("Here are all the pens in the list:");
            foreach (Pen nextPen in myPens)
            {
                nextPen.PrintPen();
            }
        }
    }
}
