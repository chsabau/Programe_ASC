using System;
namespace _2
{
    public class p10
    {
        static void Main(string[] args)
        {
            float n;
            int i, k=0;
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    k++;
            }

            if (k == 2)
                Console.WriteLine("Numarul este prim");
            else
                Console.WriteLine("Numarul nu este prim ");
        }
    }
}
