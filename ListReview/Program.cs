using System;
using System.Collections.Generic;

namespace ListReview
{
    class Program
    {

        // This function takes a list and return a single integer
        static int Average(List<int> nums)
        {
            int accum = 0;
            foreach (int next in nums)
            {
                accum += next;
            }
            return accum / nums.Count;
        }

        // This function takes a single number and creates and fills a list
        static List<int> FillList(int count)
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < count; i++)
            {
                myList.Add(i * 2);
            }
            return myList;
        }

        // This function prints out a list
        static void PrintList(List<int> myList)
        {
            Console.WriteLine($"\nThis list has {myList.Count}. Here are the items: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"Index {i} contains {myList[i]}");
            }
        }

        // This function increments each item in the list
        static void ChangeList(List<int> nums) //Remember that if we pass in a List, we are changing the actual list we passed in. This is NOT a copy of the list. Therefore we DON'T need to return anything in this example.
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] = nums[i] + 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Create a list!");
            List<int> sizes = new List<int>() { 5, 10, 15, 20 }; //Normally you don't initialize a list like this; this was merely an example. Normally lists get pulled from a database.

            Console.WriteLine("Let's get the average");
            Console.WriteLine(Average(sizes));

            Console.WriteLine("\nLet's fill a list and print it!");
            List<int> theList = FillList(6);
            PrintList(theList);

            Console.WriteLine("\nLet's change the items in the list and print it!");
            ChangeList(theList);
            PrintList(theList);

            Console.WriteLine("\nLet's reverse the list!");
            theList.Reverse(); // This changes the original list we had
            PrintList(theList);

            Console.WriteLine("\nLet's manually change a couple items");
            theList[2] = 50;
            theList[4] = 100;
            theList.Add(101);
            theList.RemoveAt(3); // This removes the value of whatever is/was at index 3. In this case, the value of "5" was originally at index 3.
            PrintList(theList);

            Console.WriteLine("\nLet's sort the list!");
            theList.Sort(); // This sort the list of numbers from smallest to largest
            PrintList(theList);

            Console.WriteLine("\nLet's remove 50 from it!");
            theList.Remove(50); // This is different than RemoveAt. Remove will simply go find the first instance of whatever you put in the parenthesis and remove it.
            PrintList(theList);
        }
    }
}
