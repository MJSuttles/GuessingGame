// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choose a difficulty level.");
Console.WriteLine("1. Easy, 2. Medium, 3. Hard, 4. Cheater");

int easy = 8;
int medium = 6;
int hard = 4;

int maxAttempts;
int difficulty = int.Parse(Console.ReadLine());

if (difficulty == 1)
{
  maxAttempts = easy;
}
else if (difficulty == 2)
{
  maxAttempts = medium;
}
else if (difficulty == 3)
{
  maxAttempts = hard;
}
else if (difficulty == 4)
{
  maxAttempts = -1;
}
else
{
  Console.WriteLine("Invalid input.  Easy it is.");
  maxAttempts = easy;
}

Console.WriteLine("Guess the secret number!");
int attempts = 0;
string guess = "";

Random random = new Random();
int randomNumber = random.Next(0, 101);

while (attempts < maxAttempts)
{
  attempts++;
  guess = Console.ReadLine().Trim();

  if (int.TryParse(guess, out int guessNumber))
  {
    if (guessNumber == randomNumber)
    {
      Console.WriteLine("Congratulations! You guessed the correct number!");
      break;
    }
    else
    {
      if (guessNumber > randomNumber)
      {
        Console.WriteLine("Your guess is too high.");
      }
      else
      {
        Console.WriteLine("Your guess is too low.");
      }

      Console.WriteLine($"That was guess #{attempts}. You have {maxAttempts - attempts} left.");
    }
  }
  else
  {
    Console.WriteLine("Please enter a valid number.");
  }

  if (attempts == maxAttempts)
  {
    Console.WriteLine("Oh, no! You're all out of answers! Better luck next time.");
  }
}
