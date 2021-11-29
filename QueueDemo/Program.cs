using System;
using System.Collections.Generic;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();

            people.Enqueue("Sally");
            people.Enqueue("Fred");

            string next = people.Dequeue(); // Should print Sally
            Console.WriteLine(next);

            people.Enqueue("Sam");
            people.Enqueue("Frank");

            next = people.Dequeue();
            Console.WriteLine(next); // Should print Fred

            next = people.Dequeue();
            Console.WriteLine(next); // Should print Sam

            next = people.Dequeue();
            Console.WriteLine(next); // Should print Frank
        }
    }
}
