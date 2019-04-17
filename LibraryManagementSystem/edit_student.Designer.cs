namespace LibraryManagementSystem
{
    partial class edit_student
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enrolment_text = new System.Windows.Forms.TextBox();
            this.department_text = new System.Windows.Forms.TextBox();
            this.semester_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.contact_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.contact_ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(897, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_recordClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "UPDATE STUDENT INFORMATION";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.enrolment_text);
            this.panel1.Controls.Add(this.department_text);
            this.panel1.Controls.Add(this.semester_text);
            this.panel1.Controls.Add(this.email_text);
            this.panel1.Controls.Add(this.contact_text);
            this.panel1.Controls.Add(this.name_text);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.department);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.contact_);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 279);
            this.panel1.TabIndex = 20;
            this.panel1.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(775, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 35;
            this.button2.Text = "BROWSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.browse_click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(448, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 34;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.update_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(744, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // enrolment_text
            // 
            this.enrolment_text.Location = new System.Drawing.Point(136, 104);
            this.enrolment_text.Name = "enrolment_text";
            this.enrolment_text.Size = new System.Drawing.Size(138, 20);
            this.enrolment_text.TabIndex = 32;
            // 
            // department_text
            // 
            this.department_text.Location = new System.Drawing.Point(136, 183);
            this.department_text.Name = "department_text";
            this.department_text.Size = new System.Drawing.Size(138, 20);
            this.department_text.TabIndex = 31;
            // 
            // semester_text
            // 
            this.semester_text.Location = new System.Drawing.Point(461, 29);
            this.semester_text.Name = "semester_text";
            this.semester_text.Size = new System.Drawing.Size(138, 20);
            this.semester_text.TabIndex = 30;
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(461, 104);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(138, 20);
            this.email_text.TabIndex = 29;
            // 
            // contact_text
            // 
            this.contact_text.Location = new System.Drawing.Point(461, 183);
            this.contact_text.Name = "contact_text";
            this.contact_text.Size = new System.Drawing.Size(138, 20);
            this.contact_text.TabIndex = 28;
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(136, 29);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(138, 20);
            this.name_text.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "NAME:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "ENROLMENT_NO:";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.Location = new System.Drawing.Point(18, 181);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(100, 20);
            this.department.TabIndex = 24;
            this.department.Text = "DEPARTMENT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "SEMESTER:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(382, 104);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(53, 20);
            this.email.TabIndex = 22;
            this.email.Text = "EMAIL:";
            // 
            // contact_
            // 
            this.contact_.AutoSize = true;
            this.contact_.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_.Location = new System.Drawing.Point(334, 181);
            this.contact_.Name = "contact_";
            this.contact_.Size = new System.Drawing.Size(101, 20);
            this.contact_.TabIndex = 21;
            this.contact_.Text = "CONTACT_NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "IMAGE:";
            // 
            // edit_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "edit_student";
            this.Text = "edit_student";
            this.Load += new System.EventHandler(this.edit_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox enrolment_text;
        private System.Windows.Forms.TextBox department_text;
        private System.Windows.Forms.TextBox semester_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.TextBox contact_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label contact_;
        private System.Windows.Forms.Label label2;
    }
}