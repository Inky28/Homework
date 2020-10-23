using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11_task02
{
    class Program
    {
        static void WriteArr(byte[][] arr, string path)
        {
            using (var file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                foreach (var row in arr)
                {
                    var sizeRow = BitConverter.GetBytes(row.Length);
                    file.Write(sizeRow, 0, sizeRow.Length);
                    file.Write(row, 0, row.Length);
                }
                file.Flush();
                file.Close();
            }
        }

        static void PrintJaggedArray(byte[][] arr, string header = "Jagged array")
        {
            Console.WriteLine(header);
            foreach (var row in arr)
            {
                foreach (var item in row)
                {
                    Console.Write($"{item,-4}");
                }
                Console.WriteLine();
            }
        }

        static byte[][] ReadArr(string path)
        {
            byte[][] array = new byte[0][];
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                fs.Seek(0, SeekOrigin.Begin);
                int countRead;
                int countItems;
                int sizeInt = sizeof(int);
                var sizeRow = new byte[sizeInt];
                while (true)
                {
                    countRead = fs.Read(sizeRow, 0, sizeInt);
                    if (countRead != sizeInt)
                        break;
                    countItems = BitConverter.ToInt32(sizeRow, 0);
                    var data = new byte[countItems];
                    countRead = fs.Read(data, 0, countItems);
                    if (countRead != countItems)
                        break;
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = data;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            var rand = new Random();
            int height = rand.Next(1, 5);
            byte[][] arr = new byte[height][];

            for (int i = 0; i < height; i++)
            {
                arr[i] = new byte[rand.Next(1, 5)];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = (byte)rand.Next(0, 20);
                }
            }

            PrintJaggedArray(arr);

            WriteArr(arr, @"\\Mac\Home\Desktop\ШАГ\C#\Project\Homework_11\Homework_11_task02\TextFile1.txt");
            var res = ReadArr(@"\\Mac\Home\Desktop\ШАГ\C#\Project\Homework_11\Homework_11_task02\TextFile1.txt");

            PrintJaggedArray(res, "From file");
        }
    }
}
