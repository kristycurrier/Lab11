using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> listOfMovies = DefaultMovieList();

            Console.WriteLine($"There are {listOfMovies.Count} movies in this list");
            bool keepGoing = true;
            while (keepGoing)
                {
                GetCategoryPrintMovies(listOfMovies);
                keepGoing = KeepAskingForCategory();
            }
  
            Console.ReadKey();
        }

        public static bool KeepAskingForCategory()
        {
            bool validInput = false;
            bool keepGoing = true;
            while (validInput == false)
            {
                Console.WriteLine("Would you like to continue? (y/n)");
                string input = Console.ReadLine();
                if (input.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    keepGoing = true;
                    validInput = true;

                } else if (input.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    keepGoing = false;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please type y for yes or n for no");
                }
            }
            return keepGoing;
        }
        public static void GetCategoryPrintMovies(List<Movie> listOfMovies)
        {
            bool realCategory = false;
            while (realCategory == false)
            {
                Console.WriteLine("What category are you interested in? ");
                string movieCategory = Console.ReadLine();

                if (movieCategory.Equals("SciFi", StringComparison.OrdinalIgnoreCase))
                {
                    Movie.PrintSciFiMovies(listOfMovies);
                    realCategory = true;
                }
                else if (movieCategory.Equals("Fantasy", StringComparison.OrdinalIgnoreCase))
                {
                    Movie.PrintFantasyMovies(listOfMovies);
                    realCategory = true;
                }
                else if (movieCategory.Equals("Kids", StringComparison.OrdinalIgnoreCase))
                {
                    Movie.PrintKidsMovies(listOfMovies);
                    realCategory = true;
                }
                else
                {
                    Console.WriteLine("Sorry, that wasn't an option.  Choose between \"Kids\", \"Fantasy\" or \"SciFi\"");
                }
            }
        }

        public static List<Movie> DefaultMovieList()
        {
            List<Movie> movieList = new List<Movie>();

            movieList.Add(new Movie("Star Wars: A New Hope", "SciFi"));
            movieList.Add(new Movie("Harry Potter: Deathly Hallows Part 2", "Fantasy"));
            movieList.Add(new Movie("Moana", "Kids"));
            movieList.Add(new Movie("Finding Nemo", "Kids"));
            movieList.Add(new Movie("Planet of the Aps", "SciFi"));
            movieList.Add(new Movie("Dark Crystal", "Fantasy"));
            movieList.Add(new Movie("The Princess Bride", "Fantasy"));
            movieList.Add(new Movie("Incrdibles", "Kids"));
            movieList.Add(new Movie("The Lion King", "Kids"));
            movieList.Add(new Movie("Back To the Future", "SciFi"));

            return movieList;
        }
    }
}
