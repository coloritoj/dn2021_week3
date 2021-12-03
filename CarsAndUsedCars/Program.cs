using System;
using System.Collections.Generic;

namespace CarsAndUsedCars
{
    class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public decimal Price;

        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0m;
        }

        public Car(string carMake, string carModel, int carYear, decimal carPrice)
        {
            Make = carMake;
            Model = carModel;
            Year = carYear;
            Price = carPrice;
        }

        public override string ToString()
        {
            return $"MAKE: {Make} | MODEL: {Model} | YEAR: {Year} | PRICE: ${Price}";
        }

        public static List<Car> carList = new List<Car>();

        public static void ListCars(List<Car> listOfCars)
        {
            for (int i = 0; i < listOfCars.Count; i++)
            {
                Console.WriteLine($"Vehicle {i + 1}... {listOfCars[i]}");
            }
        }

        public static void Remove(int carToRemove)
        {
            Car.carList.Remove(Car.carList[carToRemove]);
        }
    }

    class UsedCar : Car
    {
        public double Mileage;

        public UsedCar(string carMake, string carModel, int carYear, decimal carPrice, int carMileage) : base(carMake, carModel, carYear, carPrice)
        {
            Mileage = carMileage;
        }

        public override string ToString()
        {
            return $"MAKE: {Make} | MODEL: {Model} | YEAR: {Year} | PRICE: ${Price} | MILEAGE: {Mileage}";
        }

        public static void TradeIn(string tradeMake, string tradeModel, int tradeYear, decimal tradePrice, int tradeMileage)
        {
            UsedCar myTradeIn = new UsedCar(tradeMake, tradeModel, tradeYear, tradePrice, tradeMileage);
            Car.carList.Add(myTradeIn);
        }
    }

    class Program
    {
        static bool isValidNumber(List<Car> listOfCars, int entry)
        {            
            if (entry >= 0 && entry < listOfCars.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool isValidDecision(string decision)
        {
            if (decision == "trade")
            {
                return true;
            }
            else if (decision == "purchase")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Car carOne = new Car("Chevrolet", "Equinox", 2021, 29000);
            Car.carList.Add(carOne);

            Car carTwo = new Car("Chevrolet", "Traverse", 2022, 38500);
            Car.carList.Add(carTwo);

            Car carThree = new Car("Tesla", "Model 3", 2022, 32750);
            Car.carList.Add(carThree);

            UsedCar carFour = new UsedCar("Ford", "F-150", 2015, 29250, 85001);
            Car.carList.Add(carFour);

            UsedCar carFive = new UsedCar("Toyota", "Tacoma", 2014, 31000, 96723);
            Car.carList.Add(carFive);

            UsedCar carSix = new UsedCar("Jeep", "Compass", 2017, 18375, 160189);
            Car.carList.Add(carSix);

            Console.WriteLine("Welcome to Ranch Motors!");
            Console.Write("Would you like to trade-in your existing vehicle or go straight to purchasing a new one? (TRADE/PURCHASE): ");
            string carDecision = Console.ReadLine().ToLower();
            bool validDecision = isValidDecision(carDecision);

            while (validDecision == false)
            {
                Console.Write("Sorry, that was not a valid decision. What would you like to do? (TRADE/PURCHASE): ");
                carDecision = Console.ReadLine().ToLower();
                validDecision = isValidDecision(carDecision);
            }

            if (carDecision == "trade")
            {
                Console.WriteLine("\nIn order to trade-in your existing vehicle, we will need some information first...");

                Console.Write("Please enter the make of your vehicle: ");
                string tradeMake = Console.ReadLine();

                Console.Write("Please enter the model of your vehicle: ");
                string tradeModel = Console.ReadLine();

                Console.Write("Please enter the year of your vehicle: ");
                int tradeYear = int.Parse(Console.ReadLine());

                Console.Write("Please enter the price you are hoping to receive (no commaas): $");
                decimal tradePrice = decimal.Parse(Console.ReadLine());

                Console.Write("Please enter the mileage on your vehicle (no commas): ");
                int tradeMileage = int.Parse(Console.ReadLine());

                UsedCar.TradeIn(tradeMake, tradeModel, tradeYear, tradePrice, tradeMileage);
                Console.WriteLine($"\nThanks for trading in your {tradeMake} {tradeModel}!");
                Console.WriteLine("We will now list the vehicles (including your trade in) that are available for purchase.");
            }

            Console.WriteLine("\nHere is the list of vehicles available for sale:");
            Car.ListCars(Car.carList);

            Console.Write("\nPlease enter the number of the vehicle you wish to purchase: ");
            int indexOfVehiclePurchased = (int.Parse(Console.ReadLine()) - 1);
            bool validEntry = isValidNumber(Car.carList, indexOfVehiclePurchased);

            while (validEntry == false)
            {
                Console.Write("You did not enter a valid number. Please enter the number of the vehicle you wish to purchase: ");
                indexOfVehiclePurchased = (int.Parse(Console.ReadLine()) - 1);
                validEntry = isValidNumber(Car.carList, indexOfVehiclePurchased);
            }

            Console.WriteLine($"\nYou entered vehicle {indexOfVehiclePurchased + 1}. As a reminder, here are the details of the vehicle you are purchasing...");
            Console.WriteLine(Car.carList[indexOfVehiclePurchased]);
            Console.WriteLine("Our finance department will be in touch with you shortly regarding your purchase. Thank you!");

            Console.WriteLine("\nHere is an updated list of vehicles remaining. The vehicle you just purchased has been removed: ");
            Car.Remove(indexOfVehiclePurchased);
            Car.ListCars(Car.carList);
        }
    }
}

/* ----- TASK -----
 * Hold information about Car inventory using a collection of Car objectives, including a UsedCar subclass.
 * 
 * ----- WHAT WILL THE APPLICATION DO? -----
 * Display a set of at least 6 cars (at least 3 new and 3 used)
 * Let the user select one of the cars to purchase
 * Print out the details of the car they chose, remove it from the list, and print the whole list again
 * 
 * ----- BUILD SPECIFICATIONS -----
 * Create a class named Car (5 points) to store the data about a car. This class should contain: --- COMPLETE!
 * ... Data members for car details --- COMPLETE!
 * ...... A string for the make --- COMPLETE!
 * ...... A string for the model --- COMPLETE!
 * ...... An int for the year --- COMPLETE!
 * ...... A decimal for the price --- COMPLETE!
 * ... A no-arguments constructor that sets data members to default values (blanks or your choice) --- COMPLETE
 * ... A constructor with four arguments matching the order above --- COMPLETE!
 * ... A ToString() method returning a formatted string with the car details --- COMPLETE
 * 
 * Create a subclass of Car named UsedCar (3 points). UsedCar should contain: --- COMPLETE!
 * ... Data member for used car details: --- COMPLETE!
 * ...... A double for mileage --- COMPLETE!
 * ... Constructor: Takes five arguments and calls the four-argument constructor for Car and saves the mileage argument --- COMPLETE!
 * ... ToString(): Returns a formatted string with the used car details --- COMPLETE!
 * 
 * Create an instance of List<Car> that can hold instances of Car and any class derived from Car. Make this a PUBLIC STATIC member of Car!!! --- COMPLETE!
 * ... In your main, create at least three Car instances and at least three UsedCar instances and add these six instances to the list --- COMPLETE!
 * ... Add a public static method to Car called ListCars that loops through the list and prints out each member and its index in the list (hint: use a regular for loop, not a foreach, so you can print out the index) --- COMPLETE!
 * ... Add a public static method to Car called Remove which takes an integer parameter and removes the car whose index is that parameter --- COMPLETE!
 * 
 * In your Main, print out the list (by calling the ListCar method). Then ask the user which car they would like to buy, by number (the index of the car) --- COMPLETE!
 * Print our the details for the chosen car (think about how to print out this information: you'll access the item in the list by index and call Console.WriteLine()) --- COMPLETE! 
 * Remove the chosen car from the list --- COMPLETE!
 * List all the cars again --- COMPLETE!
 * 
 * ----- HINTS -----
 * Use the right access modifiers (public/private/protected) --- NOTE: Jeff said it doesn't really matter since we are using the ToString() method. Just use public for all of them.
 * You can use \t tab escape characters to line things up, or if you want to get fancier, look up text formatters
 * 
 * ----- EXTRA CHALLENGES -----
 * Think about other methods which might be useful for your Car, such as "BuyBack" where you can add a used car to the list. Implement them and modify your app to take advantage of them. --- COMPLETE!
 * Create an Admin mode which lets the user edit cars.
 * Provide search features:
 * ... View all cars of an entered make
 * ... View all cars of an entered year
 * ... View all cars of an entered price or less
 * ... View only used cars or view only new cars
 */