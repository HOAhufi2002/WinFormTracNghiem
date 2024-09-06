
namespace AppTracNghiem
{
    partial class QuanLyCaThi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvcathi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmaca = new System.Windows.Forms.TextBox();
            this.txtTenCaThi = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcathi)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvcathi);
            this.panel1.Location = new System.Drawing.Point(390, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 546);
            this.panel1.TabIndex = 17;
            // 
            // dgvcathi
            // 
            this.dgvcathi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcathi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcathi.Location = new System.Drawing.Point(-1, 0);
            this.dgvcathi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvcathi.Name = "dgvcathi";
            this.dgvcathi.RowHeadersWidth = 51;
            this.dgvcathi.Size = new System.Drawing.Size(941, 539);
            this.dgvcathi.TabIndex = 0;
            this.dgvcathi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcathi_CellClick);
            this.dgvcathi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcathi_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txtTenCaThi);
            this.panel2.Location = new System.Drawing.Point(-1, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 265);
            this.panel2.TabIndex = 18;
            // 
            // txtmaca
            // 
            this.txtmaca.Location = new System.Drawing.Point(176, 246);
            this.txtmaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaca.Name = "txtmaca";
            this.txtmaca.Size = new System.Drawing.Size(10, 22);
            this.txtmaca.TabIndex = 3;
            // 
            // txtTenCaThi
            // 
            this.txtTenCaThi.Location = new System.Drawing.Point(75, 39);
            this.txtTenCaThi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCaThi.Multiline = true;
            this.txtTenCaThi.Name = "txtTenCaThi";
            this.txtTenCaThi.Size = new System.Drawing.Size(241, 37);
            this.txtTenCaThi.TabIndex = 0;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(270, 291);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 42);
            this.btnupdate.TabIndex = 21;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(150, 291);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 42);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(18, 291);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 42);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(75, 156);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // QuanLyCaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtmaca);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Name = "QuanLyCaThi";
            this.Text = "QuanLyCaThi";
            this.Load += new System.EventHandler(this.QuanLyCaThi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcathi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvcathi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtmaca;
        private System.Windows.Forms.TextBox txtTenCaThi;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}