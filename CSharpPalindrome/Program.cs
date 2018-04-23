using System;

namespace CSharpPalindrome
{
    class Program
    {


        static void Main(string[] args)
        {
            int i, n, b, rev = 0;

            Console.WriteLine("Please enter the number of which you would like to see how many " +
                "palindromes exist up to, then press enter;");

            int input = int.Parse(Console.ReadLine());

            for (i = 0; i <= input; i++)
            {
                n = i;
                while (n > 0)
                {
                    b = n % 10;
                    rev = rev * 10 + b;
                    n = n / 10;
                }

                if (rev == i)
                {
                    Console.WriteLine(i + " ");
                    Console.ReadLine();
                    Console.WriteLine("Press enter to close...");
                    Console.ReadLine();
                }
                rev = 0;
            }
        }
    }
}

