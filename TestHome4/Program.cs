using System;
using System.Data.SqlTypes;
using System.Text;
using TestHome4;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

    
        /// <summary>
        /// Создайте переменные, которые будут хранить следующие слова: (Welcome, to, the, TMS, lessons)выполните конкатенацию слов и выведите на экран следующую фразу:
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
        /// </summary>
        public static void Task2()
        {
            string stringWelcome = "Welcome";
            string stringTo = "to";
            string stringThe = "the";
            string stringTMS = "TMS";
            string sytringLessons = "lessons";

            string[] stringsAllTogether = { stringWelcome, stringTo, stringThe, stringTMS, sytringLessons };

            for (int i = 0; i < stringsAllTogether.Length; i++)
            {
                stringsAllTogether[i] = string.Format("\"{0}\"", stringsAllTogether[i]);
            }

            Console.WriteLine(string.Join(" ", stringsAllTogether));
        }

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart,
        /// а также всё, что после них во вторую secondPart.
        /// Результат вывести в консоль.
        /// </summary>
        public static void Task3()
        {
            string insertedString = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string splitter = "abc";

            int indexOfabc = insertedString.IndexOf(splitter);
            string firstPart = insertedString.Substring(0, indexOfabc);
            string secondPart = insertedString.Substring(indexOfabc + splitter.Length);

            Console.WriteLine($"First part: {firstPart}\nSecond part: {secondPart}");
        }

        /// <summary>
        /// Дана строка: Good day 
        /// Необходимо с помощью метода substring удалить слово "Good".
        /// После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        /// Заменить последний "!" на "?" и вывести результат на консоль.
        /// </summary>
        public static void Task4()
        {
            string strGoodDay = "Good day";

            string strDay = strGoodDay.Substring("Good".Length);
            string a = strDay.Insert(0, "The best");
            int length = a.Length;
            string strBestDay = strDay.Insert(0, "The best").Insert(strDay.Length + "The best".Length, "!!!!!!!!!");
            string strResult = strBestDay.Remove(strBestDay.LastIndexOf('!')).Insert(strBestDay.LastIndexOf('!'), "?");

            Console.WriteLine(strResult);
        }

        /// <summary>
        /// Введите с консоли строку, которая будет содержать буквы и цифры.
        /// Удалите из исходной строки все цифры и выведите их на экран.
        /// (Использовать метод Char.IsDigit(), его не разбирали на уроке, посмотрите, пожалуйста, документацию этого метода самостоятельно)
        /// </summary>
        public static void Task5()
        {
            Console.Write("Enter a string: ");
            var text = Console.ReadLine();
            Console.WriteLine();

            var newText = new StringBuilder();

            foreach (var ch in text)
            {
                if (!char.IsDigit(ch))
                {
                    newText.Append(ch);
                }
            }

            Console.Write("String without numbers: ");
            Console.WriteLine(newText.ToString());
        }

        /// <summary>
        /// Задайте 2 предложения из консоли. Для каждого слова первого предложения определите количество его вхождений во второе предложение.
        /// </summary>
        public static void Task6()
        {
            Console.Write("Enter a stringOne: ");
            string strOne = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter a stringTwo: ");
            string strTwo = Console.ReadLine();
            Console.WriteLine();

            string[] wordsOne = strOne.Split();
            string[] wordsTwo = strTwo.Split();

            int[] occurrences = new int[wordsOne.Length];

            for (int i = 0; i < wordsOne.Length; i++)
            {
                foreach (var word in wordsTwo)
                {
                    if (word.Equals(wordsOne[i], StringComparison.OrdinalIgnoreCase))
                    {
                        occurrences[i]++;
                    }
                }
            }

            for (int i = 0; i < wordsOne.Length; i++)
            {
                Console.WriteLine($"The word \"{wordsOne[i]}\" has {occurrences[i]} occurrences in a sentence stringTwo");
            }
        }
    }
}