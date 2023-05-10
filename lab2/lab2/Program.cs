using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FOTO SAAKOU JERY KHENSON - 92220103012");
        Console.Write("Enter your array:\n#> ");
        string ar=Console.ReadLine();
        char[] ch = new char[ar.Length];
        int j = 0;
        string reverse_string;
        for(int i= ar.Length-1; i >=0; i--)
        {
            ch[j] = ar[i];
            j++;
        }
        reverse_string=new string(ch); 
        Console.WriteLine("Reverse string : {0}", reverse_string);

        Console.ReadKey();

    }

}








//Console.WriteLine("Enter a number:");

//        int n = int.Parse(Console.ReadLine());
//        for (int i = n; i > 0; i--)
//        {
//            for(int j = 1; j<= i; j++)
//            {
//                Console.Write(i);
//            }
//            Console.WriteLine();
//        }











