﻿namespace QuanLyKhachSan._2._1
{
    partial class PhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanQuyen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnNhan = new DevExpress.XtraEditors.SimpleButton();
            this.cbloai = new System.Windows.Forms.ComboBox();
            this.cbuser = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnNhan);
            this.groupBox1.Controls.Add(this.cbloai);
            this.groupBox1.Controls.Add(this.cbuser);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân Quyền";
            // 
            // btnThoat
            // 
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(259, 102);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 38);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhan.ImageOptions.Image")));
            this.btnNhan.Location = new System.Drawing.Point(113, 102);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(95, 38);
            this.btnNhan.TabIndex = 4;
            this.btnNhan.Text = "Xác Nhận";
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // cbloai
            // 
            this.cbloai.FormattingEnabled = true;
            this.cbloai.Location = new System.Drawing.Point(113, 74);
            this.cbloai.Name = "cbloai";
            this.cbloai.Size = new System.Drawing.Size(231, 22);
            this.cbloai.TabIndex = 3;
            // 
            // cbuser
            // 
            this.cbuser.FormattingEnabled = true;
            this.cbuser.Location = new System.Drawing.Point(113, 34);
            this.cbuser.Name = "cbuser";
            this.cbuser.Size = new System.Drawing.Size(231, 22);
            this.cbuser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại Người Dùng ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản";
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 181);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhanQuyen";
            this.Text = "Phân Quyền ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnNhan;
        private System.Windows.Forms.ComboBox cbloai;
        private System.Windows.Forms.ComboBox cbuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}