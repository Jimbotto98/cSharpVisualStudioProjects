namespace superSimpleCalculator.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // My superSimpleCalculator

            //The superSimpleCalculator reads two integers from the user, and adds them together.
            //"Voila!"
            Console.WriteLine("Enter a number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int secondNumber = int.Parse(Console.ReadLine());

            //the answer will be the sum of both answers
            int answer = firstNumber + secondNumber;

            Console.WriteLine("voila");

            //we will make sure Console displays the answers
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, answer);

        }
    }
}

