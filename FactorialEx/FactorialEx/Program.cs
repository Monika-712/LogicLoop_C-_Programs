using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f = 1,num;
            Console.WriteLine("Enter Input Number :");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                f = f * i;
                Console.Write(f);
            }
            Console.ReadLine();
        }
    }
}
