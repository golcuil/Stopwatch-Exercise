using System;

namespace StopWatch { 

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stopwatch simulation.");
            int userSelection = -1;

            StopWatch newStopWatch = new();

            while (userSelection != 0)
            {
                Console.WriteLine("Please Select an operation");
                Console.WriteLine("(1) Start Stopwatch");
                Console.WriteLine("(2) Stop the stopwatch");
                Console.WriteLine("(3) Reset Stopwatch");
                Console.WriteLine("(0) Quit Stopwatch");

                try
                {
                    userSelection = int.Parse(Console.ReadLine());

                    switch (userSelection)
                    {
                        case 1:
                            newStopWatch.Start();
                            break;

                        case 2:
                            newStopWatch.Stop();
                            break;

                        case 3:
                            newStopWatch.ResetStopWatch();
                            break;

                        case 0:
                            Console.WriteLine("Thanks for using app.");
                            break;

                        default:
                            Console.WriteLine("Unvalid operation. Please try again");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error ! " + ex.Message);
                    Console.WriteLine("Please enter a valid operation.");
                }
            }

        }
    }
}
