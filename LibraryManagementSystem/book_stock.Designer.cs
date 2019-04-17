namespace LibraryManagementSystem
{
    partial class book_stock
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
            this.search_text = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.content_text = new System.Windows.Forms.TextBox();
            this.email_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOK STOCK";
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(978, 80);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(155, 20);
            this.search_text.TabIndex = 1;
            this.search_text.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_text_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(183, 307);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1058, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.email_btn);
            this.panel1.Controls.Add(this.content_text);
            this.panel1.Controls.Add(this.email_text);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 178);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Content:";
            // 
            // email_text
            // 
            this.email_text.Location = new System.Drawing.Point(65, 9);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(160, 20);
            this.email_text.TabIndex = 2;
            // 
            // content_text
            // 
            this.content_text.Location = new System.Drawing.Point(65, 49);
            this.content_text.Multiline = true;
            this.content_text.Name = "content_text";
            this.content_text.Size = new System.Drawing.Size(160, 73);
            this.content_text.TabIndex = 3;
            // 
            // email_btn
            // 
            this.email_btn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_btn.Location = new System.Drawing.Point(96, 138);
            this.email_btn.Name = "email_btn";
            this.email_btn.Size = new System.Drawing.Size(75, 23);
            this.email_btn.TabIndex = 4;
            this.email_btn.Text = "Send Email";
            this.email_btn.UseVisualStyleBackColor = true;
            this.email_btn.Click += new System.EventHandler(this.email_click);
            // 
            // book_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.label1);
            this.Name = "book_stock";
            this.Text = "book_stock";
            this.Load += new System.EventHandler(this.book_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button email_btn;
        private System.Windows.Forms.TextBox content_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}