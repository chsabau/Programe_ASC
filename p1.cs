using System;
using _1;
namespace ecgr1
{
    class P1
    {

        static void Main(string[] args)
        {
            int a, b, x;
            Console.WriteLine("Introduceti numerele:");

                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine("Solutia este = {0}", x);


            }
            else
                if (b == 0)
                Console.WriteLine("Solutia este nedeterminata");
                else
                Console.WriteLine("Solutia este imposibila");
            mat mat = new mat();
            mat.mat_function();
        }
    }
}