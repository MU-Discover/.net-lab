using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Lab5
{
    public class Base
    {
        public void fun()
        {
            Console.Write("Hi ");
        }
        public void fun(int f)
        {
            Console.Write("Hello ");
        }
    }
    public class Derived : Base
    {
        public void fun()
        {
            base.fun();
            Console.Write(" Bye");
        }
    }
    internal class TestExam
    {
        //public static void Main(string[] args)
        //{
        //    Derived d;
        //    d=new Derived();
        //    d.fun();
        //    d.fun(78);

        //    Console.ReadKey();
        //}
    }
}
