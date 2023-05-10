using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Lab14a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Select operation
        public double operation(int op, double num1,double num2)
        {
            double result = 0;
            switch(op)
            {
                case 0://Addition
                    result= num1+num2;
                    break;
                case 1://Subtraction
                    result = num1 - num2;
                    break;
                case 2://Multiplication
                    result = num1 * num2;
                    break;
                case 3://Division
                    result = num1 / num2;
                    break;
            }
            return result;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            double rslt = operation(0, double.Parse(txt1.Text), double.Parse(txt2.Text));
            txt3.Text = txt1.Text + " + " + txt2.Text + " = " + rslt;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            double rslt = operation(1, double.Parse(txt1.Text), double.Parse(txt2.Text));
            txt3.Text = txt1.Text + " - " + txt2.Text + " = " + rslt;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            double rslt = operation(2, double.Parse(txt1.Text), double.Parse(txt2.Text));
            txt3.Text = txt1.Text + " x " + txt2.Text + " = " + rslt;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            double rslt = operation(3, double.Parse(txt1.Text), double.Parse(txt2.Text));
            txt3.Text = txt1.Text + " / " + txt2.Text + " = " + rslt;
        }

        private void txt2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
