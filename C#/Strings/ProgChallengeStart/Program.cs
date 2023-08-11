using System;
using System.Globalization;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int num_guesses = 0;
            int guess = 0;
            bool keepGoing = true;
            
            do{
                Console.WriteLine("What's your guess?");
                string current_guess = Console.ReadLine();
                
                bool success = Int32.TryParse(current_guess, out guess);

                if (success)
                {
                    if (guess < theNumber)
                    {
                        num_guesses++;
                        Console.WriteLine("Nope, higher than that");
                    }
                    else if (guess > theNumber)
                    {
                        num_guesses++;
                        Console.WriteLine("Nope, lower than that");
                    }
                    else if (guess == -1)
                    {
                        Console.WriteLine($"Oh well. I was thinking of {theNumber}");
                        keepGoing = false;
                    }
                    else
                    {
                        Console.WriteLine($"You got it in {num_guesses}");
                        keepGoing = false;
                    }
                } 
                else
                {
                    Console.WriteLine("Hmm, that doesn't look like a number. Try again");
                }
               
            }while (keepGoing);

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer

            //Alternative
            //Console.WriteLine("Nope, {0} than that.", guess < theNumber ? "higher" : "lower");
        }
    }
}
