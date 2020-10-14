using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Створити програму для роботи з папками та файлами.
Програма повинна працювати  подібно "командному рядку". Тобто очікувати введення команди і виконувати вірну команду.

Передбачити наступні команди:

- md Ім'я_папки(створення папки)

- rd Ім'я_папки(видалення папки)

- cd Ім'я_папки(зміна поточної папки - SetCurrrentDirectory)

- dir патерн (вивід списку файлів та папок поточної папки за вказаним шаблоном чи без)


- create Ім'я_файлу( створення текстового файлу з записом тексту в нього)

- type  Ім'я_файлу(перегляд вмісту файлу)

- copy   Ім'я_файлу1  Ім'я_файлу2 (копіювання файлу)

- del  Ім'я_файлу(видалення файлу)

 */

namespace Console_07._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string SYSTEM = "C:\\";
            Directory.SetCurrentDirectory(SYSTEM);

            DirectoryInfo myDirectory = new DirectoryInfo("MY_SYSTEM");
            myDirectory.Create();
            Directory.SetCurrentDirectory("MY_SYSTEM");
            // працюю в папці MY_SYSTEM

            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.Write("command: ");
                string[] words = Console.ReadLine().Split(' ');
                foreach (string word in words)
                {
                    // HELP - довідка про команди
                    if ("HELP" == word)
                        Info();

                    // MD - створити папку (без аргуметів)
                    if ("md" == word)
                        CreateFolder(words[1]);

                    // RD - видалити папку
                    if ("rd" == word)
                        DeleteFolder(words[1]);

                    // CD - змінити папку
                    if ("cd" == word)
                        ChangeFolder(words[1]);

                    // PWD - показати поточний шлях
                    if ("pwd" == word)
                        Console.WriteLine("Current directory: {0}", Directory.GetCurrentDirectory());

                    // DIR - вивід списку файлів та папок
                    if ("dir" == word)
                        ShowFile();

                    // CREATE - створення текстового файлу
                    if ("create" == word)
                        CreateFile(words[1]);

                    // TYPE - перегляд вмісту файлу
                    if ("type" == word)
                        ShowOpenFile(words[1]);

                    //COPY - копіювати з файлу1 в файл2
                    if ("copy" == word)
                        File.Copy(words[1], words[2]);

                    // DEL - видалити файл
                    if ("del" == word)
                        File.Delete(words[1]);

                    if ("exit" == word)
                        return;
                }
            }
            DirectoryInfo myDirectoryMy = new DirectoryInfo("MY_SYSTEM");
            myDirectoryMy.Create();
        }

        private static void ChangeFolder(string nameFolder)
        {
            try
            {
                if (nameFolder == "~")
                {
                    Directory.SetCurrentDirectory("C:\\MY_SYSTEM");
                    return;
                }
                Directory.SetCurrentDirectory(nameFolder);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("folder not found");
            }
        }

        private static void ShowOpenFile(string name)
        {
            string str;
            StreamReader reader = new StreamReader(name);

            while (!reader.EndOfStream)
            {
                str = reader.ReadLine();
                Console.WriteLine(str);
            }
            reader.Close();
        }

        private static void CreateFile(string name)
        {
            name += ".txt";
            FileInfo file = new FileInfo(name);

            using (StreamWriter sw = File.CreateText(name))
            {
                Console.Write("Enter text to write: ");
                sw.WriteLine(Console.ReadLine());
            }
        }

        private static void ShowFile()
        {
            string[] dirs;
            string[] files;

            dirs = Directory.GetDirectories(Directory.GetCurrentDirectory());
            files = Directory.GetFiles(Directory.GetCurrentDirectory());

            foreach (var item in dirs)
            {
                Console.WriteLine($"{new DirectoryInfo(item).Name}\\");
            }

            foreach (var item in files)
            {
                Console.WriteLine(Path.GetFileName(item));
            }
        }

        private static void DeleteFolder(string nameDeleteFolder)
        {
            DirectoryInfo myDirectoryMy = new DirectoryInfo(nameDeleteFolder);
            myDirectoryMy.Delete();
        }

        static void CreateFolder(string nameNewFolder)
        {
            DirectoryInfo myDirectoryMy = new DirectoryInfo(nameNewFolder);
            myDirectoryMy.Create();
        }
        static void Info()
        {
            Console.WriteLine("MD\tІм'я_папки(створення папки)");
            Console.WriteLine("RD\tІм'я_папки(видалення папки)");
            Console.WriteLine("CD\tІм'я_папки(зміна поточної папки)");
            Console.WriteLine("DIR\tпатерн (вивід списку файлів та папок поточної папки)");
            Console.WriteLine("CREATE\tІм'я_файлу( створення текстового файлу з записом тексту в нього)");
            Console.WriteLine("TYPE\tІм'я_файлу(перегляд вмісту файлу)");
            Console.WriteLine("COPY\tІм'я_файлу1  Ім'я_файлу2 (копіювання файлу)");
            Console.WriteLine("DEL\tІм'я_файлу(видалення файлу)");
            Console.WriteLine("PWD\tПоточний шлях");
        }
    }
}
