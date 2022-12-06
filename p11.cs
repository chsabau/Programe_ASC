using System;
namespace _2
{
    public class p11
    {
        static void Main(string[] args)
        {
            int n, x=0 ;
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                x = n % 10;
                n = n / 10;

                Console.Write("" + x);
            }

        }
    }
}

