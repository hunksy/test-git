using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_git
{
    internal class Program
    {
        static int Summary(int a, int b)
        {
            return a + b;
        }
        static int Substract(int a, int b)
        {
            return a - b;
        }

        static int Reverse(int number, int r)
        {
            if(number < 10)
            {
                return r*10+number;
            }
            return Reverse(number/10, r*10+number%10);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(123,0));
            Console.WriteLine(Summary(1, 2));
            Console.WriteLine("hello");
        }
    }
}
