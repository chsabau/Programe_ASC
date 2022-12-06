using System;
namespace _2
{
    public class p13
    {
        static void Main(string[] args)
        {
            int y1, y2, i,x=0;
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());

            for (i = y1; i <= y2; i++)
            {
                if (i % 4 == 0)
                    x++;
            }
            Console.WriteLine("sunt" + x + "ani bisecti");
            
                
        }
    }
}

