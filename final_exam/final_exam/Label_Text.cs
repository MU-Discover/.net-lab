using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_exam
{
    public partial class Label_Text : UserControl
    {
        public Label_Text()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
