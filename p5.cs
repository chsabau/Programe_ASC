using System;
namespace _5
{
    public class p5
    {
        static void Main(string[] args)
        {
            int a, k, x=0;
            a = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            
            while (a != 0 && (k-1) != 0)
            {
                a = a / 10;
                k = k - 1;
                x = a % 10;
            }


            Console.WriteLine("Cifra este : {0}", x);   

        }
    }
}

