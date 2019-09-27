using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,sum = 0;
            do
            {
                a = Convert.ToDouble(Console.ReadLine());
                sum +=a;
            } while (a != 0);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
