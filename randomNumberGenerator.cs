//This program generates a random number 1-10. Ask the user to guess a number.
//display the number and a message.
// Indicate whether the guess was too high, too low, or correct.


Random randomGenerator = new Random();
int randomNumber = randomGenerator.Next(1, 11);
int usersGuess;
int amountOfGuesses = 0;
//this showcses do loops, if statements
do
{
    Console.WriteLine("Guess a number 1-10");
    usersGuess = int.Parse(Console.ReadLine());
    if (usersGuess < randomNumber)
    {
        Console.WriteLine("Okay Einstein,that was too low.");
    }
    else if (usersGuess > randomNumber)
    {
        Console.WriteLine("Come on wiseguy, too high.");
        //Im going for a NY type of AI response
    }
    else
    {
        Console.WriteLine("Whoop dee doo, you got it");
    }
    amountOfGuesses++;

} while (usersGuess != randomNumber);
Console.WriteLine("You guessed {0} times, that will be $5", amountOfGuesses);
