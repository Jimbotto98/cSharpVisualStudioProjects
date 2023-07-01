namespace superSimpleCalculator.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // My superSimpleCalculator

            //The superSimpleCalculator reads two integers from the user
            //& adds them together.

                //Console.WriteLine("enter a number");moved it
                //Console.ReadLine(); My initial code. I moved it later

                //Console.WriteLine("enter another number"); moved it
                //Console.ReadLine(); Same thing.

            //so far I have a WriteLine and ReadLine, now to make it work

            Console.WriteLine("enter a number");

                //int spaceOne = Console.ReadLine();My initial code.
            int firstInt = int.Parse(Console.ReadLine());

            Console.WriteLine("enter another number");

            int secondInt = int.Parse(Console.ReadLine());

            //I knew I needed to put int. Now I just learned about Parse

            int answer = firstInt + secondInt;
            //I was happy I got that right

            Console.WriteLine("voila");

            Console.WriteLine(answer);

            
        }
    }
}

