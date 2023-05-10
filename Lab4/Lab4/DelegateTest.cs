using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    public delegate int delegateNum(int n);
    internal class DelegateTest
    {
            public static int num = 10;
            public static int add(int n)
            {
                num += n;
                return num;
            }
            public static int mul(int n)
            {
                num *= n;
                return num;
            }
            public static int getnum()
            {
                return num;
            }
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("--Name:MUTABAZI SHEMA TRESOR PATERNE.\n--En. 92220103041");
        //    delegateNum delN1 = new delegateNum(add);
        //    delegateNum delN2 = new delegateNum(mul);
        //    delN1(25);
        //    Console.WriteLine("Value of num: " + getnum());
        //    delN2(40);
        //    Console.WriteLine("Value of num: " + getnum());
        //    Console.ReadKey();
        //}
    }

    
}
