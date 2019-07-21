using System;
using System.Text.RegularExpressions;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex rx = new Regex("[^a-zA-Z]");
            string word = Console.ReadLine();
            word = rx.Replace(word, "");
            bool success = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    success = false;
                    break;
                }
            }
            if (success)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
