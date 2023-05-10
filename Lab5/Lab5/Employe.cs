using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Employe
    {
        private string name;
        private string designation;
        private string department;
        private int salary;

        //Constructor
        public Employe(string name, string designation, string department, int salary)
        {
            this.name = name;
            this.designation = designation;
            this.department = department;
            this.salary = salary;
        }

        //accessors 
        //Get methods
        public string getName() { return name; }
        public string getDesignation() { return designation; }
        public string getDepartment() { return department; }
        public int getSalary() { return salary;}
        //set methods
        public void setDesignation(string designation) { this.department=designation; }
        public void setDepartment(string department) { this.department = department; }
        public void setSalary(int salary) { this.salary=salary;}

        public void toString()
        {
            Console.WriteLine("Employe :\n\tName : {0}\n\tDesignation : {1}\n\tDepartment : {2}\n\tSalary : {3}.", this.name, this.designation, this.department, this.salary);
        }
    }
}
