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

namespace WinDBConnection
{
    public partial class ViewListEmp : Form
    {
        DataTable dt = null;
        public ViewListEmp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewListEmp_Load(object sender, EventArgs e)
        {

            dt = new DataTable();
            string connstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                string query = @"select * from emp;";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                try
                {
                    conn.Open();
                    da.Fill(dt);
                    da.Dispose();
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
