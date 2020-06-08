using System;

namespace Palindroms
{
    class Program
    {
        //Palindroms Words with Function
        public static bool isPalindromes(string str)
        {
            int initilIndex = 0;
            int lastIndex = str.Length - 1;

            while (lastIndex>initilIndex)
            {
                if (str[initilIndex++]!=str[lastIndex--])
                {
                    return false;
                }
            }
            return true;
        }

        //Palindroms Words with Recursive Function
        public static bool isPalindromsWithRecursion(string str)
        {
            if (str.Length<=1)
            {
                return true;
            }
            else
            {
                if (str[0]!=str[str.Length-1])
                {
                    return false;
                }
                else
                {
                    return isPalindromes(str.Substring(1, str.Length - 2));
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter String Word");
            string str = Console.ReadLine();

            //if (!isPalindromes(str))
            //{
            //    Console.WriteLine("False,It is not a palinrom word");
            //}
            //else
            //{
            //    Console.WriteLine("True,It is a palinrom word");
            //}

            if (!isPalindromsWithRecursion(str))
            {
                Console.WriteLine("False,It is not a palinrom word");
            }
            else
            {
                Console.WriteLine("True,It is a palinrom word");
            }

            Console.ReadKey();
        }
    }
}
