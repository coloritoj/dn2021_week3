using System;
using System.Collections.Generic;

namespace MovieDatabase
{
    class Movie
    {
        private string Title;
        private string Category;
        private int Runtime;
        private int ReleaseYear;

        // Constructors get called automatically when you make an instance of a class. Constructors always share the same name as the class.
        public Movie(string movieTitle, string movieCategory, int movieRuntime, int movieReleaseYear)
        {
            Title = movieTitle;
            Category = movieCategory;
            Runtime = movieRuntime;
            ReleaseYear = movieReleaseYear;
        }

        public void PrintMovie()
        {
            Console.WriteLine($"Title: {Title}, Category: {Category}, Runtime: {Runtime} minutes, Release Year: {ReleaseYear}");
        }

        public string GetMovieCategory()
        {
            return Category;
        }
    }

    class Program
    {
        static bool IsValidCategory(string category)
        {
            if (category == "animated")
            {
                return true;
            }
            else if (category == "drama")
            {
                return true;
            }
            else if (category == "horror")
            {
                return true;
            }
            else if (category == "scifi")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string SwitchStatement(string entry)
        {
            switch (entry)
            {
                case "1":
                    entry = "animated";
                    break;
                case "2":
                    entry = "drama";
                    break;
                case "3":
                    entry = "horror";
                    break;
                case "4":
                    entry = "scifi";
                    break;
            }
            return entry;
        }

        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie("Return of the Jedi", "scifi", 120, 1982));
            movieList.Add(new Movie("The Martian", "scifi", 125, 2015));
            movieList.Add(new Movie("Wolf of Wall Street", "drama", 180, 2013));
            movieList.Add(new Movie("The Big Short", "drama", 176, 2015));
            movieList.Add(new Movie("The Conjuring", "horror", 122, 2013));
            movieList.Add(new Movie("The Conjuring 2", "horror", 133, 2015));
            movieList.Add(new Movie("The Force Awakens", "scifi", 134, 2015));
            movieList.Add(new Movie("Finding Nemo", "animated", 115, 2002));
            movieList.Add(new Movie("Child's Play", "horror", 120, 1980));
            movieList.Add(new Movie("Pocahontas", "animated", 89, 1994));

            string goAgain = "";
            do
            {
                Console.WriteLine("Here are the list of categories available and their corresponding codes...");
                Console.WriteLine("ANIMATED = 1");
                Console.WriteLine("DRAMA = 2");
                Console.WriteLine("HORROR = 3");
                Console.WriteLine("SCIFI = 4");

                Console.Write("\nWhat category would you like to search for? (ANIMATED/DRAMA/HORROR/SCIFI): ");
                string userCategory = Console.ReadLine().ToLower();

                userCategory = SwitchStatement(userCategory);

                while (IsValidCategory(userCategory) == false)
                {
                    Console.Write("That was an invalid category. What category would you like to search for? (ANIMATED/DRAMA/HORROR/SCIFI): ");
                    userCategory = Console.ReadLine().ToLower();
                    userCategory = SwitchStatement(userCategory);
                }

                Console.WriteLine($"Here are all the movies found within the {userCategory} category...");

                foreach (Movie film in movieList)
                {
                    if (film.GetMovieCategory() == userCategory)
                    {
                        film.PrintMovie();
                    }
                }

                Console.Write("\nWould you like to perform another search? (YES/NO): ");
                goAgain = Console.ReadLine().ToLower();
            } while (goAgain == "yes");

            Console.WriteLine("The program will now terminate. Goodbye!");
        }
    }
}

/* ----- WHAT WILL THE APPLICATION DO? -----
 * Stores a list of 10 movies and displays them by category.
 * User can enter any of the following categories to display the films in the list that match the category: animated, drama, horror, scifi.
 * After the list is displayed, the user is asked if he or she wants to continue. If no, the program ends.
 * 
 * ----- BUILD SPECIFICATIONS -----
 * Build a Movie class with two private fields: title and category. Both of these fields should be strings.
 * The class should also provide a constructor that accepts a title and category as parameters and uses the values passed in to initialize the fields.
 * ... 1 POINT: Class has proper fields of correct type --- COMPLETE
 * ... 1 POINT: Class has properties for each field --- COMPLETE
 * ... 1 POINT: Class has constructor --- COMPLETE
 * 
 * In your Main, create a List<Movie> and store at least 10 movies there. You can use literals to construct the movies. Make sure to have a mixture of categories.
 * ... 1 POINT: Program constructs list properly --- COMPLETE
 * ... 1 POINT: Program puts at least 10 properly instantiated movies into the list --- COMPLETE
 * 
 * When the user enters a category, the program should read through all of the movies in the list and display a line for any movie whose category matches the category entered by the user
 * ... 1 POINT: Program takes user input correctly --- COMPLETE
 * ... 1 POINT: Program gives explicity feedback if user enters invalid category --- COMPLETE
 * ... 1 POINT: Program iterates through list validly --- COMPLETE
 * ... 1 POINT: Program only outputs if movie matches category --- COMPLETE
 * 
 * Program loops if user wants to continue
 * ... 1 POINT: Program loops back to ask category again based on user input --- COMPLETE
 * 
 * ----- HINTS -----
 * Don't overthink this! Think about how you would do this in real life if you work at a video store and you have a stack of movies.
 * If somebody wants to see which movies in that stack belong to a particular category, what would you do? If they ask for a list of movies how many times do you loop through the stack?
 * 
 * ----- EXTRA CHALLENGES -----
 * Standardize the category codes by displaying a menu of categories and having the user select the category by number rather than entering the name --- COMPLETE
 * Display the movies for the selected category in alphabetical order --- DID NOT COMPLETE
 * Expand the information in your movie class: run time in minutes, year released, etc. Display the additional information when listing movies. --- COMPLETE
 */
