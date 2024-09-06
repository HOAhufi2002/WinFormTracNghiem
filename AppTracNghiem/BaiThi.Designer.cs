
namespace AppTracNghiem
{
    partial class BaiThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaiThi));
            this.rbOptionA = new System.Windows.Forms.RadioButton();
            this.rbOptionB = new System.Windows.Forms.RadioButton();
            this.rbOptionC = new System.Windows.Forms.RadioButton();
            this.rbOptionD = new System.Windows.Forms.RadioButton();
            this.lblThoiGianConLai = new System.Windows.Forms.Label();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltentaikhoan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbOptionA
            // 
            this.rbOptionA.AutoSize = true;
            this.rbOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionA.Location = new System.Drawing.Point(3, 78);
            this.rbOptionA.Name = "rbOptionA";
            this.rbOptionA.Size = new System.Drawing.Size(38, 24);
            this.rbOptionA.TabIndex = 0;
            this.rbOptionA.TabStop = true;
            this.rbOptionA.Text = "A";
            this.rbOptionA.UseVisualStyleBackColor = true;
            this.rbOptionA.CheckedChanged += new System.EventHandler(this.rbOptionA_CheckedChanged);
            // 
            // rbOptionB
            // 
            this.rbOptionB.AutoSize = true;
            this.rbOptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionB.Location = new System.Drawing.Point(3, 127);
            this.rbOptionB.Name = "rbOptionB";
            this.rbOptionB.Size = new System.Drawing.Size(38, 24);
            this.rbOptionB.TabIndex = 1;
            this.rbOptionB.TabStop = true;
            this.rbOptionB.Text = "B";
            this.rbOptionB.UseVisualStyleBackColor = true;
            this.rbOptionB.CheckedChanged += new System.EventHandler(this.rbOptionB_CheckedChanged);
            // 
            // rbOptionC
            // 
            this.rbOptionC.AutoSize = true;
            this.rbOptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionC.Location = new System.Drawing.Point(3, 173);
            this.rbOptionC.Name = "rbOptionC";
            this.rbOptionC.Size = new System.Drawing.Size(38, 24);
            this.rbOptionC.TabIndex = 2;
            this.rbOptionC.TabStop = true;
            this.rbOptionC.Text = "C";
            this.rbOptionC.UseVisualStyleBackColor = true;
            this.rbOptionC.CheckedChanged += new System.EventHandler(this.rbOptionC_CheckedChanged);
            // 
            // rbOptionD
            // 
            this.rbOptionD.AutoSize = true;
            this.rbOptionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionD.Location = new System.Drawing.Point(3, 217);
            this.rbOptionD.Name = "rbOptionD";
            this.rbOptionD.Size = new System.Drawing.Size(39, 24);
            this.rbOptionD.TabIndex = 3;
            this.rbOptionD.TabStop = true;
            this.rbOptionD.Text = "D";
            this.rbOptionD.UseVisualStyleBackColor = true;
            this.rbOptionD.CheckedChanged += new System.EventHandler(this.rbOptionD_CheckedChanged);
            // 
            // lblThoiGianConLai
            // 
            this.lblThoiGianConLai.AutoSize = true;
            this.lblThoiGianConLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianConLai.Location = new System.Drawing.Point(3, 7);
            this.lblThoiGianConLai.Name = "lblThoiGianConLai";
            this.lblThoiGianConLai.Size = new System.Drawing.Size(166, 24);
            this.lblThoiGianConLai.TabIndex = 4;
            this.lblThoiGianConLai.Text = "Thời gian còn lại";
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.Location = new System.Drawing.Point(3, 11);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(63, 20);
            this.lblCauHoi.TabIndex = 5;
            this.lblCauHoi.Text = "Câu hỏi";
            // 
            // btnNext
            // 
            this.btnNext.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnNext.Location = new System.Drawing.Point(697, 365);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 31);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Câu tiếp theo";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnSubmit.Location = new System.Drawing.Point(97, 257);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 30);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Nộp bài";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbltentaikhoan);
            this.panel1.Controls.Add(this.lblThoiGianConLai);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Location = new System.Drawing.Point(9, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 302);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbltentaikhoan
            // 
            this.lbltentaikhoan.AutoSize = true;
            this.lbltentaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltentaikhoan.Location = new System.Drawing.Point(13, 43);
            this.lbltentaikhoan.Name = "lbltentaikhoan";
            this.lbltentaikhoan.Size = new System.Drawing.Size(19, 20);
            this.lbltentaikhoan.TabIndex = 9;
            this.lbltentaikhoan.Text = "_";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCauHoi);
            this.panel2.Controls.Add(this.rbOptionD);
            this.panel2.Controls.Add(this.rbOptionC);
            this.panel2.Controls.Add(this.rbOptionB);
            this.panel2.Controls.Add(this.rbOptionA);
            this.panel2.Location = new System.Drawing.Point(307, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 304);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(1, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 48);
            this.panel3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(339, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "BÀI THI";
            // 
            // BaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNext);
            this.Name = "BaiThi";
            this.Text = "BaiThi";
            this.Load += new System.EventHandler(this.BaiThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.RadioButton rbOptionC;
        private System.Windows.Forms.RadioButton rbOptionD;
        private System.Windows.Forms.Label lblThoiGianConLai;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltentaikhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}