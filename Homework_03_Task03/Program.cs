/*
Написати програму, яка кодує або декодує повідомлення, яке вказується в командному рядку. 
Сама дія (кодувати чи декодувати) вказується першим параметром, а потім йде фраза,
яка підлягає відповідній операції. 
Метод шифрування може бути довільним, наприклад інкрементування на одиницю тощо. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentece: ");
            //string str = Console.ReadLine();
            //string str = "When in the chronicle of wasted time I see descriptions of the fairest wights";
            string str = "Vgdmhmsgdbgqnmhbkdnev`rsdcshldHrddcdrbqhoshnmrnesgde`hqdrsvhfgsr";

            var arr = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            ChoiceMethod("encrypt", ref str);

            Console.WriteLine(str);
        }

        static void ChoiceMethod(string choice, ref string str)
        {
            if (choice == "encrypt")
                EncryptStr(ref str);
            else if (choice == "decrypt")
                DecryptStr(ref str);
            else
                Console.WriteLine(str);
        }
        static void EncryptStr(ref string str)
        {
            var arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }

            str = new string(arr);
        }

        static void DecryptStr(ref string str)
        {
            var arr = str.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]--;
            }

            str = new string(arr);
        }
    }
}
