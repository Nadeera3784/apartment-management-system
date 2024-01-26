namespace ams
{
    partial class admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbadownrs = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbadadmin = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbadtenant = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.admindatagrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtadname = new System.Windows.Forms.TextBox();
            this.txtademail = new System.Windows.Forms.TextBox();
            this.txtadusername = new System.Windows.Forms.TextBox();
            this.txtadpassword = new System.Windows.Forms.TextBox();
            this.cmbadtype = new System.Windows.Forms.ComboBox();
            this.cmadreidentail = new System.Windows.Forms.ComboBox();
            this.cmbadapartmnt = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbadstatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admindatagrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Admin";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbadstatus);
            this.panel1.Controls.Add(this.cmbadapartmnt);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmadreidentail);
            this.panel1.Controls.Add(this.cmbadtype);
            this.panel1.Controls.Add(this.txtadpassword);
            this.panel1.Controls.Add(this.txtadusername);
            this.panel1.Controls.Add(this.txtademail);
            this.panel1.Controls.Add(this.txtadname);
            this.panel1.Controls.Add(this.cmbadownrs);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbadadmin);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmbadtenant);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 172);
            this.panel1.TabIndex = 1;
            // 
            // cmbadownrs
            // 
            this.cmbadownrs.FormattingEnabled = true;
            this.cmbadownrs.Location = new System.Drawing.Point(118, 139);
            this.cmbadownrs.Name = "cmbadownrs";
            this.cmbadownrs.Size = new System.Drawing.Size(117, 21);
            this.cmbadownrs.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(551, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "Residential";
            // 
            // cmbadadmin
            // 
            this.cmbadadmin.FormattingEnabled = true;
            this.cmbadadmin.Location = new System.Drawing.Point(433, 106);
            this.cmbadadmin.Name = "cmbadadmin";
            this.cmbadadmin.Size = new System.Drawing.Size(82, 21);
            this.cmbadadmin.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(605, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Status";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cmbadtenant
            // 
            this.cmbadtenant.FormattingEnabled = true;
            this.cmbadtenant.Location = new System.Drawing.Point(318, 138);
            this.cmbadtenant.Name = "cmbadtenant";
            this.cmbadtenant.Size = new System.Drawing.Size(82, 21);
            this.cmbadtenant.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(246, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tenant";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Owners";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(366, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Admin Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // admindatagrid
            // 
            this.admindatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admindatagrid.Location = new System.Drawing.Point(12, 281);
            this.admindatagrid.Name = "admindatagrid";
            this.admindatagrid.Size = new System.Drawing.Size(802, 263);
            this.admindatagrid.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Location = new System.Drawing.Point(12, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 51);
            this.panel2.TabIndex = 31;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.DarkGreen;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(13, 9);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(180, 32);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnedit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(334, 9);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(181, 32);
            this.btnedit.TabIndex = 27;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(598, 9);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(186, 32);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // txtadname
            // 
            this.txtadname.Location = new System.Drawing.Point(117, 12);
            this.txtadname.Multiline = true;
            this.txtadname.Name = "txtadname";
            this.txtadname.Size = new System.Drawing.Size(248, 35);
            this.txtadname.TabIndex = 26;
            // 
            // txtademail
            // 
            this.txtademail.Location = new System.Drawing.Point(517, 12);
            this.txtademail.Multiline = true;
            this.txtademail.Name = "txtademail";
            this.txtademail.Size = new System.Drawing.Size(267, 35);
            this.txtademail.TabIndex = 27;
            // 
            // txtadusername
            // 
            this.txtadusername.Location = new System.Drawing.Point(118, 59);
            this.txtadusername.Multiline = true;
            this.txtadusername.Name = "txtadusername";
            this.txtadusername.Size = new System.Drawing.Size(248, 35);
            this.txtadusername.TabIndex = 28;
            // 
            // txtadpassword
            // 
            this.txtadpassword.Location = new System.Drawing.Point(517, 59);
            this.txtadpassword.Multiline = true;
            this.txtadpassword.Name = "txtadpassword";
            this.txtadpassword.PasswordChar = '*';
            this.txtadpassword.Size = new System.Drawing.Size(267, 35);
            this.txtadpassword.TabIndex = 29;
            this.txtadpassword.UseSystemPasswordChar = true;
            // 
            // cmbadtype
            // 
            this.cmbadtype.FormattingEnabled = true;
            this.cmbadtype.Items.AddRange(new object[] {
            "Administrator",
            "Core Admin",
            "Security",
            "Officer"});
            this.cmbadtype.Location = new System.Drawing.Point(118, 106);
            this.cmbadtype.Name = "cmbadtype";
            this.cmbadtype.Size = new System.Drawing.Size(245, 21);
            this.cmbadtype.TabIndex = 30;
            // 
            // cmadreidentail
            // 
            this.cmadreidentail.FormattingEnabled = true;
            this.cmadreidentail.Location = new System.Drawing.Point(694, 105);
            this.cmadreidentail.Name = "cmadreidentail";
            this.cmadreidentail.Size = new System.Drawing.Size(90, 21);
            this.cmadreidentail.TabIndex = 31;
            // 
            // cmbadapartmnt
            // 
            this.cmbadapartmnt.FormattingEnabled = true;
            this.cmbadapartmnt.Location = new System.Drawing.Point(516, 136);
            this.cmbadapartmnt.Name = "cmbadapartmnt";
            this.cmbadapartmnt.Size = new System.Drawing.Size(82, 21);
            this.cmbadapartmnt.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(408, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 22);
            this.label12.TabIndex = 32;
            this.label12.Text = "Apartment";
            // 
            // cmbadstatus
            // 
            this.cmbadstatus.FormattingEnabled = true;
            this.cmbadstatus.Items.AddRange(new object[] {
            "Publish",
            "Unpublish"});
            this.cmbadstatus.Location = new System.Drawing.Point(674, 135);
            this.cmbadstatus.Name = "cmbadstatus";
            this.cmbadstatus.Size = new System.Drawing.Size(110, 21);
            this.cmbadstatus.TabIndex = 34;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.admindatagrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Admin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admindatagrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbadownrs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbadadmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbadtenant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView admindatagrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cmbadtype;
        private System.Windows.Forms.TextBox txtadpassword;
        private System.Windows.Forms.TextBox txtadusername;
        private System.Windows.Forms.TextBox txtademail;
        private System.Windows.Forms.TextBox txtadname;
        private System.Windows.Forms.ComboBox cmadreidentail;
        private System.Windows.Forms.ComboBox cmbadapartmnt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbadstatus;
    }
}