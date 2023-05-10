// See https://aka.ms/new-console-template for more information

Console.WriteLine("FOTO SAAKOU JERY KHENSON - 92220103012");
Console.Write("Enter the 1st number:\n#>");
int nb1 = int.Parse(Console.ReadLine());

Console.Write("Enter the 2sd number:\n#>");
int nb2 = int.Parse(Console.ReadLine());

if(nb1 > nb2)
{
    Console.WriteLine("The max is "+nb1);
}else if (nb1 < nb2)
{
    Console.WriteLine("The max is " + nb2);
}
else
{
    Console.WriteLine("The numbers are egal");
}
Console.ReadKey();
