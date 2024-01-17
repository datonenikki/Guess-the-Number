using System;
namespace HotNCold
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            int tries = 0;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }
                    guesses++;
                    tries++;
                }
                if (tries < 20)
                {
                    Console.WriteLine("Number: " + number);
                    Console.WriteLine("Guesses: " + guesses);
                    Console.WriteLine("YOU WIN!");
                }
                else if (tries > 20)
                {
                    Console.WriteLine("Number: " + number);
                    Console.WriteLine("Guesses: " + guesses);
                    Console.WriteLine("YOU LOSE!");
                }

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                break;
            }
        }
    }
}