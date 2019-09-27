using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, k, res;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("k = ");
            res = 0;
            k = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=n;i++)
            {
                res = res + Math.Pow(i, k);
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
