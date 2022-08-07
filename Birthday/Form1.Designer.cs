namespace Birthday
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.datagridview = new System.Windows.Forms.DataGridView();
            this.Check = new DevExpress.XtraEditors.SimpleButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Day = new System.Windows.Forms.ToolStripStatusLabel();
            this.Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Remove_Column_Textbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Firstname_Textbox = new System.Windows.Forms.TextBox();
            this.Lastname_Textbox = new System.Windows.Forms.TextBox();
            this.Sex_Textbox = new System.Windows.Forms.TextBox();
            this.Age_Textbox = new System.Windows.Forms.TextBox();
            this.ID_Textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Remove_Row = new DevExpress.XtraEditors.SimpleButton();
            this.Clear_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Add_Button = new DevExpress.XtraEditors.SimpleButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridview
            // 
            this.datagridview.AllowUserToAddRows = false;
            this.datagridview.AllowUserToDeleteRows = false;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Firstname,
            this.Lastname,
            this.DATE,
            this.Sex,
            this.Age});
            this.datagridview.Location = new System.Drawing.Point(12, 12);
            this.datagridview.Name = "datagridview";
            this.datagridview.Size = new System.Drawing.Size(575, 195);
            this.datagridview.TabIndex = 0;
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellContentClick);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(12, 213);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(106, 28);
            this.Check.TabIndex = 1;
            this.Check.Text = "Check birthday first";
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Day,
            this.Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 346);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(996, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Day
            // 
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(0, 17);
            // 
            // Time
            // 
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 17);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(650, 248);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(92, 28);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "add default";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 281);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(106, 28);
            this.simpleButton2.TabIndex = 21;
            this.simpleButton2.Text = "cell count";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(124, 213);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(127, 28);
            this.simpleButton3.TabIndex = 22;
            this.simpleButton3.Text = "Check birthday second";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(12, 247);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(106, 28);
            this.simpleButton4.TabIndex = 23;
            this.simpleButton4.Text = "Database csharp";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(124, 247);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(127, 28);
            this.simpleButton5.TabIndex = 25;
            this.simpleButton5.Text = "Database query";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(650, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(92, 95);
            this.listBox1.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(901, 183);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(50, 26);
            this.label6.TabIndex = 42;
            this.label6.Text = "ردیف :";
            // 
            // Remove_Column_Textbox
            // 
            this.Remove_Column_Textbox.Location = new System.Drawing.Point(747, 184);
            this.Remove_Column_Textbox.Name = "Remove_Column_Textbox";
            this.Remove_Column_Textbox.Size = new System.Drawing.Size(148, 20);
            this.Remove_Column_Textbox.TabIndex = 41;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "کد مشتری",
            "نام",
            "نام خانوادگی",
            "جنسیت",
            "سن"});
            this.comboBox1.Location = new System.Drawing.Point(748, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // Firstname_Textbox
            // 
            this.Firstname_Textbox.Location = new System.Drawing.Point(748, 39);
            this.Firstname_Textbox.Name = "Firstname_Textbox";
            this.Firstname_Textbox.Size = new System.Drawing.Size(148, 20);
            this.Firstname_Textbox.TabIndex = 39;
            // 
            // Lastname_Textbox
            // 
            this.Lastname_Textbox.Location = new System.Drawing.Point(748, 65);
            this.Lastname_Textbox.Name = "Lastname_Textbox";
            this.Lastname_Textbox.Size = new System.Drawing.Size(148, 20);
            this.Lastname_Textbox.TabIndex = 38;
            // 
            // Sex_Textbox
            // 
            this.Sex_Textbox.Location = new System.Drawing.Point(748, 91);
            this.Sex_Textbox.Name = "Sex_Textbox";
            this.Sex_Textbox.Size = new System.Drawing.Size(148, 20);
            this.Sex_Textbox.TabIndex = 37;
            // 
            // Age_Textbox
            // 
            this.Age_Textbox.Location = new System.Drawing.Point(748, 117);
            this.Age_Textbox.Name = "Age_Textbox";
            this.Age_Textbox.Size = new System.Drawing.Size(148, 20);
            this.Age_Textbox.TabIndex = 36;
            // 
            // ID_Textbox
            // 
            this.ID_Textbox.Location = new System.Drawing.Point(748, 13);
            this.ID_Textbox.Name = "ID_Textbox";
            this.ID_Textbox.Size = new System.Drawing.Size(148, 20);
            this.ID_Textbox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(902, 38);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(37, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "نام :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(902, 64);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "نام خانوادگی :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(902, 90);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "جنسیت :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(902, 116);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "سن :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(902, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(82, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "کد مشتری :";
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(650, 146);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(92, 28);
            this.Search_Button.TabIndex = 29;
            this.Search_Button.Text = "Search by";
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click_1);
            // 
            // Remove_Row
            // 
            this.Remove_Row.Location = new System.Drawing.Point(650, 180);
            this.Remove_Row.Name = "Remove_Row";
            this.Remove_Row.Size = new System.Drawing.Size(92, 28);
            this.Remove_Row.TabIndex = 28;
            this.Remove_Row.Text = "Remove Row";
            this.Remove_Row.Click += new System.EventHandler(this.Remove_Row_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(650, 214);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(92, 28);
            this.Clear_Button.TabIndex = 27;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(650, 112);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(92, 28);
            this.Add_Button.TabIndex = 26;
            this.Add_Button.Text = "Add";
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click_1);
            // 
            // ID
            // 
            this.ID.HeaderText = "کد مشتری";
            this.ID.Name = "ID";
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "نام";
            this.Firstname.Name = "Firstname";
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "نام خانوادگی";
            this.Lastname.Name = "Lastname";
            // 
            // DATE
            // 
            this.DATE.HeaderText = "Birthday";
            this.DATE.Name = "DATE";
            // 
            // Sex
            // 
            this.Sex.HeaderText = "جنسیت";
            this.Sex.Name = "Sex";
            // 
            // Age
            // 
            this.Age.HeaderText = "سن";
            this.Age.Name = "Age";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 368);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Remove_Column_Textbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Firstname_Textbox);
            this.Controls.Add(this.Lastname_Textbox);
            this.Controls.Add(this.Sex_Textbox);
            this.Controls.Add(this.Age_Textbox);
            this.Controls.Add(this.ID_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Remove_Row);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.datagridview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton Check;
        public System.Windows.Forms.DataGridView datagridview;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Day;
        private System.Windows.Forms.ToolStripStatusLabel Time;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Remove_Column_Textbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Firstname_Textbox;
        private System.Windows.Forms.TextBox Lastname_Textbox;
        private System.Windows.Forms.TextBox Sex_Textbox;
        private System.Windows.Forms.TextBox Age_Textbox;
        private System.Windows.Forms.TextBox ID_Textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton Search_Button;
        private DevExpress.XtraEditors.SimpleButton Remove_Row;
        private DevExpress.XtraEditors.SimpleButton Clear_Button;
        private DevExpress.XtraEditors.SimpleButton Add_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.Timer timer1;
    }
}

