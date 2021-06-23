using System;
using System.Collections.Generic;

namespace Lab10MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            //Animated movies
            var spaceJam = new Movie
            {
                Title = "Space Jam",
                Category = "Animated"
            };

            var up = new Movie("Up", "Animated");
            var toyStory = new Movie("Toy Story", "Animated");

            //drama movies
            var braveheart = new Movie("Braveheart", "Drama");
            var miracle = new Movie("Miracle", "Drama");
            var coachCarter = new Movie("Coach Carter", "Drama");

            //Horror movies
            var split = new Movie("Split", "Horror");
            var it = new Movie("It", "Horror");

            //scifi movies
            var theMartian = new Movie("The Martian", "Scifi");
            var starTrek = new Movie("Star Trek", "Scifi");

            List<Movie> movies = new List<Movie> { };
            movies.Add(spaceJam);
            movies.Add(up);
            movies.Add(toyStory);
            movies.Add(braveheart);
            movies.Add(miracle);
            movies.Add(coachCarter);
            movies.Add(split);
            movies.Add(it);
            movies.Add(theMartian);
            movies.Add(starTrek);

            do
            {
                Console.WriteLine("Please select a movie category: Animated, Drama, Horror or Scifi.");
                string userInput = Console.ReadLine().ToLower();
                movieDetails(userInput, movies);

                

               
                

                Console.Write("Would you like to pick another genre? (y/n): ");
                answer = Console.ReadLine().ToLower();


            } while (answer != "n");

            Console.WriteLine("Goodbye");
          

            
             
           

            


        }

        public static void movieDetails(string userInput, List<Movie> movies)
        {
            foreach (var film in movies)
            {
                if (userInput == film.Category.ToLower())
                {
                    Console.WriteLine(film.Title);
                }
                else
                {
                    Console.WriteLine("Invald input. Check that you picked one of the four categories offered.");
                    break;
                }


            }

        }

        
    }   
    
}
