using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinDBConnection
{
    public partial class createEmp : Form
    {
        public createEmp()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            name.Text= string.Empty;
            designation.Text= string.Empty;
            department.Text= string.Empty;
            salary.Text= string.Empty;
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || designation.Text == "" || department.Text == "" || salary.Text == "")
            {
                MessageBox.Show("kindly fill all details....");
            }
            else
            {
                string connstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    string query = @"insert into emp values('" + name.Text + "','" + designation.Text + "','" + department.Text + "'," + int.Parse(salary.Text) + ");";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Added..!!");
                        reset_Click(this, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
