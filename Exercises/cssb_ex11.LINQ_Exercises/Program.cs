using System;
using System.Collections.Generic;
using System.Linq;

namespace cssb_ex11.LINQ_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1. Given the integer array shown below, write a query that prints the even numbers\n");

            //int[] n1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //IEnumerable<int> numbers = n1.Where(n => n % 2 == 0);
            //foreach(int n in numbers)
            //    Console.WriteLine(n);
            //Console.WriteLine();

            //Console.WriteLine("2. Given the integer array shown below write a query that prints the positive numbers greater than 0 and less than 12.\n");
            //int[] n2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            //IEnumerable<int> posNumbers = n2.Where(n => n >0).Where(n => n<12);
            //foreach(int n in posNumbers)
            //    Console.WriteLine(n);
            //Console.WriteLine();

            //Console.WriteLine("3. Given the list below print all the integers and their squares where the square of the integer is greater than 20.For example, this will not include 4(square is 16) but will include 5(square is 25).\n");
            //var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            //IEnumerable<int> square = arr1.Select(n => n).Where(n => n*n >20);
            //foreach(int n in square)
            //    Console.WriteLine($"Number = {n}, SqrNo = {n*n} ");
            //Console.WriteLine();

            //Console.WriteLine("4. Given the list below print a report listing each digit and the number of times that digit appears in the list.\n");

            //int[] arr2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            //var numTimes = arr2.GroupBy(n => n).Select(m => new { key = m.Key, val = m.Count() });
            //foreach (var i in numTimes)
            //    Console.WriteLine($"Number: {i.key} appears {i.val} times");
            ////Another way:
            ////var m = from x in arr2
            ////        group x by x into y
            ////        select y;
            ////Console.WriteLine("\nThe number and the Frequency are : \n");
            ////foreach (var arrNo in m)
            ////{
            ////    Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            ////}

            //Console.WriteLine("5. Request the user to enter a string and then print a report showing each character in the string and the number of times that character appears. Your output should be as follows.\n");

            //Console.WriteLine("Enter a string: ");
            //string question5 = Console.ReadLine();

            //char[] splitted = question5.ToCharArray();

            //var eachchar = from c in splitted
            //              group c by c into totalgrouped
            //               select totalgrouped;
            //foreach (var i in eachchar)
            //Console.WriteLine($"Character {i.Key}: {i.Count()} times\n");

            //Console.WriteLine("6. Given an input string like the one below, write a LINQ query that prints each item on a separate line.");

            //string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //for(int i =0; i<dayWeek.Length; i++)
            //{
            //    string day = dayWeek[i];
            //    Console.WriteLine(day);
            //}
            //Console.WriteLine();
            //Console.WriteLine("7. Given the following array, print a report listing each digit, the frequency of each digit, and the digit timmes the frequency.");

            //int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            //Console.WriteLine("Number  Number*Frequency  Frequency");
            //Console.WriteLine("-----------------------------------");
            //var eachdigit = from d in nums
            //                group d by d into frequency
            //                select frequency;
            //foreach (var i in eachdigit)
            //{
            //    Console.WriteLine($"{i.Key}              {i.Key * i.Count()}               {i.Count()}");
            //}

            Console.WriteLine("8. Given the following string array, write a routine that requests the use to enter a beginning and an ending character, and then prints the name of the city that matches.\n");
            
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            Console.WriteLine("The cities are: ");
            foreach (var i in cities)
                Console.Write($"{i}, ");
            Console.WriteLine();
            string newcities = cities.ToString();
            //List<string> mylist = new List<string>();
            IEnumerable<string> results = newcities.Where(s => s=="Rome");
            foreach(string s in results)
                Console.WriteLine(s);

            //Console.WriteLine("Input starting character for the string: ");
            //string z = Console.ReadLine();            

            //var find = from c in cities
            //           where String.Equals(z, c)
            //           select c;
            //foreach(var x in find)
            //    Console.WriteLine(x);

        }
    }
}

  