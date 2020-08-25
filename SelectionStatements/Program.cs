using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess my favorite number");
            Console.WriteLine("What is the highest number limit for the range?");


            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);


            var random = new Random();
            var number = random.Next(1, upperLimit);

            int guess;
            do
            { 

                Console.WriteLine("Input your guess...");

                guess = int.Parse(Console.ReadLine());


                if(guess > number)
                {
                Console.WriteLine("Your guess is too high! Sorry");
                }
                else if(guess < number)
                {
                Console.WriteLine("Your guess is too low! Sorry");
                }
                else
                {
                Console.WriteLine("Correct!");
                }

            }

        }
    }
}
