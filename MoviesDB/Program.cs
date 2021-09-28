using System;

namespace MoviesDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var rotk = new Movie();
            rotk.Title = "The Lord of the Rings: Return of the King";
            rotk.RunTimeConvert(3, 21);
            var message = rotk.Print();
            Console.WriteLine(message);

            var t2t = new Movie();
            t2t.Title = "The Lord of the Rings: The Two Towers";
            t2t.RunTimeConvert(2, 59);
            message = t2t.Print();
            Console.WriteLine(message);

            var fotr = new Movie();
            fotr.Title = "The Lord of the Rings: The Fellowship of the Ring";
            fotr.RunTimeConvert(2, 58);
            message = fotr.Print();
            Console.WriteLine(message);

            var jaws = new Movie();
            jaws.Title = "Jaws";
            jaws.RunTimeConvert(2, 4);
            message = jaws.Print();
            Console.WriteLine(message);

            var labyrinth = new Movie();
            labyrinth.Title = "Labyrinth";
            labyrinth.RunTimeConvert(1, 41);
            message = labyrinth.Print();
            Console.WriteLine(message);
        }
    }
}
