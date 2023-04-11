using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHome4
{
    public class Improve
    {
        /// <summary>
        /// Создайте переменные, которые будут хранить следующие слова: (Welcome, to, the, TMS, lessons)выполните конкатенацию слов и выведите на экран следующую фразу:
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>
        public static void Task2()
        {

            string str1 = "Welcome";
            string str2 = "to";
            string str3 = "the";
            string str4 = "TMS";
            string str5 = "lessons";

            string phrase = ("\"" + str1 + "\"" + " " + "\"" + str2 + "\"" + " " + "\"" + str3 + "\"" + " " + "\"" + str4 + "\"" + " " + "\"" + str5 + "\"");
            Console.WriteLine(phrase);
        }

        /// <summary>
        /// Дана строка: Good day 
        /// Необходимо с помощью метода substring удалить слово "Good". 
        /// После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        /// Заменить последний "!" на "?" и вывести результат на консоль. 
        /// </summary>
        public static void Task4()
        {
            string text = "Good day";
            text = text.Substring(4);

            String text1 = "The best";
            text = text.Insert(0, text1);

            String text2 = "!!!!!!!!!";
            text = text.Insert(12, text2);

            int ind = text.Length - 1;
            text = text.Remove(ind);

            String text3 = "?";
            text = text.Insert(20, text3);

            Console.WriteLine(text);
        }

        /// <summary>
        /// Введите с консоли строку, которая будет содержать буквы и цифры.
        /// Удалите из исходной строки все цифры и выведите их на экран.
        /// (Использовать метод Char.IsDigit(), его не разбирали на уроке, посмотрите, пожалуйста, документацию этого метода самостоятельно)
        /// </summary>
        public static void Task5()
        {
            Console.Write("Input the string:");
            string initial = Console.ReadLine();
            char[] letters = initial.ToCharArray();
            foreach (char c in letters)
            {
                if (c == '1')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '2')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '3')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '4')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '5')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '6')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '7')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '8')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '9')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
                else if (c == '0')
                {
                    initial = initial.Replace(c.ToString(), String.Empty);
                    Console.Write(c);
                }
            }
            Console.WriteLine();
            Console.WriteLine(initial);
        }

        /// <summary>
        /// Задайте 2 предложения из консоли. Для каждого слова первого предложения определите количество его вхождений во второе предложение.
        /// </summary>
        public static void Task6()
        {
           
        }
    }
}
