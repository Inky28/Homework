using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Написати програму для виконання операцій з одновимірним масивом за допомогою делегатів. Користувачу надається наступне меню для вибору типа операції з масивом:
1.    обчислення значення
2.    зміна масиву
Якщо користувач вибрав 1-й тип, вивести підменю вибору операції:
i.    Обчислити кількість негативних елементів
ii.    Визначити суму всіх елементів
iii.    Обрахувати кількість простих чисел
2-й тип:
i.    Змінити всі негативні елементи на 0
ii.    Відсортувати масив
iii.    Перемістити всі парні елементи на початку, відповідно не парні будуть в кінці.
Методи першого типу повинні повертати результат обчислення, в той час методи 2-го типу - void.
Реалізувати валідацію вибраного номера операції.
 */

namespace Homework_09
{
    class Program
    {
        static string ToStringArray(IEnumerable<int> arr, string name = "Array")
        {
            string res = $"{name}: ";
            foreach (var item in arr)
                res += $"{item} ";
            return res;
        }

        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            if (num % 2 == 0 && num != 2)
                return false;

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        public delegate int CountArr(int[] arr);
        public delegate void ChangeArr(int[] arr);

        public static int CountNegativeNum(int[] arr)
        {
            return arr.Count(x => x < 0);
        }

        public static int SumOfAllNum(int[] arr)
        {
            return arr.Sum();
        }

        public static int CountPrimeNum(int[] arr)
        {
            return arr.Count(x => IsPrime(x));
        }

        public static void ChangeNegativeNum(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < 0)
                    arr[i] = 0;
        }

        public static void Sort(int[] arr)
        {
            Array.Sort(arr);
        }

        public static void PairElemInFront(int[] arr)
        {
            var pairArr = arr.Where(x => x % 2 == 0).ToArray();
            var oddArr = arr.Where(x => x % 2 != 0).ToArray();

            for (int i = 0; i < pairArr.Length; i++)
            {
                arr[i] = pairArr[i];
            }

            for (int i = 0; i < oddArr.Length; i++)
            {
                arr[i + pairArr.Length] = oddArr[i];
            }
        }

        static void Main(string[] args)
        {
            var rand = new Random();
            var menu = new Menu();
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-20, 20);

            menu.Header = ToStringArray(arr);

            menu.Add(new MenuItem("Value calculation", () =>
            {
                CountArr countArr;
                var menu1 = new Menu();
                menu1.Add(new MenuItem("Count negative numbers", () =>
                {
                    countArr = new CountArr(CountNegativeNum);
                    menu1.Header = $"Num of negative numbers: {countArr.Invoke(arr)}";
                }));

                menu1.Add(new MenuItem("Determine the sum of all elements", () =>
                {
                    countArr = new CountArr(SumOfAllNum);
                    menu1.Header = $"Sum: {countArr.Invoke(arr)}";
                }));

                menu1.Add(new MenuItem("Count prime numbers", () =>
                {
                    countArr = new CountArr(CountPrimeNum);
                    menu1.Header = $"Num of prime numbers: {countArr.Invoke(arr)}";
                }));

                menu1.Add(new MenuItem("Exit", () => menu1.Exit()));
                menu1.Start();

            }));

            menu.Add(new MenuItem("Changing the array", () =>
            {
                ChangeArr changeArr;
                var menu1 = new Menu();

                menu1.Add(new MenuItem("Change negative numbers to 0", () =>
                {
                    changeArr = new ChangeArr(ChangeNegativeNum);
                    changeArr.Invoke(arr);
                    menu1.Header = ToStringArray(arr, "Changed negarive numbers");
                }));

                menu1.Add(new MenuItem("Sort", () =>
                {
                    changeArr = new ChangeArr(Sort);
                    changeArr.Invoke(arr);
                    menu1.Header = ToStringArray(arr, "Sorted array");
                }));

                menu1.Add(new MenuItem("Set pair num in front", () =>
                {
                    changeArr = new ChangeArr(PairElemInFront);
                    changeArr.Invoke(arr);
                    menu1.Header = ToStringArray(arr, "Pair elem in front");
                }));
                menu1.Add(new MenuItem("Exit", () => menu1.Exit()));

                menu1.Header = ToStringArray(arr);

                menu1.Start();
            }));

            menu.Add(new MenuItem("Change numbers", () =>
            {
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = rand.Next(-20, 20);
                menu.Header = ToStringArray(arr);
            }));

            menu.Add(new MenuItem("Exit", () => menu.Exit()));

            menu.Start();
        }
    }
}
