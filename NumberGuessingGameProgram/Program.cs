internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Random random = new Random(); //Random object named random to generate numbers
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;
        string response;

        while(playAgain)
        {
            guess = 0;
            guesses = 0;
            number = random.Next(min, max + 1);
            response = "";

            while(guess != number)
            {
                Console.WriteLine($"Guess a number between {min} and {max} ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess" + guess);

                if(guess > number)
                {
                    Console.WriteLine(guess + " is too high!");
                }
                else if(guess < number)
                {
                    Console.WriteLine(guess + " is too low!");
                }
                guesses++;
            }

            Console.WriteLine("Number: " + number);
            Console.WriteLine("You win!");
            Console.WriteLine("Total guesses: " + guesses);

            Console.WriteLine("Would you like to play again? (Y = Yes, N = No");
            response = Console.ReadLine().ToUpper();

            if(response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }

        }

        Console.WriteLine();

        Console.WriteLine("Thanks for playing!");
    }
}