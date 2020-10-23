using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 -------------------Узагальнення ----------------------
1. Створити узагальнений метод, який отримує одновимірний масив та впорядковує його за зростанням(чи спаданням)
 довільним алгоритмом впорядкування. 
Перевірити роботу методу для масивів цілого, рядкового типу,  масиву елементів користувацького типу(класу чи структури)

2. Додати до  методу завдання 1  обмеження на використання  тільки для типів - значень.  Перевірити можливість(неможливість) 
використання методу для  масивів різних типів.
 */

namespace Homework_10
{
    class Program
    {
        static void PrintArr<T>(T[] arr, string name = "Arr")
        {

            Console.Write($"{name}: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static void Sort<T>(T[] arr)
        {
            if (typeof(T).IsValueType)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    T x = arr[i];

                    int j = Math.Abs(Array.BinarySearch(arr, 0, i, x) + 1);

                    Array.Copy(arr, j, arr, j + 1, i - j);

                    arr[j] = x;
                }
            }
        }

        class RefType : IComparable
        {
            public int Num { get; set; }

            public int CompareTo(object obj)
            {
                if (obj is RefType)
                    return Num - (obj as RefType).Num;
                return 0;
            }

            public override string ToString()
            {
                return Num.ToString();
            }
        }

        static void Main(string[] args)
        {
            var valueArr = new int[] { 5, 4, 1, 7, 3, 0, 2, 6, 9, 8 };

            var refArr = new RefType[]
            {
                new RefType() { Num = 5 },
                new RefType() { Num = 4 },
                new RefType() { Num = 1 },
                new RefType() { Num = 7 },
                new RefType() { Num = 3 },
                new RefType() { Num = 0 },
                new RefType() { Num = 2 },
                new RefType() { Num = 6 },
                new RefType() { Num = 9 },
                new RefType() { Num = 8 }
            };

            PrintArr(valueArr, "valueArr");

            Sort(valueArr);
            PrintArr(valueArr, "Sorted valueArr");

            PrintArr(refArr, "refArr");

            Sort(refArr);
            PrintArr(refArr, "Sorted refArr");
        }
    }
}
