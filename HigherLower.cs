using System;
using System.Collections.Generic;

class Game
{
    private int _guess = 50;

    public int GetGuess()
    {
        return _guess;
    }

    public void SetGuess(int input)
    {
        _guess = input;
    }

    public void NextQuestion(string response)
    {
      if (response == "Higher")
      {
          string userResponse = response;
          int currentGuess = GetGuess();
          int increment = (100 - currentGuess) / 2;
          SetGuess(increment + currentGuess);
          Console.WriteLine("Is your number higher or lower than " + this.GetGuess() + " [Higher/Lower/Correct]");
          userResponse = Console.ReadLine();
          this.NextQuestion(userResponse);
      }
      else if (response == "Lower")
      {
          string userResponse = response;
          int currentGuess = GetGuess();
          int increment = currentGuess - (currentGuess / 2);
          SetGuess(increment);
          Console.WriteLine("Is your number higher or lower than " + this.GetGuess() + " [Higher/Lower/Correct]");
          userResponse = Console.ReadLine();
          this.NextQuestion(userResponse);
      }
      else if (response == "Correct")
      {
        Console.WriteLine("I guessed your number!");
      }
      else
      {
        Console.WriteLine("You have input an invalid response.");
      }

    }


}

class Program
{
    public static void Main()
    {
        Game playGame = new Game();
        bool isCorrect = false;

        while (!isCorrect)
        {
            Console.WriteLine("Pick a number between 1 and 100.");
            Console.WriteLine("Is your number higher or lower than 50? [Higher/Lower/Correct]");
            string firstResponse = Console.ReadLine();
            playGame.NextQuestion(firstResponse);
        }
    }
}
