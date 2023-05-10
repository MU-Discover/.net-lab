using System.Windows.Forms;

namespace final_exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lb1.Items.Add(txt1.Text);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            cb1.Items.Add(lb1.SelectedItem);
            lb1.Items.Remove(lb1.SelectedItem);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lb1.Items.Count; i++)

            {
                cb1.Items.Add(lb1.Items[i]);
                lb1.Items.Remove(lb1.Items[i]);

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            cb1.Items.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Red);
            // g.DrawPie(p);
            //g.DrawRectangle(p, 10, 10, 100, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            DialogResult r = printPreviewDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}