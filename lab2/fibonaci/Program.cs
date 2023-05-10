using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("FOTO SAAKOU JERY KHENSON - 92220103012");
            int F0 = 0,
                F1 = 1,
                Fn = 0;
            Console.WriteLine("Enter the Fibonacci index :");
            int val = int.Parse(Console.ReadLine());
            for (int i = 0; i <= val; i++)
            {
                if (i == 0)
                {
                    Console.Write("F(" + i + ") = " + F0 + "\t");
                }
                else if (i == 1)
                {
                    Console.Write("F(" + i + ") = " + F1 + "\t");
                }
                else
                {
                    Fn = F0 + F1;
                    Console.Write("F(" + i + ") = " + Fn + "\t");
                    F0 = F1;
                    F1 = Fn;
                }
            }
            Console.ReadKey();
        }
    }
}
