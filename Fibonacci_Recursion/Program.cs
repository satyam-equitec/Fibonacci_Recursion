using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Without Recursion: {Fib_without_recursion(9)}");
            Console.WriteLine($"With Recursion: {Fib(9)}");
            Console.ReadKey();
        }
        public static int Fib(int i)
        {
            if (i <= 1)
            {
                return i;
            }
            return Fib(i - 1) + Fib(i - 2);
        } // With Recursion
        public static int Fib_without_recursion(int i)
        {
            int a = 0;
            int b = 1,c,n;
            if(i==0)
            {
                return a;
            }
            else
            {
                for(n = 2; n <= i; ++n)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                return b;
            }
        } //Without Recursion
    }
}
