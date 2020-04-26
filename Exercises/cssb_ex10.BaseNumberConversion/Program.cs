using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssb_ex10.BaseNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************\n");
            Console.WriteLine(" Programming Exercise 10: Base Number Coversion\n");
            Console.WriteLine("************************************************\n");
            while (true)
            {
                Console.Write("Enter Q to exit, N to continue: [N] ");
                string exit = Console.ReadLine();
                if (exit == "Q" || exit == "q")
                    Environment.Exit(0);

                Console.Write("Please enter the integer to convert: ");
                string n1 = Console.ReadLine();
                int number = int.Parse(n1);
                int result = 0;

                Console.Write("Please enter the base to convert from [2 | 8 | 10]: ");
                string n2 = Console.ReadLine();
                int from = int.Parse(n2);

                Console.WriteLine($"Number: {number}, base:{from}");

                if (from == 10)
                {
                    Util.dec2bin(number);
                    result = Util.dec2oct(number);
                    Console.WriteLine($"octal conversion is {result}");
                }
                else if (from == 2)
                {
                    result = Util.bin2dec(number);
                    Console.WriteLine($"decimal conversion is {result}");
                    result = Util.bin2oct(number);
                    Console.WriteLine($"octal conversion is {result}");
                }
                else if (from == 8)
                {
                    Util.oct2bin(number);
                    result = Util.oct2dec(number);
                    Console.WriteLine($"decimal conversion is {result}");
                }
                else
                    Console.WriteLine("Error in base to convert from");
            }
        }
    }
    
}
