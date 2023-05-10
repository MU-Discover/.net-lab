using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            initContent();
        }
        public void initContent()
        {
            string[] fontName = { "Segoe UI Emoji", "Segoe UI Historic", "Segoe UI Symbol", "Showcard Gothic", "SimSun", "Times New Roman", "Trebuchet MS", "Tw Cen MT", "Verdana", "Viner Hand ITC", "Vivaldi", "Vladimir Script", "Webdings", "Wingdings", "Wingdings 2", "Centaur", "Century", "Century Gothic", "Century Schoolbook", "Chiller", "Colonna MT", "Comic Sans MS", "Consolas", "Constantia", "Cooper", "Agency FB" };

            string[] sizeName = { "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" };

            string[] fontStyleName = { "Regular", "Bold", "Italic"};

            for (int i = 0; i < fontName.Length; i++)
            {
                font.Items.Add(fontName[i]);
            }
            for (int i = 0; i < sizeName.Length; i++)
            {
                size.Items.Add(sizeName[i]);
            }
            for (int i = 0; i < fontStyleName.Length; i++)
            {
                font_style.Items.Add(fontStyleName[i]);
            }
            fore_color.DataSource = typeof(Color).GetProperties().Where(x => x.PropertyType == typeof(Color)).Select(x => x.GetValue(null)).ToList();
            back_color.DataSource = typeof(Color).GetProperties().Where(x => x.PropertyType == typeof(Color)).Select(x => x.GetValue(null)).ToList();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = input.Text;
            input.ForeColor=Color.FromName(fore_color.Text);
            input.BackColor=Color.FromName(back_color.Text);
            
            if (font_style.Text == "Bold")
                input.Font = new Font(font.Text, int.Parse(size.SelectedIndex.ToString()), FontStyle.Bold);
            else if (font_style.Text == "Italic")
                input.Font = new Font(font.Text, int.Parse(size.SelectedIndex.ToString()), FontStyle.Italic);
            else
                input.Font = new Font(font.Text, int.Parse(size.SelectedIndex.ToString()), FontStyle.Regular);

            input.Text= txt;
        }
    }
}
