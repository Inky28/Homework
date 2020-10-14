/*
 Даны 2 массива размерности M и N соответственно.
Необходимо переписать в третий массив общие элементы 
первых двух массивов без повторений.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02
{
    class Program
    {
        static void PrintArr(int[] arr, string nameOfArr = "Array")
        {
            Console.Write($"{nameOfArr}: ");

            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");

            Console.WriteLine();
        }

        static void AddUniqueElem(int elem, ref int[] arr)
        {
            if (!arr.Contains(elem))
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = elem;
            }
        }
        static void Main(string[] args)
        {
            var rand = new Random();
            int m = 10, n = 15;

            int[] arr1 = new int[m];
            int[] arr2 = new int[n];

            for (int i = 0; i < arr1.Length; i++)
                arr1[i] = rand.Next(1, 20);


            for (int i = 0; i < arr2.Length; i++)
                arr2[i] = rand.Next(1, 30);

            PrintArr(arr1, "Arr1");
            PrintArr(arr2, "Arr2");

            int[] arr3 = new int[0];

            if (arr1.Length > arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                    if (arr2.Contains(arr1[i]))
                        AddUniqueElem(arr1[i], ref arr3);
            }
            else
            {
                for (int j = 0; j < arr2.Length; j++)
                    if (arr1.Contains(arr2[j]))
                        AddUniqueElem(arr2[j], ref arr3);
            }

            PrintArr(arr3, "Arr3");
        }
    }
}
