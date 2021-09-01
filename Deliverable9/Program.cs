using System;
using System.Collections.Generic;
using System.Linq;

namespace Deliverable9
{
    class Program
    {
        public class Movie
        {
            private string _title { get; set; }
            private string _category { get; set; }
            public Movie(string Title, string Category)
            {


                _title = Title;
                _category = Category;
            }

            public string Title
            {
                get
                {
                    return _title;
                }
            }
            public string Category
            {
                get
                {
                    return _category;
                }
            }

        }
        static void Continue()
        {
            bool programContinue = true;
            string userContinue = "";

            Console.Write("Would you like to continue (y/n)? ");
            userContinue = Console.ReadLine().ToLower();

            if (userContinue == "y")
            {
                programContinue = true;
            }
            else if (userContinue == "n")
            {
                Console.WriteLine("Goodbye!");
                programContinue = false;
                System.Environment.Exit(1);
            }
        }

        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Spirited Away", "animated"));
            movies.Add(new Movie("Once Upon a Forest", "animated"));
            movies.Add(new Movie("Whiplash", "drama"));
            movies.Add(new Movie("Stranger Than Fiction", "drama"));
            movies.Add(new Movie("The VVitch", "horror"));
            movies.Add(new Movie("It Follows", "horror"));
            movies.Add(new Movie("Midsommar", "horror"));
            movies.Add(new Movie("Brazil", "scifi"));
            movies.Add(new Movie("Videodrome", "scifi"));
            movies.Add(new Movie("Blade Runner", "scifi"));
            string userContinue = "";
            bool programContinue = true;

            while (programContinue == true)
            {
                Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 10 movies in this list.");
            Console.Write("What category are you interested in?: ");

           string userinput = Console.ReadLine();



            var userChoice = movies.Where(s => s.Category == userinput).ToList();

            foreach (Movie c in userChoice)
            {
                Console.WriteLine(c.Title);
            }
                Continue();
            }







        }
    }
}
