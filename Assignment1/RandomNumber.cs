namespace Assignment1;

public class RandomNumber
{
    int correctNumber = new Random().Next(3) + 1;
    int guessValue = 0;

    public void guess()
    {
        Console.WriteLine("Guess a number between 1 and 3");
        while (guessValue != correctNumber) 
        {
            guessValue = int.Parse(Console.ReadLine());
            if (guessValue < 1 || guessValue > 3)
            {
                Console.WriteLine("Your guess is out of range. Please guess a number between 1 and 3.");
            }
            else if (guessValue < correctNumber)
            {
                Console.WriteLine("Your guess is too low. Try again.");
            }
            else if (guessValue > correctNumber)
            {
                Console.WriteLine("Your guess is too high. Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
            }
        }
    }
}