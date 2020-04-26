using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cssb_ex10.BaseNumberConversion
{
    internal class Util
    {
        internal static void dec2bin(int number)
        {
            Stack<int> binary = new Stack<int>();
            while (number != 1 / 2)
            {
                int bin = number % 2;
                binary.Push(bin);
                int div = number / 2;
                number = div;
            }
            Console.Write("binary conversion is ");
            foreach (int i in binary)
                Console.Write(i);
            Console.WriteLine();
        }
        internal static int dec2oct(int number)
        {
            int mod = 0;
            int multiplier = 1;
            int octval = 0;

            while (number > 0)
            {
                mod = number % 8;
                number = number / 8;
                octval = octval + mod * multiplier;
                multiplier *= 10;
            }
            return octval;
        }
        public static int bin2dec(int n)
        {
            string newnumber = n.ToString();
            char[] charNumber = newnumber.ToCharArray();

            int[] binaryInt = Array.ConvertAll(charNumber, c => (int)Char.GetNumericValue(c));
            int result = 0;
            int x = 0;
            int dec = 0;
            int bin = 1;
            Array.Reverse(binaryInt);
            for (int i = 0; i < binaryInt.Length; i++)
            {
                x = (int)binaryInt.GetValue(i);

                dec = x * bin;
                bin *= 2;
                result = dec + result;
            }
            return result;
        }

        public static Queue<int> binary = new Queue<int>();

        public static int oct2dec (int n)
        {
            string newnumber = n.ToString();
            char[] charNumber = newnumber.ToCharArray();

            int[] binaryInt = Array.ConvertAll(charNumber, c => (int)Char.GetNumericValue(c));
            int result = 0;
            int x = 0;
            int dec = 0;
            int bin = 1;
            Array.Reverse(binaryInt);
            for (int i = 0; i < binaryInt.Length; i++)
            {
                x = (int)binaryInt.GetValue(i);

                dec = x * bin;
                bin *= 8;
                result = dec + result;
            }
            return result;
        }
        public static void oct2bin(int n)
        {
            binary.Clear();
            string newnumber = n.ToString();
            char[] charNumber = newnumber.ToCharArray();

            int[] decInt = Array.ConvertAll(charNumber, c => (int)Char.GetNumericValue(c));
            foreach (int i in decInt)
            {
                calculate(i);

            }
            Console.Write("binary conversion is ");
            foreach (int j in binary)
                Console.Write(j);
            Console.WriteLine();
        }
        public static int bin2oct(int n)
        {
            int dec = bin2dec(n);
            int answer = dec2oct(dec);
            return answer;

        }
        public static void calculate(int nn)
        {
            Queue<int> temp = new Queue<int>();
            int x = 8;
            int y = nn;
            do
            {
                if (y < x)
                {
                    temp.Enqueue(0);
                    x /= 2;
                }
                else
                {
                    y = y - x;
                    temp.Enqueue(1);
                    x /= 2;
                    continue;
                }
            }
            while (x != 0);

            if ((int)temp.Peek() == 0)
            {
                temp.Dequeue();
            }
            foreach (int i in temp)
                binary.Enqueue(i);
        }
    }
}