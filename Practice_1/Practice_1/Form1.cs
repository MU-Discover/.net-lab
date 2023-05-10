namespace Practice_1
{
    public partial class Form1 : Form
    {
        private double nombe1=0;
        private double nombe2=0;
        private double rs=0;
        private int isSgned = 0;
        private char sg;
        public Form1()
        {
            InitializeComponent();
        }
        //------------------
        public void numb(string val)
        {
            if (screen.Text == "" || screen.Text == "0")
            {
                screen.Text = val;
            }
            else
            {
                screen.Text = screen.Text + val;
            }
            if (lbRst.Text == "" || lbRst.Text == "0")
            {
                lbRst.Text = val;
            }
            else
            {
                lbRst.Text = lbRst.Text + val;
            }
        }
        //----------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (screen.Text.Contains("."))
            {

            }
            else
            {
                if (screen.Text == "")
                {
                    screen.Text = "0.";
                    if (lbRst.Text == "0")
                    {
                        lbRst.Text = screen.Text;
                    }
                    else
                    {
                        lbRst.Text=lbRst.Text + screen.Text;
                    }
                }
                else
                {
                    screen.Text = screen.Text + ".";
                    if (lbRst.Text == "0")
                    {
                        lbRst.Text = ".";
                    }
                    else
                    {
                        lbRst.Text = lbRst.Text + ".";
                    }
                }
            }
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            numb("1");
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            numb("2");
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            numb("3");
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            numb("4");
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            numb("5");
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            numb("6");
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            numb("7");
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            numb("8");
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            numb("9");
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            screen.Text = "";
            lbRst.Text = "0";
            this.isSgned = 0;
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            if (this.isSgned == 1)
            {
                this.nombe1 = this.rs;
                screen.Text = "";
                lbRst.Text = this.rs + " / ";
                this.sg = '/';
            }
            else
            {
                this.nombe1 = double.Parse(screen.Text);
                screen.Text = "";
                lbRst.Text = lbRst.Text + " / ";
                this.sg = '/';
                this.isSgned = 1;
            }
        }

        private void btmt_Click(object sender, EventArgs e)
        {
            if (this.isSgned == 1)
            {
                this.nombe1 = this.rs;
                screen.Text = "";
                lbRst.Text = this.rs + " * ";
                this.sg = '*';
            }
            else
            {
                this.nombe1 = double.Parse(screen.Text);
                screen.Text = "";
                lbRst.Text = lbRst.Text + " * ";
                this.sg = '*';
                this.isSgned = 1;
            }
        }
        private void bt0_Click(object sender, EventArgs e)
        {
            numb("0");
        }
        //-----TO CHOSE SIGN------
        public void sign(double num1, char sign, double num2)
        {
            switch(sign)
            {
                case '+':
                    this.rs = num1 + num2;
                    lbRst.Text = lbRst.Text + " = " + this.rs;
                    break;
                case '-':
                    this.rs = num1 - num2;
                    lbRst.Text = lbRst.Text + " = " + this.rs;
                    break;
                case '*':
                    this.rs = num1 * num2;
                    lbRst.Text = lbRst.Text + " = " + this.rs;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        MessageBox.Show("Division by zero is invalid !");
                    }
                    this.rs = num1 / num2;
                    lbRst.Text = lbRst.Text + " = " + this.rs;
                    break;
            }
        }
        private void bteq_Click(object sender, EventArgs e)
        {
            sign(this.nombe1, this.sg, double.Parse(screen.Text));
        }

        private void btplus_Click(object sender, EventArgs e)
        {
            if (this.isSgned == 1)
            {
                this.nombe1 = this.rs;
                screen.Text = "";
                lbRst.Text = this.rs + " + ";
                this.sg = '+';
            }
            else
            {
                this.nombe1 = double.Parse(screen.Text);
                screen.Text = "";
                lbRst.Text = lbRst.Text + " + ";
                this.sg = '+';
                this.isSgned = 1;
            }
        }
        private void btmn_Click(object sender, EventArgs e)
        {
            if (this.isSgned == 1)
            {
                this.nombe1 = this.rs;
                screen.Text = "";
                lbRst.Text = this.rs + " - ";
                this.sg = '-';
            }
            else
            {
                this.nombe1 = double.Parse(screen.Text);
                screen.Text = "";
                lbRst.Text = lbRst.Text + " - ";
                this.sg = '-';
                this.isSgned = 1;
            }
        }
    }
}