using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Lab_5_6
    {
            string connstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            public SqlConnection connection()
            {
                SqlConnection con = new SqlConnection(connstring);
                return con;
            }

            public void createTable()
            {
                SqlConnection conn = connection();
                string query0 = @"drop table Emp_Detail";
                string query = @"create table Emp_Detail(emp_id int identity(1,1) primary key, name varchar(20), designation varchar(20), department varchar(20), salary int)";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand cmd0 = new SqlCommand(query0, conn);
                try
                {
                    conn.Open();
                    cmd0.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Table Employee created successfully !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Message : " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            // Add Item to table
            public void addItem(string name, string designation, string department, int salary)
            {
                SqlConnection conn = connection();
                string query = @"insert into Emp_Detail(name, designation, department, salary) values('" + name + "', '" + designation + "', '" + department + "'," + salary + ")";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Employe :\nName : {0}\tDesignation : {1}\tDepartement : {2}\tSalary : {3} Rs.", name, designation, department, salary);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Message : " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            //Delete functions
            public void deleteItem(int emp_ID)
            {
                SqlConnection conn = connection();
                string query = @"delete from Emp_Detail where emp_id = " + emp_ID + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Employe with ID :" + emp_ID);
                }
                catch (Exception e) { Console.WriteLine("Error: " + e.Message); }
                finally
                {
                    conn.Close();
                }
            }
            //Get all records from table Employe_detail
            public void getAll()
            {
                SqlConnection conn = connection();
                string query = @"select * from Emp_Detail";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        Console.WriteLine("------------------- All employe -------------------");
                        Console.WriteLine("Emp_ID \t Name \t Designation \t Department \t Salary");
                        Console.WriteLine("----------------------------------------------------------");
                        while (rs.Read())
                        {
                            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}"
                                , rs[0], rs[1], rs[2], rs[3], rs[4]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Message : " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            //Get a single item
            public void getItem(int emp_ID)
            {
                SqlConnection conn = connection();
                string query = @"select * from Emp_Detail where emp_id=" + emp_ID + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        Console.WriteLine("------------------- All employe -------------------");
                        Console.WriteLine("Emp_ID \t Name \t Designation \t Department \t Salary");
                        Console.WriteLine("----------------------------------------------------------");
                        while (rs.Read())
                        {
                            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}"
                                , rs[0], rs[1], rs[2], rs[3], rs[4]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : " + ex.Message);
                }
                finally { conn.Close(); }
            }

            //Clear all the data
            public void clearAll()
            {
                SqlConnection conn = connection();
                string query = @"delete from Emp_Detail";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("All the records deleted with succes !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : " + ex.Message);
                }
                finally { conn.Close(); }
            }
            public static void Main(String[] args)
            {
                EmpTable empTable = new EmpTable();
                empTable.createTable();
                Employe emp;
                int emp_ID, ans;
                //menu
                Boolean bol = true, bol1 = true;
                while (bol)
                {
                    Console.Write("========== MAIN MENU ==========\n[1] - Create new employe;" +
                        "\n[2] - View employe list;\n[3] - Search a specific employe;\n[4] - Delete informations of a specific employe;\n" +
                        "[5] - Clear employe table;\n[6] - Exit;\n\t Your choice : ");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Console.Write("Enter Employe Name : \n#>");
                            string name = Console.ReadLine();
                            Console.Write("Enter Employe Designation : \n#>");
                            string designation = Console.ReadLine();
                            Console.Write("Enter Employe Departement : \n#>");
                            string department = Console.ReadLine();
                            Console.Write("Enter Employe Salary : \n#>");
                            int salary = int.Parse(Console.ReadLine());

                            empTable.addItem(name, designation, department, salary); break;
                        case 2:
                            //insert the function to display all the employe here !
                            empTable.getAll(); break;
                        case 3:
                            Console.Write("Enter ID of employe to search :\n#>");
                            int emp_ID1 = int.Parse(Console.ReadLine());
                            //insert search function here !
                            empTable.getItem(emp_ID1); break;
                        case 4:
                            Console.Write("Enter ID of employe to remove :\n#>");
                            emp_ID = int.Parse(Console.ReadLine());
                            //function to delete employe !
                            do
                            {
                                Console.Write("Do you want to cofirm ?\n[1] - YES \t [2] - NO");
                                Console.Write("\n#>");
                                ans = int.Parse(Console.ReadLine());
                                if (ans == 1 || ans == 2)
                                {
                                    bol1 = false;
                                }
                            } while (bol1);
                            if (ans == 1)
                            {
                                //insert delete function
                                empTable.deleteItem(emp_ID);
                            }
                            break;
                        case 5:
                            Console.Write("Are you sure to want to clear table ?\n");
                            do
                            {
                                Console.Write("Do you want to cofirm ?\n[1] - YES \t [2] - NO");
                                Console.Write("\n#>");
                                ans = int.Parse(Console.ReadLine());
                                if (ans == 1 || ans == 2)
                                {
                                    bol1 = false;
                                }
                            } while (bol1);
                            if (ans == 1)
                            {
                                //insert delete function
                                empTable.clearAll();
                            }
                            break;
                        case 6:
                            bol = false;
                            break;
                        default:
                            Console.WriteLine("Please select the best menu !");
                            break;
                    }
                    Console.WriteLine("******************************************" +
                                    "\n* Name :FOTO SAAKOU JERY k.\n* En :92220103012");
                }
                Console.ReadKey();
            }

}
}

