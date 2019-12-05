using System;

namespace ConsoleApp2
{
    class Guess
    {
        static void Main(string[] args)
        {
            int randomNum = Utils.GetRandom(100);
            int guesses = 0;
            while (true)
            {
                int guess = Utils.GetNumber("Enter Guess: ");
                guesses++;
                //      compare your guess to the random number
                if (guess > randomNum)
                {
                    Console.WriteLine("Too High");
                } else if (guess < randomNum)
                {
                    Console.WriteLine("Too Low");
                } else
                {
                    Console.WriteLine($"You guessed the number {guess} in {guesses} guesses");
                    break;
                }
                //      if the guess is too high give the user an appropriate message
                //      if the guess is too low  give the user an appropriate message
                //      if the guess is right on - congratulate them and break;
                //          for extra fun keep track of the number of guesses

            }
        }
    }
}
