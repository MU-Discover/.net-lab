namespace WinDBConnection
{
    public partial class Form1 : Form
    {
        private StartForm st;
        private createEmp crtEmp;
        private DeleteEmp dltEmp;
        private SearchEmp schEmp;
        private ViewListEmp vlEmp;
        private string title;
        public Form1()
        {
            InitializeComponent();
        }
        public void setForm(Form form)
        {
            form.MdiParent= this;
            form.Show();
        }
        public void setActiveColor(ToolStripMenuItem ob1, ToolStripMenuItem ob2, ToolStripMenuItem ob3, ToolStripMenuItem ob4)
        {
            ob1.BackColor = Color.AliceBlue; 
            ob2.BackColor = Color.SkyBlue;
            ob3.BackColor = Color.SkyBlue;
            ob4.BackColor = Color.SkyBlue;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            st = new StartForm();
            st.MdiParent = this;
            st.Show();
        }

        private void createNewEmployeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setActiveColor(create, viewList, search, delete);
            if (crtEmp == null)
            {
                crtEmp = new createEmp();
                setForm(crtEmp);
            }
            else
            {
                crtEmp.Show();
                crtEmp.Focus();
            }
        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setActiveColor(search, delete, create, viewList);
            schEmp=new SearchEmp();
            setForm(schEmp);
            if (schEmp == null)
            {
                schEmp = new SearchEmp();
                schEmp.setTilteText("id");
                setForm(schEmp);
            }
            else
            {
                schEmp.Show();
                schEmp.Focus();
            }
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setActiveColor(search, delete, create, viewList);
            schEmp = new SearchEmp();
            schEmp.setTilteText("name");
            setForm(schEmp);
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setActiveColor(search, delete, create, viewList);
            schEmp = new SearchEmp();
            schEmp.setTilteText("designation");
            setForm(schEmp);
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setActiveColor(search, delete, create, viewList);
            schEmp = new SearchEmp();
            schEmp.setTilteText("department");
            setForm(schEmp);
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setActiveColor(search, delete, create, viewList);
            schEmp = new SearchEmp();
            schEmp.setTilteText("salary");
            setForm(schEmp);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            setActiveColor(delete, create, viewList, search);

            if (dltEmp == null)
            {
                dltEmp = new DeleteEmp();
                setForm(dltEmp);
            }
            else
            {
                dltEmp.Show();
                dltEmp.Focus();
            };
        }

        private void viewList_Click(object sender, EventArgs e)
        {
            setActiveColor(viewList, delete, create, search);
           
            if (vlEmp == null)
            {
                vlEmp = new ViewListEmp();
                setForm(vlEmp);
            }
            else
            {
                vlEmp.Show();
                vlEmp.Focus();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            setActiveColor(search, delete, create, viewList);
            if (schEmp == null)
            {
                schEmp = new SearchEmp();
                setForm(schEmp);
            }
            else
            {
                schEmp.Show();
                schEmp.Focus();
            }
        }
    }
}