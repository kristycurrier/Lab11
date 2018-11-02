using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Movie
    {
        private string Title { get; set; }
        private string Category { get; set; }

        public Movie (string title, string category )
        {
            Title = title;
            Category = category;
        }

        public static void PrintSciFiMovies (List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie.Category == "SciFi")
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }

        public static void PrintKidsMovies(List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie.Category == "Kids")
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }

        public static void PrintFantasyMovies(List<Movie> movieList)
        {
            foreach (var movie in movieList)
            {
                if (movie.Category == "Fantasy")
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }
    }
}
