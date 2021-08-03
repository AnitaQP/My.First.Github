using System;

namespace Random_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do

            {
                Console.Write("Guess a number between 0 and 100 please: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too high ...... Guess lower");

                }
                else if (i < winNum)
                {
                    Console.WriteLine("Tool low .... Guess higher");
                }

                else if (i == winNum)
                {

                    Console.WriteLine("You win");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank you for playing");
            Console.Write("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}