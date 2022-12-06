using System;
namespace _2
{
    public class p12
    {
        static void Main(string[] args)
        {
            int a, b, n, x=0,i ;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            for(i=a;i<=b;i++)
            {
                if (i % n == 0)
                    x++;


            }
            Console.WriteLine("Sunt " + x + " numere");

        }
    }
}

