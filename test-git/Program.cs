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
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static double Divide(int a, int b)
        {
            return a / b;
        }

        static string FindNumber(int[,] array, int target, int row, int col)
        {
            //Если строка за пределами массива выводим что число не бло найдено
            if (row >= array.GetLength(0)) 
            {
                return "Число не найдено";
            }

            //Если достигли конца строки, переходим на следующую строку
            if (col >= array.GetLength(1)) 
            {
                return FindNumber(array, target, row + 1, 0);
            }

            //Если текущий элемент равен заданному числу выводим его позицию
            if (array[row, col] == target)
            {
                return $"Число находится в {row+1} строке {col+1} столбца";
            }

            //Переход к следующему элементу в строке
            return FindNumber(array, target, row, col + 1);
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
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(FindNumber(array, 8, 0, 0));
        }
    }
}
