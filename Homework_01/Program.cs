/* Объявить одномерный (5 элементов ) массив с именем
A и двумерный массив (3 строки, 4 столбца) дробных
чисел с именем B. Заполнить одномерный массив А
числами, введенными с клавиатуры пользователем,

а двумерный массив В случайными числами с помощью циклов. 
Вывести на экран значения массивов:
массива А в одну строку, массива В — в виде матрицы.

Найти в данных массивах общий максимальный
элемент, минимальный элемент, общую сумму всех
элементов, общее произведение всех элементов, 
сумму четных элементов массива А, сумму нечетных
столбцов массива В. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            int[] A = new int[5];
            float[,] B = new float[3, 4];

            Console.WriteLine("Fill array");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Enter element[{i}]:");
                A[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < B.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    B[i, j] = rand.Next(1, 10);

            Console.Write("Array A: ");
            for (int i = 0; i < A.Length; i++)
                Console.Write($"{A[i]} ");

            Console.WriteLine("\n\n#####################\n\n");

            Console.WriteLine("Array B: ");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                    Console.Write($"{B[i, j]} ");

                Console.WriteLine();
            }

            float max = A.Max(), min = A.Min();
            float sum = 0, mul = 1, sumOfEven = 0, sumOfOddCols = 0;

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    sum += B[i, j];
                    mul *= B[i, j];

                    if (j % 2 == 1)
                        sumOfOddCols += B[i, j];

                    for (int k = 0; k < A.Length; k++)
                    {
                        if (max < B[i, j])
                            max = B[i, j];
                        if (min > B[i, j])
                            min = B[i, j];
                    }
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                mul *= A[i];
                if (i % 2 == 0)
                    sumOfEven += A[i];
            }

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Mul: " + mul);
            Console.WriteLine("Sum of even: " + sumOfEven);
            Console.WriteLine("Sum of odd columns: " + sumOfOddCols);
        }
    }
}
