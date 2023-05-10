namespace Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p1 = new Pen(Color.Green, 4);
            Pen p2 = new Pen(Color.Red, 3);
            Pen p3 = new Pen(Color.Yellow, 5);

            g.DrawLine(p1, 200, 10, 200, 200);
            g.DrawLine(p2, 300, 10, 300, 200);
            g.DrawLine(p3, 400, 10, 400, 200);
        }
    }
}