using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            double k = 0;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            while ((Math.Pow(3, k) > n) == false)
            {
                k++;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
