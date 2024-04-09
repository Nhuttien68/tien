using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Program
    {
            public static void swap<T>(ref T firstValue, ref T secondValue)
        {
            T temp = firstValue;
            firstValue = secondValue;
            secondValue = temp;
        }
        static void Main(string[] args)
        {
            int nunber1 = 10;
            int nunber2 = 90;
            Console.WriteLine("number1 :" + nunber1);
            Console.WriteLine("number2 :" + nunber2);
            swap( ref nunber1, ref nunber2);
            Console.WriteLine("Nuber after swap");
            Console.WriteLine("number1 :" + nunber1);
            Console.WriteLine("number2 :" + nunber2);
            string str1 = "heloo";
            string str2 = "world";
            Console.WriteLine("String 1:" + str1);
            Console.WriteLine("String 2:" + str2);
            swap( ref str1, ref str2);
            Console.WriteLine("String after swap");
            Console.WriteLine("String 1:" + str1);
            Console.WriteLine("String 2:" + str2);
            Console.ReadKey();
        }
    }
}
