using System;
namespace _1
{
    public class program2
    {
        static void Main(string[] args)
        {

            int a, b, c;
            double d, x1, x2;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());


            d = Math.Sqrt(b * b - 4 * a * c);

            if (a != 0)
            {

                if (d >= 0)
                {
                    x1 = (-b + d) / (2 * a);
                    x2 = (-b - d) / (2 * a);
                    Console.WriteLine("Solutia este = {0} si {1}", x1, x2);
                }

                else
                    Console.WriteLine("Solutia este imposibila");
            }

              else
                 if (b != 0)
              {
                x1 = -c / b;
                Console.WriteLine("Solutia este = {0}", x1);


              }
            else
                if (c == 0)
                Console.WriteLine("Solutia este nedeterminata");
            else
                Console.WriteLine("Solutia este imposibila");


        }
    }
}

