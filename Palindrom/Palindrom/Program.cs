using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string str2, str1;
            int nb1, nb2;

            Console.WriteLine("Enter n value: ");
            str1 = Console.ReadLine();

            char[] ch = new char[str1.Length];
            str2 = str1;
            int j = 0;

            //reverse number
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                ch[j] = str1[i];
                j++;
            }
            str2 = new string(ch);

            nb1 = int.Parse(str1);
            nb2 = int.Parse(str2);
            if (nb1 == nb2)
            {
                Console.WriteLine("The number is Palindrome");
            }
            else
            {
                Console.WriteLine("The number is not Palindrome");
            }

            Console.ReadKey();

        }
    }
}
