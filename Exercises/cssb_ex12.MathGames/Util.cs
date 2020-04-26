using System;

namespace cssb_ex12.MathGames
{
    internal class Util
    {
        internal static void Initialize (int probType, int numProb)
        {
            string type = "";

            if (probType == 1)
                type = "Addition";
            if (probType == 2)
                type = "Substraction";
            if (probType == 3)
                type = "Multiplication";
            if (probType == 4)
                type = "Division";
            Console.WriteLine($"You are testing {type} and you have {numProb} problems to begin your test. Type any key to begin...");
            Console.ReadKey();
        }

        internal static int Add(int numProb)
        {   int result = 0;
            int answer = 0;
            int x = 0;
            int n = 0;
            double average = 0;

            while (numProb != x)
            {
                x++;
                Random rand = new Random();
                int aNumbers = rand.Next(1, 10);
                int bNumbers = rand.Next(1, 10);
                answer = aNumbers + bNumbers;
                Console.Write($"{x}. {aNumbers} + {bNumbers} = ");
                int attempt = int.Parse(Console.ReadLine());
                if (attempt == answer)
                {
                    n++;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer is {answer}");
                }
            }
            average = 100 * (double)n / x;
            Console.WriteLine($"You got {n} out of {x} correct and your grade is {average}\n");
            return result;
        }
        internal static int Substract(int numProb)
        {
            int result = 0;
            int answer = 0;
            int x = 0;
            int n = 0;
            double average = 0;

            while (numProb != x)
            {
                x++;
                Random rand = new Random();
                int aNumbers = rand.Next(1, 10);
                int bNumbers = rand.Next(1, 10);
                if (aNumbers < bNumbers)
                {
                    int temp = aNumbers;
                    aNumbers = bNumbers;
                    bNumbers = temp;
                }
                    
                answer = aNumbers - bNumbers;
                Console.Write($"{x}. {aNumbers} - {bNumbers} = ");
                int attempt = int.Parse(Console.ReadLine());
                if (attempt == answer)
                {
                    n++;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer is {answer}");
                }
            }
            average = 100 * (double)n / x;
            Console.WriteLine($"You got {n} out of {x} correct and your grade is {average}\n");
            return result;
        }

        internal static int Multiply(int numProb)
        {
            int result = 0;
            int answer = 0;
            int x = 0;
            int n = 0;
            double average = 0;

            while (numProb != x)
            {
                x++;
                Random rand = new Random();
                int aNumbers = rand.Next(1, 10);
                int bNumbers = rand.Next(1, 10);
                answer = aNumbers * bNumbers;
                Console.Write($"{x}. {aNumbers} * {bNumbers} = ");
                int attempt = int.Parse(Console.ReadLine());
                if (attempt == answer)
                {
                    n++;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer is {answer}");
                }
            }
            average = 100 * (double)n / x;
            Console.WriteLine($"You got {n} out of {x} correct and your grade is {average}\n");
            return result;
        }
        internal static int Divide(int numProb)
        {
            int result = 0;
            double answer = 0;
            int x = 0;
            int n = 0;
            double average = 0;

            while (numProb != x)
            {
                x++;
                Random rand = new Random();
                double aNumbers = rand.Next(1, 10);
                double bNumbers = rand.Next(1, 10);
                answer = aNumbers / bNumbers;
                Console.Write($"{x}. {aNumbers} / {bNumbers} = ");
                double attempt = double.Parse(Console.ReadLine());
                double tolerance = answer - attempt;
                if (Math.Abs(tolerance) < .5)
                {
                    n++;
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine($"Sorry, the correct answer is {answer}");
                }
            }
            average = 100 * (double)n / x;
            Console.WriteLine($"You got {n} out of {x} correct and your grade is {average}\n");
            return result;
        }
    }
}