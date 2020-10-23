using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 1. Дано текстовий файл з cs - програмою. (будь-яка домашня робота, або взяти із репозиторію)
Вилучити однорядкові  коментарі(утворити інший  cs - файл)        var  val =12; //this is comment
Знайти службові слова С#, які зустрілися у файлі та їх кількість
	
2. Утворити рваний масив([][]) з байтів. Записати його у файл та прочитати з файлу. Написати відповідні методи. 
Використати клас FileStream.
 */

namespace Homework_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> doc = new List<string>();
            try
            {
                using (StreamReader reading = File.OpenText("comp.cs"))
                {
                    string str;
                    while ((str = reading.ReadLine()) != null)
                    {
                        if (str.Contains("//"))
                        {
                            int index = str.LastIndexOf("//");
                            doc.Add(str.Substring(0, index));
                        }
                        else
                        {
                            doc.Add(str);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR_1");
            }

            try
            {
                using (StreamWriter writer = new StreamWriter("no_commit.cs"))
                {
                    foreach (var item in doc)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR_2");
            }
        }
    }
}
