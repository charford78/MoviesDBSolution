using System;

namespace MoviesDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var rotk = new Movie("The Lord of the Rings: Return of the King", "fantasy", "PG-13",
                2003, Movie.RunTimeConvert(3, 21), "Peter Jackson");
            rotk.Print();
            
            var t2t = new Movie("The Lord of the Rings: The Two Towers", "fantasy", "PG-13",
                2002, Movie.RunTimeConvert(2, 59), "Peter Jackson");
            t2t.Print();
            
            var fotr = new Movie("The Lord of the Rings: The Fellowship of the Ring", "fantasy",
                "PG-13", 2001, Movie.RunTimeConvert(2, 58), "Peter Jackson");
            fotr.Print();
            
            var jaws = new Movie("Jaws", "horror", "PG", 1975, Movie.RunTimeConvert(2, 4),
                "Steven Spielberg");
            jaws.Print();
            
            var labyrinth = new Movie("Labyrinth", "fantasy", "PG", 1986, 
                Movie.RunTimeConvert(1, 41), "Jim Henson");
            labyrinth.Print();
        }
    }
}
