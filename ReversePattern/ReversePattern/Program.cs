using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int x = 1; x <= 4; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //reverse pattern
            for (int x = 1; x <= 4; x++)

            {
                for (int y = 4; y >= x; y--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
