
namespace AppTracNghiem
{
    partial class DanhSachKetQuaThi
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
            this.dgvquanlyhocsinh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlyhocsinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvquanlyhocsinh
            // 
            this.dgvquanlyhocsinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvquanlyhocsinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquanlyhocsinh.Location = new System.Drawing.Point(1, 0);
            this.dgvquanlyhocsinh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvquanlyhocsinh.Name = "dgvquanlyhocsinh";
            this.dgvquanlyhocsinh.RowHeadersWidth = 51;
            this.dgvquanlyhocsinh.Size = new System.Drawing.Size(1331, 546);
            this.dgvquanlyhocsinh.TabIndex = 2;
            this.dgvquanlyhocsinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvquanlyhocsinh_CellClick);
            // 
            // DanhSachKetQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 546);
            this.Controls.Add(this.dgvquanlyhocsinh);
            this.Name = "DanhSachKetQuaThi";
            this.Text = "DanhSachKetQuaThi";
            this.Load += new System.EventHandler(this.DanhSachKetQuaThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlyhocsinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvquanlyhocsinh;
    }
}