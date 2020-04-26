using System;

namespace cssb_ex12.MathGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************\n");
            Console.WriteLine(" Programming Exercise 10: Welcome to Math Games!\n");
            Console.WriteLine("************************************************\n");
            while (true)
            {
                Console.Write("Enter Q to exit, ANY key to continue: ");
                string exit = Console.ReadLine();
                if (exit == "Q" || exit == "q")
                    Environment.Exit(0);


                Console.WriteLine("  To add, enter 1,");
                Console.WriteLine("  To substract, enter 2,");
                Console.WriteLine("  To multiply, enter 3,");
                Console.WriteLine("  To divide, enter 4.");

                Console.Write("Choose your problem type: ");
                string n1 = Console.ReadLine();
                int probType = int.Parse(n1);

                Console.Write("Enter number of problems between 1 and 12: ");
                string p1 = Console.ReadLine();
                int numProb = int.Parse(p1);
                Console.WriteLine();

                int score;
                Util.Initialize(probType, numProb);
                if (probType == 1)
                    score = Util.Add(numProb);
                else if (probType == 2)
                    score = Util.Substract(numProb);
                else if (probType == 3)
                    score = Util.Multiply(numProb);
                else if (probType == 4)
                    score = Util.Divide(numProb);
                else
                    Console.WriteLine("Sorry, you made an invalid entry.");

            }
        }
    }
}
