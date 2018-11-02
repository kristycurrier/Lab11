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

            Console.WriteLine("What category are you interested in? ");
            string movieCategory = Console.ReadLine();

            if (movieCategory == "SciFi")
            {
                Movie.PrintSciFiMovies(listOfMovies);
            }
            else if (movieCategory == "Fantasy")
            {
                Movie.PrintFantasyMovies(listOfMovies);
            }
            else if (movieCategory == "Kids")
            {
                Movie.PrintKidsMovies(listOfMovies);
            }
            else
            {
                Console.WriteLine("Sorry, that wasn't an option.  Choose between \"Kids\", \"Fantasy\" or \"SciFi\"");
            }



            Console.ReadKey();


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
