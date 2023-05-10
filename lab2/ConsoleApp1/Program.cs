using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elective_bill;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("FOTO SAAKOU JERY KHENSON - 92220103012");
        string[] subjects = { "IP", "TAFL", "SE", "CS", "DAA" };
        int[] notes = { 0, 0, 0, 0, 0 };
        int average,total_note=0;

        for(int i =0; i< subjects.Length;i++)
        {
            Console.Write("Enter "+subjects[i]+ " note :\n#>");
            notes[i] = int.Parse(Console.ReadLine());
            total_note += notes[i];
        }
        average = total_note/notes.Length;
        Console.WriteLine("Your average is : {0}",average);
        //DECISSION
        if(average < 35)
        {
            Console.WriteLine("Failed !");
        }
        else if (average >= 36 && average <= 60)
        {
            Console.WriteLine("Pass !");
        }
        else if (average >= 61 && average <= 80)
        {
            Console.WriteLine("Very Good !");
        }
        else
        {
            Console.WriteLine("Excellent !");
        }

        Console.ReadKey();
    }
}
