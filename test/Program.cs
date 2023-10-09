using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст из нескольких слов:");
            string inputText = Console.ReadLine();

            string[] words = inputText.Split(' ');

            Console.WriteLine("Слова с перенесенными последними буквами в начало:");

            foreach (string word in words)
            {
                if (word.Length < 2)
                {
                    Console.Write(word + " ");
                }
                else
                {
                    char lastLetter = word[word.Length - 1];
                    string restOfWord = word.Substring(0, word.Length - 1);
                    string modifiedWord = lastLetter + restOfWord;
                    Console.Write(modifiedWord + " ");
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
