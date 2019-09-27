using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 10;
            double p;
            int k = 0;
            Console.Write("p = ");
            p = Convert.ToDouble(Console.ReadLine());
            if (p > 0 && p < 50)
            {
                while (s < 200)
                {
                    s = s + p / 100.0 * s;
                    k++;
                }
                string res = string.Format($"s = {s}, k = {k}");
                Console.WriteLine(res);
            }
            else Console.WriteLine("Ошибка");
            Console.ReadKey();

        }
    }
}
