using System;
using System.Collections.Generic;

namespace MovieList_Jeff
{
    class Movie
    {
        private string Title;
        private string Category;

        public Movie (string _Title, string _Category)
        {
            Title = _Title;
            Category = _Category;
        }

        public string GetTitle()
        {
            return Title;
        }

        public string GetCategory()
        {
            return Category;
        }

        public override string ToString() // He said don't worry about the mechanics of how this works quite yet. This is just one of those "shortcuts/tricks" he's giving us. He will explain later what this does.
        {
            return $"{Title} ({Category})";
        }

        public static List<Movie> Movies = new List<Movie>(); // This gives the entire class a list
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>(); // Because we added the public static List<Movie> Movies above, we could technically get rid of this...
            // ...We would then write it as Movie.Movies.Add(new Movie("Star Wars: A New Hope", "Sci Fi"));
            Movie mov1 = new Movie("The Godfather", "Drama");
            movies.Add(mov1);

            mov1 = new Movie("Black Panther", "Superhero"); // mov1 is just being used to add the next movie to the list; it can be used over and over (technically you don't even need it)
            movies.Add(mov1);

            mov1 = new Movie("Avengers: Endgame", "Superhero");
            movies.Add(mov1);

            // For teaching purposes he switched to this, but the 3 movies above are also in the list (the way above is just different, not "wrong"). He prefers the way below.
            movies.Add(new Movie("Toy Story 2", "Animated"));
            movies.Add(new Movie("Casablanca", "Drama"));
            movies.Add(new Movie("The Thing", "Thriller"));
            movies.Add(new Movie("Big Trouble in Little China", "Sci Fi"));
            movies.Add(new Movie("Star Wars: A New Hope", "Sci Fi"));

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine($"There are {movies.Count} movies in this list");
            Console.Write("What category are you interested in?: ");
            string category = Console.ReadLine();

            int found = 0;
            foreach (Movie mov in movies)
            {
                if (mov.GetCategory() == category)
                {
                    found++;
                    Console.WriteLine(mov); // Remember about the override ToString() is what's making this work. He will explain later what that does.
                }
            }

            if (found == 0)
            {
                Console.WriteLine("Sorry we don't have any movies in that category.");
            }

            /* foreach (Movie mov in movies)
            {
                Console.WriteLine(mov); // If we didn't have the override ToString() function above, this would just print out the name of the class for each movie. The override ToString() is what makes this work.
                //Console.WriteLine(mov.GetTitle()); This is another way to get the title
            } */
        }
    }
}
