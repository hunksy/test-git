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

        static void Main(string[] args)
        {
            Console.WriteLine(Summary(1, 2));
            Console.WriteLine("hello");
        }
    }
}
