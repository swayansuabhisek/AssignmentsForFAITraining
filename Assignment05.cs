using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwayansuAbhisekAssignment
{
    namespace Entities
    {
        class Movie
        {
            public int MovieId { get; set; }
            public string MovieName { get; set; }
            public DateTime RealeseDate { get; set; }
            public int TicketPrice { get; set; }
        }
    }

    namespace DataLayer
    {
        using Entities;
        class MovieManager
        {
            const int size = 100;

            private Movie[] movies = new Movie[size];

            public void AddMovie(Movie movie)
            {
                for (int i = 0; i < size; i++)
                {
                    if (movies[i] == null)
                    {
                        movies[i] = new Movie
                        {
                            MovieId = movie.MovieId,
                            MovieName = movie.MovieName,
                            RealeseDate = movie.RealeseDate,
                            TicketPrice = movie.TicketPrice
                        };
                        return;
                    }
                }
            }

            public void UpdateMovie(Movie  movie)
            {
                for (int i = 0; i < size; i++)
                {
                    if (movies[i] != null && movies[i].MovieId == movie.MovieId)
                    {
                        movies[i].MovieId = movie.MovieId;
                        movies[i].MovieName = movie.MovieName;
                        movies[i].RealeseDate = movie.RealeseDate;
                        movies[i].TicketPrice = movie.TicketPrice;

                        //exit the function
                        return;
                    }
                }
            }
            public void DeleteMovie(Movie movie)
            {

            }

            public Movie[] FindMovie(string detail)
            {
                int count = 0;
                foreach (Movie item in movies)
                {
                    if (item != null && item.MovieName.Contains(detail))
                    {
                        count++;
                    }
                }
                if (count != 0)
                {
                    int tempIndex = 0;
                    Movie[] foundMovies = new Movie[count];
                    foreach (Movie item in movies)
                    {
                        if (item != null && item.MovieName.Contains(detail))
                        {
                            foundMovies[tempIndex] = item;
                            tempIndex++;
                        }
                    }
                    return foundMovies;
                }
                else
                {
                    return null;
                }
            }
        }
    }
    namespace UILayer
    {

        using DataLayer;
        using Entities;
        using System.IO;

        class Assignment05
        {
            const string filePath = @"C:\Users\sabhisek\OneDrive - First American Corporation\Documents\FAI Training\AssignmentSolutios\SwayansuAbhisekAssignment\TextFile1.txt";
            static MovieManager manager = new MovieManager();

            static string getMenu()
            {
                return File.ReadAllText(filePath);
            }

            static void clearScreen()
            {
                Console.WriteLine("Press any key to clear");
                Console.ReadKey();
                Console.Clear();
            }

            static bool processMenu(string choice)
            {
                switch (choice)
                {
                    case "N":
                        addingMovieHelper();
                        return true;
                    case "U":
                        updatingMovieHelper();
                        return true;
                    case "D":
                        deletingMovieHelper();
                        return true;
                    case "F":
                        findingMovieHelper();
                        return true;
                    default:
                        return false;
                }
            }

            private static void findingMovieHelper()
            {
                string finder = UserInterfaceConsole.GetString("Enter the movie detail or part of the detail");
                Movie[] expenses = manager.FindMovie(finder);
                if (expenses != null)
                {
                    foreach (Movie expense in expenses)
                    {
                        Console.WriteLine($"{expense.MovieName} release on {expense.RealeseDate} ticket price is of {expense.TicketPrice}");
                    }
                }
                else
                {
                    Console.WriteLine("No expense found matching");
                }
            }

            private static void deletingMovieHelper()
            {
                throw new NotImplementedException();
            }

            private static void updatingMovieHelper()
            {
                Movie movieObj = new Movie();

                movieObj.MovieId = UserInterfaceConsole.GetNumber("Enter the MovieId");
                movieObj.MovieName = UserInterfaceConsole.GetString("Enter the name of the movie");
                movieObj.RealeseDate = UserInterfaceConsole.GetDate("Enter the date of the release");
                movieObj.TicketPrice = UserInterfaceConsole.GetNumber("Enter the amount of the ticket");
                //call add new expense to the manager
                manager.UpdateMovie(movieObj);


                UserInterfaceConsole.PrintMessage("Movie updated successfully to the system");
            }

            private static void addingMovieHelper()
            {
                Movie movieObj = new Movie();

                movieObj.MovieId = UserInterfaceConsole.GetNumber("Enter the MovieId");
                movieObj.MovieName = UserInterfaceConsole.GetString("Enter the name of the movie");
                movieObj.RealeseDate = UserInterfaceConsole.GetDate("Enter the date of the release");
                movieObj.TicketPrice = UserInterfaceConsole.GetNumber("Enter the amount of the ticket");
                //call add new expense to the manager
                manager.AddMovie(movieObj);


                UserInterfaceConsole.PrintMessage("Movie added successfully to the system");
            }

            static void Main(string[] args)
            {
                string menu = getMenu();
                bool processing = true;
                do
                {
                    string choice = UserInterfaceConsole.GetString(menu);
                    processing = processMenu(choice);
                    clearScreen();
                } while (processing);
            }
        }

    }
}
