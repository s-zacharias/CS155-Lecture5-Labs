/// Lab 5		Exercise No. 1
/// File Name: Program.cs
/// @author: Stephanie Zacharias
/// Date:  October 5, 2020
///
/// Problem Statement: Create a guessing game.
/// 
/// 
/// Overall Plan:
/// 1) Initialize a random number to be the goal.
/// 2) Initialize a counter to keep track of guesses.
/// 3) Display welcome message on screen.
/// 4) Handle guess, determine if it's high or low and tally the count.
/// 5) Display the number of guess it took to find the right answer.
///

using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // choose the random number for guessing
            Random random = new Random();
            int goal = random.Next(0, 101);
            
            // initialize counter and guess
            int counter = 0;

            int guess = Int32.Parse(Console.ReadLine());
            

            // display welcome message
            Console.WriteLine("I'm thinking of a number between 0 and 100. " +
                "What is your guess?: " + guess);
            
            // handle the guess
            if (guess == goal)
            {
                counter++;
                Console.WriteLine("You got it! It took " + counter + " tries to get it right!");
            } else if (guess > goal)
            {
                counter++;
                Console.WriteLine("Nope! Try something lower! Try again: " + guess);
            } else if (guess < goal)
            {
                counter++;
                Console.WriteLine("Nope! Try something higher! Try again: " + guess);
            }

        }
    }
}
