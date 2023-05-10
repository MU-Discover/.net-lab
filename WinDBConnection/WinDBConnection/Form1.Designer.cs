namespace WinDBConnection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.create = new System.Windows.Forms.ToolStripMenuItem();
            this.viewList = new System.Windows.Forms.ToolStripMenuItem();
            this.search = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create,
            this.viewList,
            this.search,
            this.delete});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 493);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.SkyBlue;
            this.create.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create.Margin = new System.Windows.Forms.Padding(10);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(232, 27);
            this.create.Text = "Create New employe";
            this.create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create.Click += new System.EventHandler(this.createNewEmployeToolStripMenuItem_Click);
            // 
            // viewList
            // 
            this.viewList.BackColor = System.Drawing.Color.SkyBlue;
            this.viewList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewList.Margin = new System.Windows.Forms.Padding(10);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(232, 27);
            this.viewList.Text = "View employe list";
            this.viewList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewList.Click += new System.EventHandler(this.viewList_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.SkyBlue;
            this.search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Margin = new System.Windows.Forms.Padding(10);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(232, 27);
            this.search.Text = "Search employe";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.SkyBlue;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Margin = new System.Windows.Forms.Padding(10);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(232, 27);
            this.delete.Text = "Delete emplye";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 493);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem create;
        private ToolStripMenuItem viewList;
        private ToolStripMenuItem search;
        private ToolStripMenuItem delete;
    }
}