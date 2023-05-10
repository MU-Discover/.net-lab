using System;

public class Information
{
    protected string first_name;
    protected string last_name;
    protected double contact;

    //Default constructor
    public Information() { 
    
    }
    //Constructor with parameter
    public Information(string first_name, string last_name, double contact)
    {
        this.first_name = first_name;
        this.last_name = last_name;
        this.contact = contact;
    }
    public Information(Information infos)
    {
        this.first_name=infos.first_name;
        this.last_name=infos.last_name;
        this.contact=infos.contact;
    }
    //init datas
    public void init_data()
    {
        Console.Write("Enter your First_name:\n#>");
        string fName = Console.ReadLine();
        this.setFirstName(fName);
        Console.Write("Enter your Last_name:\n#>");
        string lName = Console.ReadLine();
        this.setLastName(lName);
        Console.Write("Enter your Contact:\n#>");
        double contact = double.Parse(Console.ReadLine());
        this.setContact(contact);
    }
    public string getFastName()
    {
        return this.first_name;
    }

    public string getLastName()
    {
        return this.last_name;
    }
    public double getContact()
    {
        return this.contact;
    }
    public void setContact(double contact)
    {
        this.contact = contact;
    }
    public void setFirstName(string first_name)
    {
        this.first_name=first_name;
    }
    public void setLastName(string last_name)
    {
        this.last_name=last_name;
    }
    public void toString() {
        Console.Write("Farst Name: {0} , Last Name: {1}, Contact: {2},\n",first_name, last_name, contact);
    }//Student : FOTO SAAKOU JERY KHENSON - 92220103012
}
public class Student : Information
{
    private int semester;

    //default constructor
    public Student()
    {
        this.semester = 1;
    }
    public void setSemester(int semester)
    {
        this.semester = semester;
    }
    public int getSemester()
    {
        return this.semester;
    }
    public void init_data()
    {
        base.init_data();
        Console.Write("Enter your semester:\n#>");
        this.setSemester(int.Parse(Console.ReadLine()));
    }

    public void toString()
    {
        base.toString();
        Console.WriteLine("Semester: " + this.semester);
    }
}
/****
 * Name: FOTO SAAKOU JERY KHJENSON
 * Enr.NO: 92220103012
 */
public class Employee : Information
{
    private float salary;

    //default constructor
    public Employee()
    {
        this.salary = 1;
    }
    public void setSalary(float salary)
    {
        this.salary = salary;
    }
    public float getSalary()
    {
        return this.salary;
    }
    public void init_data()
    {
        base.init_data();
        Console.Write("Enter your salary:\n#>");
        this.setSalary(float.Parse(Console.ReadLine()));
    }

    public void toString()
    {
        base.toString();
        Console.WriteLine("Salary: {0} Rs.", this.salary);
    }
    /****
     * Name: FOTO SAAKOU JERY KHJENSON
     * Enr.NO: 92220103012
     */
}

public class Test
{
    static void Main(string[] args)
    {
        Console.WriteLine("You are ?\n[1] - Student\n[2] - Employee");
        int ch=int.Parse(Console.ReadLine());

        switch (ch)
        {
            case 1:
                Student st = new Student();
                st.init_data();
                st.toString(); 
                break;
            case 2:
                Employee ep=new Employee();
                ep.init_data();
                ep.toString();
                break;
            default:
                Console.WriteLine("Error Please make a good choice");
                break;
        }
        Console.WriteLine("************************************************************");
        Console.WriteLine("**  Name: FOTO SAAKOU JERY KHENSON");
        Console.WriteLine("**  Enr.NO: 92220103012");
        Console.ReadKey();
    }
}