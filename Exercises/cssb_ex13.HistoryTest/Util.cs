using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace cssb_ex13.HistoryTest
{
    internal class Util
    {
        public static Dictionary<string, string> questionsNanswer = new Dictionary<string, string>();
            
        private static Random rand = new Random();

        internal static List<string> Initialize()
        {
            using (StreamReader reader = new StreamReader(@"d:\presquiz1.csv"))
            {
                List<String> questions = new List<string>();
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    //Define pattern
                    Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                    //Separating columns to array
                    string[] X = CSVParser.Split(line);

                    questionsNanswer.Add(X[0], X[1]);
                }
                foreach (KeyValuePair<string, string> element in questionsNanswer)
                {
                    questions.Add(element.Key);
                }
                for(int i = 0; i <questions.Count; i++)
                {
                    string temp = questions[i];
                    int randomIndex = rand.Next(i, questions.Count);
                    questions[i] = questions[randomIndex];
                    questions[randomIndex] = temp;
                }
                return questions;
                
            }
        }

        internal static List<string> MakeTest(List<string> testBank, int howMany)
        {
            using (StreamReader reader = new StreamReader(@"d:\presquiz1.csv"))
            {
                List<String> wrongAnswers = new List<string>();
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    //Define pattern
                    Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                    //Separating columns to array
                    string[] X = CSVParser.Split(line);

                    wrongAnswers.Add(X[2]);
                    wrongAnswers.Add(X[3]);
                    wrongAnswers.Add(X[4]);
                }
                
                for (int i = 0; i < wrongAnswers.Count; i++)
                {
                    string temp = wrongAnswers[i];
                    int randomIndex = rand.Next(i, wrongAnswers.Count);
                    wrongAnswers[i] = wrongAnswers[randomIndex];
                    wrongAnswers[randomIndex] = temp;
                }
                return wrongAnswers;

            }
        }
    }
}