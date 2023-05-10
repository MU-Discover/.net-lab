using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    //interface Icredit
    //{
    //   public double deposit(double amount);
    //}
    //interface Idebit
    //{
    //    public double withdraw(double amount);
    //}
    //class Account: Icredit, Idebit
    //{
    //    double amount;
    //    //Contructors
    //    public Account()
    //    {
    //        amount = 1000;
    //    }
    //    public Account(double amount)
    //    {
    //        this.amount = amount;
    //    }
    //    public double deposit(double at) {
    //        amount += at;
    //        return amount;
    //    }
    //    public double withdraw(double at) {
    //        amount -= at;
    //        return amount;
    //    }
    //    public static void Main(String[] pars)
    //    {
    //        double amount = 0.0, new_amount;
    //        do
    //        {
    //            Console.Write("Enter the account opening amount(INR): \n#>");
    //            amount = double.Parse(Console.ReadLine());
    //        } while (amount < 0);
    //        Account account = new Account(amount);

    //        Console.WriteLine("---------- Choice of transaction type ----------");
    //        Console.Write("[1] - Deposit;\n[2] - Withdraw;\n    Your choice:\n#>");
    //        int ch = int.Parse(Console.ReadLine());
    //        switch (ch)
    //        {
    //            case 1:
    //                Console.Write("Enter the deposit amount :\n#>");
    //                double dp = double.Parse(Console.ReadLine());
    //                new_amount = account.deposit(dp);
    //                Console.WriteLine("The amount is : {0} INR", new_amount);
    //                break;
    //            case 2:
    //                Console.Write("Enter the amount to be remove :\n#>");
    //                double wd = double.Parse(Console.ReadLine());
    //                if (account.amount < wd)
    //                {
    //                    Console.WriteLine("The transaction is impossible !");
    //                }
    //                else
    //                {
    //                    new_amount = account.withdraw(wd);
    //                    Console.WriteLine("The amount is : {0} INR", new_amount);

    //                }
    //                break;
    //            default:
    //                Console.WriteLine("Not found !");
    //                break;
    //        }

    //        Console.WriteLine("\n-----Student-------");
    //         Console.WriteLine("--Name:MUTABAZI SHEMA TRESOR PATERNE.\n--En. 92220103041");
    //        Console.ReadKey();

    //    }
    //}








































    //    int ln = 4;
    //            for(int j=1; j<=5;j++)
    //            {
    //                Console.Write("\t");
    //                for (int k=ln; k > 0; k--)
    //                {
    //                        Console.Write(" ");
    //                }
    //for (int i = 1; i <= j; i++)
    //{
    //    Console.Write("* ");
    //}
    //Console.Write("\n");
    //ln -= 1;
    //            }
















































































    interface Iarea
    {
        public abstract double getArea(float r);
        public abstract double getArea(double l, double L);
        public abstract double getArea(double l);
    }
    internal class Interface : Iarea
    {
        public double getArea(float r)
        {
            double pi = Math.PI;
            return r * r * pi;
        }
        public double getArea(double l)
        {
            return l * l;
        }
        public double getArea(double l, double L)
        {
            return getArea(l * L);
        }
        public static void Main(String[] agrs)
        {
            Interface inter = new Interface();
            double area;
            Console.WriteLine("----------Chose Figure----------");
            Console.Write("[1] - Square;\n[2] - Circle;\n[3] - Rectangle;\n  " +
                "    Choosen your figure:\n#>");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.Write("Enter the length of the square :\n#>");
                    double c = double.Parse(Console.ReadLine());
                    area = inter.getArea(c);
                    Console.WriteLine("The area of square is :{0}", area);
                    break;
                case 2:
                    Console.Write("Enter the radius of the circle :\n#>");
                    float r = float.Parse(Console.ReadLine());
                    area = inter.getArea(r);
                    Console.WriteLine("The area of circle is :{0}", area);
                    break;
                case 3:
                    Console.Write("Enter the height of the rectangle :\n#>");
                    double l = double.Parse(Console.ReadLine());
                    Console.Write("Enter the widht of the rectangle :\n#>");
                    double L = double.Parse(Console.ReadLine());
                    area = inter.getArea(l, L);
                    Console.WriteLine("The area of rectangle is :{0}", area);
                    break;
                default:
                    Console.WriteLine("Operation Not Found !");
                    break;
            }

            Console.WriteLine("\n-----Student-------");
            Console.WriteLine("--Name:MUTABAZI SHEMA TRESOR PATERNE.\n--En. 92220103041");
            Console.ReadKey();
        }
    }
}
