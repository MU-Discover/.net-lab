namespace final_exam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lb1 = new ListBox();
            cb1 = new ComboBox();
            txt1 = new TextBox();
            btn1 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            button1 = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.FormattingEnabled = true;
            lb1.ItemHeight = 20;
            lb1.Location = new Point(308, 34);
            lb1.Name = "lb1";
            lb1.Size = new Size(211, 264);
            lb1.TabIndex = 0;
            // 
            // cb1
            // 
            cb1.FormattingEnabled = true;
            cb1.Location = new Point(40, 129);
            cb1.Name = "cb1";
            cb1.Size = new Size(237, 28);
            cb1.TabIndex = 1;
            // 
            // txt1
            // 
            txt1.Location = new Point(40, 34);
            txt1.Name = "txt1";
            txt1.Size = new Size(237, 27);
            txt1.TabIndex = 2;
            // 
            // btn1
            // 
            btn1.Location = new Point(40, 330);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 27);
            btn1.TabIndex = 3;
            btn1.Text = "Btn1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(295, 330);
            btn3.Name = "btn3";
            btn3.Size = new Size(87, 27);
            btn3.TabIndex = 4;
            btn3.Text = "Btn3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(168, 330);
            btn2.Name = "btn2";
            btn2.Size = new Size(88, 27);
            btn2.TabIndex = 5;
            btn2.Text = "Btn2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(438, 330);
            btn4.Name = "btn4";
            btn4.Size = new Size(81, 27);
            btn4.TabIndex = 6;
            btn4.Text = "Btn4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // button1
            // 
            button1.Location = new Point(211, 401);
            button1.Name = "button1";
            button1.Size = new Size(81, 27);
            button1.TabIndex = 7;
            button1.Text = "Btn4";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(104, 214);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 491);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(txt1);
            Controls.Add(cb1);
            Controls.Add(lb1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lb1;
        private ComboBox cb1;
        private TextBox txt1;
        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btn4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button1;
        private PrintPreviewDialog printPreviewDialog1;
        private RadioButton radioButton1;
    }
}