using System;
using System.Text.RegularExpressions;

namespace RegEx2
{
    class Assgmn5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your text");
            string input = (Regex.Replace(Console.ReadLine(),"[^a-zA-Z]",""));
            input = input.ToLower();
            Console.WriteLine(input);
            string backwards = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                backwards += input[i].ToString();
            }
            Console.WriteLine(backwards);
            if (input == backwards)
            Console.WriteLine("this is a palindrome");
            else
            Console.WriteLine("this is not a palindrome");
        }
    }
}