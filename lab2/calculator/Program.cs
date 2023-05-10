using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FOTO SAAKOU JERY KHENSON - 92220103012");
            Console.Write("Enter the 1st number:\n#>");
            double nb1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the 2sd number:\n#>");
            double nb2 = double.Parse(Console.ReadLine());

            //print operators
            Console.WriteLine("[1]-Addition\n[2]-Substraction\n[3]-Multiplication\n[4]-Division");
            Console.Write("Choose operator:\n#>");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine(nb1 + " + " + nb2 + " = " + (nb1 + nb2));
                    break;
                case 2:
                    Console.WriteLine(nb1 + " - " + nb2 + " = " + (nb1 - nb2));
                    break;
                case 3:
                    Console.WriteLine(nb1 + " x " + nb2 + " = " + (nb1 * nb2));
                    break;
                case 4:
                    Console.WriteLine(nb1 + " / " + nb2 + " = " + (nb1 / nb2));
                    break;
                default:
                    Console.WriteLine("Oooops!!!!!!!\nOperator not found");
                    break;

            }
            Console.ReadKey();
        }
    }
}
