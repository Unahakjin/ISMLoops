using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            double res=0;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                res = res + Math.Pow(i, n + 1 - i);
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
