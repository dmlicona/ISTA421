using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace cssb_ex13.HistoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = @"d:\presquiz1.csv";
            Console.WriteLine("************************************************\n");
            Console.WriteLine(" Programming Exercise 11: Initializing test bank... \n");
            Console.WriteLine("************************************************\n");

            List<String> testBank = Util.Initialize();

            Console.WriteLine($"How may questions would you like to answer? Enter from 1 to {testBank.Count}: ");

            int howMany = int.Parse(Console.ReadLine());

            List<string> test = Util.MakeTest(testBank, howMany);
            foreach(string q in test)
                Console.WriteLine(q);

            //Console.WriteLine($"Test created, {test.Count} questions.");
            //Console.WriteLine("************************************************\n");
            //Console.WriteLine("      Press any key to begin test. Good luck... \n");
            //Console.WriteLine("************************************************\n");
            //Console.ReadKey();
            //int score = Util.GiveTest(test);
            //Console.WriteLine($"You asnwered {score} out of {howMany} correctly and your grade is {(double)score / howMany * 100}");



            


        }
    }
}
    

