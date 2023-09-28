using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static string IsPalindrome(string palindrom)
        {
            char[] charArray = palindrom.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);

            if (palindrom == reversed)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string palindrom = Console.ReadLine();

            Console.WriteLine(palindrom);
            Console.WriteLine(IsPalindrome(palindrom));
        }
    }
}