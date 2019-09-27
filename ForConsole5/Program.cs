using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double res = 0;
            double step = 1;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                step *=i;
                res += step;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
