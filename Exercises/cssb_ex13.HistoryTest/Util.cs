using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace cssb_ex13.HistoryTest
{
    internal class Util
    {
        public static List<string> Initialize()
        {
            Console.WriteLine("Initializing test bank... \n");
            List<string> testbank = new List<string>();
            string line;
            StreamReader file = new StreamReader(@"d:\presquiz1.csv");
            while ((line = file.ReadLine()) != null)
            {
                testbank.Add(line);
            }
            file.Close();
            return testbank;
        }

        internal static List<string> MakeTest(List<string> testBank, int howMany)
        {
            Random random = new Random();
            List<string> test = new List<string>();
            while (howMany > 0)
            {
                int question = random.Next(0, testBank.Count);
                test.Add(testBank[question]);
                testBank.RemoveAt(question);
                howMany--;
            }
            return test;
        }

        internal static int GiveTest(List<string> test)
        {
            Random random = new Random();
            int score = 0;
            int question = 1;
            foreach (string s in test)
            {
                //Split roads. Question = [0].
                string[] splitRows = s.Split(",");
                string thequestion = splitRows[0];
                Console.WriteLine($"{question++}. {thequestion}");

                string rightanswer = splitRows[1];
                List<string> choices = new List<string>();
                for (int i = 0; i <=3; i++)
                {
                    choices.Add(splitRows[i + 1]);
                }
                for (int i = 0; i <=3; i++)
                {
                    int q = random.Next(0, choices.Count);
                    splitRows[i + 1] = choices[q];
                    choices.RemoveAt(q);
                }
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i}. {splitRows[i]}");
                }

                Console.WriteLine("Enter your answer: ");
                int answer = int.Parse(Console.ReadLine());
                if (splitRows[answer] == rightanswer)
                {
                    Console.WriteLine("Correct! Good job.");
                    score++;
                }
                else
                    Console.WriteLine($"Incorrect! The right answers was {rightanswer}");
            }
            return score;
        }
    }
}