
using Lab3;

Console.WriteLine("Enter the NO of apartement:");
int Ap_No = int.Parse(Console.ReadLine());

Console.WriteLine("*************Aparetment list**************");
Console.WriteLine("[1] - One BHK;\n[2] - Two BHK;\n[3] - Three BHK");
Console.Write("Your choice:\n#>");
int ch=int.Parse(Console.ReadLine());

switch (ch)
{
    case 1:
        OneBHK onebhk= new OneBHK();
        onebhk.setApartNO(Ap_No);
        onebhk.toString();
        break;
    case 2:
        TwoBHK twobhk=new TwoBHK();
        twobhk.setApartNO(Ap_No);
        twobhk.toString();
        break;
    case 3:
        ThreeBHK threebhk=new ThreeBHK();
        threebhk.setApartNO(Ap_No);
        threebhk.toString();
        break;
    default: 
        Console.WriteLine("Error!!!\nEnter good number of BHK !");
        break;
}

Console.WriteLine("*********************************\n*" + "  Name: Francis Juma O.\n  Er.no: 922201030412");