using System;
namespace _9
{
    public class p9
    {
        static void Main(string[] args)
        {
            int n, i;
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write(" "+ i);

            }

        }
    }
}

