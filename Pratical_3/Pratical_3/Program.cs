// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace Pratical_3
{
    public class Poly
    {
        public void getArea(float r)
        {
            double pi = Math.PI;
            Console.WriteLine("Circle : ");
            Console.WriteLine("Area is " + (r * pi * pi));
        }

        public void getArea(double l, double L)
        {
            Console.WriteLine("Rectangle : ");
            Console.WriteLine("Area is " + (l * L));
        }

        public void getArea(double l)
        {
            Console.WriteLine("Square : ");
            Console.WriteLine("Area is " + (l * l));
        }
    }
    public class Program
    {
        static void Main(String[] args)
        {
            //create instance of Poly class
            Poly p =new Poly();

            //Enter information about Circle: his raduis
            Console.Write("Enter the Circle radius : \n#>");
            float r=float.Parse(Console.ReadLine());
            p.getArea(r);

            //Enter information about Rectangle
            Console.Write("Enter the Rectangle width : \n#>");
            double w = float.Parse(Console.ReadLine());
            Console.Write("Enter the Rectangle length : \n#>");
            double l = float.Parse(Console.ReadLine());
            p.getArea(w, l);

            //Enter information about Square
            Console.Write("Enter the Square size : \n#>");
            double s = float.Parse(Console.ReadLine());
            p.getArea(s);

            Console.WriteLine("       ======Student======     \nName: FOTO SAAKOU JERY KHENSON\nEn.NO:92220103012");
            Console.ReadKey();
        }
    }
}
