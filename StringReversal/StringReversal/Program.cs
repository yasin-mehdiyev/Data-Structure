using System;

namespace StringReversal
{
    class Program
    {
        //Reverse String With Function 
        public static string Reverse(string str)
        {
            string reversed = "";
            for (int i = str.Length-1; i >= 0; i--)
            {
                reversed += str[i];
            }
            return reversed;
        }

        //Reverse String With Recursive Function
        public static string ReverseRecursion(string str)
        {
            string reversedRecursive = "";

            if (str.Length>0)
            {
                reversedRecursive += str[str.Length-1] + ReverseRecursion(str.Substring(0, str.Length - 1));
                return reversedRecursive;
            }
            return str;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Please,Enter to keyboard String" );
            string word = Console.ReadLine();

            //Reverse String With Function
            //Console.WriteLine("Result = {0} ",Reverse(word));

            //Reverse String With Recursive Function
            //Console.WriteLine("Result = {0} ",ReverseRecursion(word));


            Console.ReadKey();
        }
    }
}
