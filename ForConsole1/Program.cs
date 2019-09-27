using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, res;
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            res = 1;
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= b - a; i++)
            {
                res = res * (a + i);
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
