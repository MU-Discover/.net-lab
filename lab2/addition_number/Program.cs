using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FOTO SAAKOU JERY KHENSON - 92220103012");
            Console.Write("Enter the 1st number:\n#>");
            int nb1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the 2sd number:\n#>");
            int nb2 = int.Parse(Console.ReadLine());

            int rslt=nb1+ nb2;
                    Console.WriteLine(nb1 + " + " + nb2 + " = " + rslt);
              
            Console.ReadKey();
        }
    }
}
