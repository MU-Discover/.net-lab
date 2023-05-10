using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinDBConnection
{
    public partial class SearchEmp : Form
    {
        private string titleText= "Search employe";
        public void setTilteText(string text)
        {
            titleText += text;
        }
        public SearchEmp()
        {
            InitializeComponent();
            label1.Text = titleText;
        }

        private void SearchEmp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DataTable dt = null;
        private void SearchRecord(string query)
        {
            dt = new DataTable();
            query = @"select * from emp " + query;
            string connstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection conn = new SqlConnection(connstring))
            {
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
                finally { conn.Close(); }
            }
        }
        private void search_Click(object sender, EventArgs e)
        {

            string query = "where ";
            int flag = 0;
            if (searchBy.SelectedIndex.ToString().Equals("id"))
            {
                query += " emp_id =" + int.Parse(input.Text);
                flag = 1;
            }
            else if (searchBy.Text.Equals("name"))
            {
                query += " name like '%" + input.Text+"%'";
                flag = 1;
            }
            else if (searchBy.Text == "designation")
            {
                query += " designation like '%" + input.Text + "%'";
                flag = 1;
            }
            else if (searchBy.Text == "department")
            {
                query += " dept like '%" + input.Text + "%'";
                flag = 1;
            }
            else if (searchBy.Text == "salary")
            {
                query += " sal=" + int.Parse(input.Text);
                flag = 1;
            }
            query += ";";
            if (flag == 1)
                SearchRecord(query);
        }
    
    }
}
