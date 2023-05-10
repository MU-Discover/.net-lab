using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public delegate double delegateCal(double nbr1, double nbr2);
    internal class Calculator
    {
        public static double rslt = 0;
        public static double add(double n1, double n2)
        {
            rslt = n1 + n2;
            return rslt;
        }
        public static double sub(double n1, double n2)
        {
            rslt = n1 - n2;
            return rslt;
        }
        public static double mul(double n1, double n2)
        {
            rslt = n1 * n2;
            return rslt;
        }
        public static double div(double n1, double n2)
        {
            rslt = n1 / n2;
            return rslt;
        }
        public static double getResult()
        {
            return rslt;
        }

        //test Method
        //static void Main(string[] args)
        //{
        //    delegateCal cal;
        //    Console.Write("Enter the first number\n #>");
        //    double nbr1 = double.Parse(Console.ReadLine());
        //    Console.Write("Enter the second number\n #>");
        //    double nbr2 = double.Parse(Console.ReadLine());
        //    Console.Write("[1] - Addition;\n[2] - Substraction;\n" +
        //        "[3] - Multiplication;\n[4] - Division;\n" +
        //        "Enter your choice: \n#>");
        //    int ch = int.Parse(Console.ReadLine());

        //    switch (ch)
        //    {
        //        case 1:
        //            Console.WriteLine("--------Addition--------");
        //            cal = new delegateCal(add);
        //            cal(nbr1, nbr2);
        //            Console.Write("{0} + {1} = {2}", nbr1, nbr2, getResult());
        //            break;
        //        case 2:
        //            Console.WriteLine("--------Substraction--------");
        //            cal = new delegateCal(sub);
        //            cal(nbr1, nbr2);
        //            Console.Write("{0} - {1} = {2}", nbr1, nbr2, getResult());
        //            break;
        //        case 3:
        //            Console.WriteLine("--------Multiplication--------");
        //            cal = new delegateCal(mul);
        //            cal(nbr1, nbr2);
        //            Console.Write("{0} X {1} = {2}", nbr1, nbr2, getResult());
        //            break;
        //        case 4:
        //            Console.WriteLine("--------Division--------");
        //            cal = new delegateCal(div);
        //            cal(nbr1, nbr2);
        //            Console.Write("{0} / {1} = {2}", nbr1, nbr2, getResult());
        //            break;
        //        default:
        //            Console.WriteLine("Operation Not Found !");
        //            break;
        //    }
        //    Console.WriteLine("\n-----Student-------");
        //    Console.WriteLine("--Name:MUTABAZI SHEMA TRESOR PATERNE.\n--En. 92220103041");
        //    Console.ReadKey();

        //}
    }
}
