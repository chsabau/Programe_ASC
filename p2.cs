using System;
namespace _1
{
    public class mat
    {
        public static void mat_function()
        {
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());


            if(n%k!=0)
                Console.WriteLine("Numerele nu se divid");
            else
                Console.WriteLine("Numerele se divid");
        }
    }
}

