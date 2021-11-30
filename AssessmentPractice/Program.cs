using System;
using System.Collections.Generic;

namespace AssessmentPractice
{
    class Program
    {

        // Function that takes an array of integers, adds them up, doubles that sum, and returns it

        static int SumDouble(int[] myArray)
        {
            // Create a variable that will hold the sum
            // Loop through the array, adding the numbers in the array to the sum
            // Return the sum times two

            int sumOfArray = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sumOfArray += myArray[i];
            }

            return sumOfArray * 2;
        }

        // Function that takes an array of integers, and returns a list of integers filled with the array values

        static List<int> ArrayToList(int[] myArray)
        {
            List<int> myList = new List<int>();

            foreach (int num in myArray)
            {
                myList.Add(num);
            }

            return myList;
        }

        // Pass in an array such as [2, 4, 6, 8] and an integer such as 3
        // The function will return the item that has index 3 (in this case, 8)

        // Another example: Pass in an array such as [5, 10, 15, 20] and integer 2... will return 15
        // Yet another example: Pass in an array such as [5, 10, 15, 20] and integer 0... will return 5

        // To practice try/catch, if the number is outside the bounds of the array, return -1

        static int GetItem(int[] myArray, int index) // This runs very slow relative to the BetterGetItem() function below. Basically there's a lot of stuff going on behind the scenes that makes it run slow.
        {
            try
            {
                return myArray[index];
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        static int BetterGetItem(int[] myArray, int index)
        {
            if (index >= 0 && index < myArray.Length) // This is much faster than a try/catch
            {
                return myArray[index];
            }
            else
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = new int[] { 28, 99, 324, 1000 };
            Console.WriteLine(SumDouble(nums));
            List<int> listTest = ArrayToList(nums);

            foreach (int num in listTest)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\nTest out our GetItem function:");
            Console.WriteLine(GetItem(nums, 0));
            Console.WriteLine(GetItem(nums, 2));
            Console.WriteLine(GetItem(nums, 10));

            Console.WriteLine("\nTest out our BetterGetItem function:");
            Console.WriteLine(BetterGetItem(nums, 0));
            Console.WriteLine(BetterGetItem(nums, 2));
            Console.WriteLine(BetterGetItem(nums, 10)); // Note: For the assessment today, we need to use the try/catch

            Console.WriteLine("\nDictionary pair types");
            Dictionary<string, int> dictionaryTest = new Dictionary<string, int>();
            dictionaryTest["one"] = 1;
            dictionaryTest["two"] = 2;
            dictionaryTest["three"] = 3;

            foreach (var pair in dictionaryTest)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }
    }
}
