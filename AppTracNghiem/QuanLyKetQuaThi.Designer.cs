
namespace AppTracNghiem
{
    partial class QuanLyKetQuaThi
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
            this.dgvquanlybaithi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlybaithi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvquanlybaithi
            // 
            this.dgvquanlybaithi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvquanlybaithi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquanlybaithi.Location = new System.Drawing.Point(1, 0);
            this.dgvquanlybaithi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvquanlybaithi.Name = "dgvquanlybaithi";
            this.dgvquanlybaithi.RowHeadersWidth = 51;
            this.dgvquanlybaithi.Size = new System.Drawing.Size(1331, 546);
            this.dgvquanlybaithi.TabIndex = 1;
            // 
            // QuanLyKetQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 546);
            this.Controls.Add(this.dgvquanlybaithi);
            this.Name = "QuanLyKetQuaThi";
            this.Text = "QuanLyKetQuaThi";
            this.Load += new System.EventHandler(this.QuanLyKetQuaThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlybaithi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvquanlybaithi;
    }
}