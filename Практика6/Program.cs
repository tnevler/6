using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика6
{
    class Program
    {

        static void SequenceOfNumbers(double a1, double a2, double a3, double M, double N, ref int size)
        {
            if (a3 == 0)
            {
                Console.WriteLine("\nСледующий элемент вычислить невозможно");
                return;
            }
            double k = Math.Round((a2 / a3), 2) + Math.Abs(a1);
            Console.Write(k + " ");
            if (size == N)
            {
                Console.WriteLine("\nВ последовательности {0} элементов", N);
                return;
            }
            if (k > M)
            {
                Console.WriteLine("\nПоследний элемент последовательности > M", M);
                return;
            }
            a1 = a2;
            a2 = a3;
            a3 = k;
            size++;
            SequenceOfNumbers(a1, a2, a3, M, N, ref size);
        }

        static double ReadElem(string s, int left, int right)
        {
            double elem = 0;
            bool ok = true;
            do
            {
                try
                {
                    Console.WriteLine(s);
                    elem = Convert.ToDouble(Console.ReadLine());
                    if (elem > left && elem < right) ok = true;
                    else
                    {
                        Console.WriteLine("Неверно введено число!");
                        ok = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка, введите действительное число");
                    ok = false;
                }
            } while (!ok);
            return elem;
        }
        static void Main(string[] args)
        {
            double a1 = ReadElem("Введите a1:", -100, 100);
            double a2 = ReadElem("Введите a2:", -100, 100);
            double a3 = ReadElem("Введите a3:", -100, 100);
            double M = ReadElem("Введите M", -100, 100);
            bool ok = false;
            double N = 0;
            do
            {
                try
                {
                    Console.WriteLine("Введите N:");
                    N = Convert.ToInt32(Console.ReadLine());
                    if (N >= 1) ok = true;
                    else
                    {
                        Console.WriteLine("Неверно введено число!");
                        ok = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Введите целое число");
                    ok = false;
                }
            } while (!ok);
            int size = 1;
            SequenceOfNumbers(a1, a2, a3, M, N, ref size);
            Console.ReadKey();
        }
    }
}