using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double res=0;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=n; i++)
            {
                res += 1.0 / i;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
