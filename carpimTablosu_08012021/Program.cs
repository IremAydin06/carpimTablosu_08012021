using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpimTablosu_08012021
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    int carpim = a * b;
                    Console.WriteLine($"{a} x {b} = {carpim}");
                }
                Console.WriteLine("-------------------");
            }
            Console.ReadLine();
        }
    }
}
