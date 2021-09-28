using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesDB
{
    class Movie
    {
        private static int NextId { get; set; } = 1;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; } = "PG";
        public int Released { get; set; } // year only
        public int RuntimeInMinutes { get; set; }
        public string Director { get; set; }

        public static int RunTimeConvert(int hrs, int mins)
        {
            return (hrs * 60) + mins;
        }
        
        public void Print()
        {
            Console.WriteLine($"{Id}");
            Console.WriteLine($"The movie {this.Title} is a {Genre} movie with a " +
                $"rating of {Rating} and has a runtime of {this.RuntimeInMinutes} minutes." +
                $"It was released in the year {Released} and was directed by {Director}.");
            Console.WriteLine("");
        }

        public Movie() { }

        public Movie(string title, string genre, string rating, int released,
                    int runtimeinminutes, string director)
        {
            this.Id = NextId++;
            this.Title = title;
            this.Genre = genre;
            this.Rating = rating;
            this.Released = released;
            this.RuntimeInMinutes = runtimeinminutes;
            this.Director = director;
        }
    }
}
