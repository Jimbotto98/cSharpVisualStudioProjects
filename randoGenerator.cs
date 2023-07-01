using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //I had to redo my code completely. I did this project in 2 courses
            //when i was learning if, else if statements. my ints where inside
            // my if statements. Once i did the do loop, i had to get my
            //int outside the do block.


            //the two statements below where given before I began.
            Random randoGenerator = new Random();
            int randoNumber = randoGenerator.Next(1, 11);

            //these two statements I added after making the do while loop
            int usersGuess;
            int amountOfGuesses = 0;

            //i put my initial writeline at the top so it doesnt repeat
            //outside the do while loop
            Console.WriteLine("guess a number between 1-10");


            do
            { 
                

                //the beginning of my if statement
                usersGuess = int.Parse(Console.ReadLine());
                if (usersGuess < randoNumber)
                {
                    //if you ever seen AQTHF
                    //my responses would be the one of Master Shake
                    Console.WriteLine("you fool, your guess is too low");
                    Console.WriteLine("try again");
                }
                else if (usersGuess > randoNumber)
                {
                    Console.WriteLine("okay Einstein, thats to high");
                    Console.WriteLine("do it again");
                }
                else
                {
                    Console.WriteLine("wise guy over here");
                    Console.WriteLine("you got lucky");
                }
                amountOfGuesses++;

            } while (usersGuess != randoNumber);
            Console.WriteLine("You guessed {0} times", amountOfGuesses);
        }
    }
}
