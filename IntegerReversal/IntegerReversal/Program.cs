using System;

namespace IntegerReversal
{
    class Program
    {

        // 900-intReversal 9, 567- intReversal 765
        // IntegerReversal with Function
        public static int intReversal(int num)
        {
            int remainder = 0;
            while (num!=0)
            {
                int x = num % 10;
                remainder = remainder * 10 + x;
                num = (num - x) / 10;
            }
            return remainder;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Please,Enter any number");
            int number = Convert.ToInt32(Console.ReadLine());


            //if (number<0)
            //{
            //    number = number * -1;
            //}

            Console.WriteLine("Reversal Integer: {0}", intReversal(number));
            Console.ReadKey();
        }
    }
}
