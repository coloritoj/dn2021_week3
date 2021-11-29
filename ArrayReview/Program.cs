using System;

//ONE CRITICAL THING TO REMEMBER ABOUT ARRAYS IS THAT THEY CANNOT BE CHANGED (SIZE) ONCE CREATED!

namespace ArrayReview
{
    class Program
    {
        // This function takes an array and returns a single integer (a single value (whether it's an int, string, etc.) is also known as a "scalar").
        static int Average(int[] nums)
        {
            int accum = 0; //Accum is the same thing as sum; this is just old language

            foreach(int next in nums)
            {
                accum += next;                
            }
            return accum / nums.Length;
        }

        // This function takes a count, creates an array of that size, and fills it with numbers
        static int[] FillArray(int count)
        {
            int[] myArray = new int[count];
            // Example: An array of size 5 we will fill with 0, 1, 2, 3, 4
            // Next example: We increment by 2 each time (myArray[i] = i * 2)

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i * 2;
            }
            return myArray;
        }

        // This function prints out what's in an array
        static void PrintArray(int[] theArray)
        {
            Console.WriteLine("\nHere's what is in the array:");
            for (int i = 0; i < theArray.Length; i++)
            {
                Console.WriteLine($"Index {i} contains {theArray[i]}");
            }
        }

        // This function increments each item in the array
        // For example, pass in { 5, 10, 15, 20 }... this function will modify that array to { 6, 11, 16, 21 }
        static void ChangeArray(int[] nums) //When you use a function and pass in an array, you are actually changing/working with the array you passed in. You are NOT creating a copy of it.
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] + 1; // Ex: Takes in 5 from nums[i], adds 1 to it, and then puts that back in nums[i]
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Create an array!");
            int[] sizes = new int[] { 5, 10, 15, 20 };

            Console.WriteLine("\nHere's what is in the array:");
            for (int i = 0; i < sizes.Length; i++)
            {
                Console.WriteLine($"Index {i} contains {sizes[i]}");
            }

            Console.WriteLine("\nLet's count down from the end to the beginning");
            for (int i = sizes.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Index {i} contains {sizes[i]}");
            }

            Console.WriteLine("\nLet's use a foreach loop");
            foreach (int item in sizes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCreate another array without initialization");
            int[] numbers = new int[4]; //Doing this creates 4 slots in memory and initializes them all to 0
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            int avg = Average(numbers);
            Console.WriteLine($"The average is {avg}");

            Console.WriteLine("\nLet's call our FillArray method to create an array!");
            int[] moreNums = FillArray(5);
            PrintArray(moreNums);

            Console.WriteLine("\nCreate an array and pass it to our ChangeArray method");
            int[] toChange = new int[] { 5, 10, 15, 20 };
            ChangeArray(toChange);
            PrintArray(toChange);
            
        }
    }
}
