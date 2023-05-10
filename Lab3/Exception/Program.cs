// See https://aka.ms/new-console-template for more information
int[] numb = new int[10];
int som = 0;
try
{

    Console.WriteLine("Enter the number of elements :");
    int N = int.Parse(Console.ReadLine());
    for (int i=0; i<N; i++)
    {
        Console.Write("Enter the 1 Number :\n#>");
        numb[i] = int.Parse(Console.ReadLine());
        som += numb[i];
    }

    Console.WriteLine("Average is : " + (som / N));
}
catch(IndexOutOfRangeException e) {
    Console.WriteLine("Maximum 10 number is alow !");
}
