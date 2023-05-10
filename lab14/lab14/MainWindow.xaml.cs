using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string gender;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string firstname = name.Text;
            string enrolmentsNo = enrolment.Text;
            string e_mail = email.Text;
            string mobilePhone = mobile.Text;
            string semester_NO = semester.Text;
            string DOB= dob.Text;
            if (email.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                email.Focus();
            }
            else if (!Regex.IsMatch(email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                email.Select(0, email.Text.Length);
                email.Focus();
            }else if (gender == null)
            {
                errormessage.Text = "Enter gender.";
            }
            else
            {
                errormessage.Text = "";
                    string address = dob.Text;
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Students(FirstName, enrolmentsNo, Email, mobilePhone, Semester, gender, birthDate) values('" + firstname + "','" + enrolmentsNo + "','" + e_mail + "','" + mobilePhone + "','" + semester_NO + "','" + gender + "','" + DOB + "')", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    errormessage.Text = "You have Registered successfully.";
                MessageBox.Show("STUDENT INFOS \nName :" + firstname + "\nEnrolment :" + enrolmentsNo + "\nE-mail :" + e_mail + "\nMobile :" + mobilePhone + "\nSemester :" + semester_NO + "\nGender : " + gender + "\nBirth date : " + DOB);
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (gender_male.IsChecked == true)
                gender = (string)gender_male.Content;
            else
                gender = (string)gender_female.Content;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("create table Students(id int identity(1,1) primary key, FirstName varchar(20),enrolmentsNo varchar(20),Email varchar(20),mobilePhone varchar(20),Semester varchar(20), gender varchar(20), birthDate varchar(20))", con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Tâble created with succes !");
        }
    }
}
