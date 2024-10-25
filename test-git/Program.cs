﻿using System;
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
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static double Divide(int a, int b)
        {
            return a / b;
        }

        static int Ackerman(int n, int m)
        {
            //Если n равно 0, возвращаем m +1
            if (n == 0)
            {
                return m + 1;
            }
            //Если n не равно 0, но m равно 0, вызываем функцию Ackerman с n-1 и 1
            else if (m == 0)
            {
                return Ackerman(n - 1, 1);
            }
            //В остальных случаях вызываем Ackerman(n-1, Ackerman(n, m-1))
            else
            {
                return Ackerman(n - 1, Ackerman(n, m - 1));
            }
        }
        static int Fibonacci(int number)
        {
            //Если число 1 или 2 возвращаем 1
            if(number == 1 || number == 2)
            {  
                return 1; 
            }
            //Рекурсивно возвращаем сумму двух предыдущих чисел
            return Fibonacci(number-1) + Fibonacci(number - 2);
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
            Console.WriteLine(Ackerman(3, 4));
            Console.WriteLine(Ackerman(2, 5));
          
            Console.WriteLine(Fibonacci(10)); 
            Console.WriteLine(Fibonacci(7));
        }
    }
}
