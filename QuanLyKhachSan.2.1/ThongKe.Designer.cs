﻿namespace QuanLyKhachSan._2._1
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.label1 = new System.Windows.Forms.Label();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.txttiledoanhthu = new System.Windows.Forms.MaskedTextBox();
            this.txtdoanhthuthucte = new System.Windows.Forms.MaskedTextBox();
            this.txtdoanhthuthang = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.txtchisuatphong = new System.Windows.Forms.MaskedTextBox();
            this.txtsoluongphong = new System.Windows.Forms.MaskedTextBox();
            this.txttieledoanhthu1 = new System.Windows.Forms.MaskedTextBox();
            this.txtdoanthuthucte1 = new System.Windows.Forms.MaskedTextBox();
            this.txttongdoanhthuthang1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(12, 43);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(541, 238);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(541, 238);
            this.tabPane1.TabIndex = 1;
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.Appearance.Options.UseFont = true;
            this.tabNavigationPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.BackgroundImage")));
            this.tabNavigationPage1.Caption = "Tỷ Lệ Doanh Thu";
            this.tabNavigationPage1.Controls.Add(this.txttiledoanhthu);
            this.tabNavigationPage1.Controls.Add(this.txtdoanhthuthucte);
            this.tabNavigationPage1.Controls.Add(this.txtdoanhthuthang);
            this.tabNavigationPage1.Controls.Add(this.label4);
            this.tabNavigationPage1.Controls.Add(this.label3);
            this.tabNavigationPage1.Controls.Add(this.label2);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(523, 193);
            // 
            // txttiledoanhthu
            // 
            this.txttiledoanhthu.Location = new System.Drawing.Point(239, 113);
            this.txttiledoanhthu.Name = "txttiledoanhthu";
            this.txttiledoanhthu.ReadOnly = true;
            this.txttiledoanhthu.Size = new System.Drawing.Size(262, 20);
            this.txttiledoanhthu.TabIndex = 9;
            // 
            // txtdoanhthuthucte
            // 
            this.txtdoanhthuthucte.Location = new System.Drawing.Point(239, 63);
            this.txtdoanhthuthucte.Name = "txtdoanhthuthucte";
            this.txtdoanhthuthucte.ReadOnly = true;
            this.txtdoanhthuthucte.Size = new System.Drawing.Size(262, 20);
            this.txtdoanhthuthucte.TabIndex = 8;
            // 
            // txtdoanhthuthang
            // 
            this.txtdoanhthuthang.Location = new System.Drawing.Point(239, 18);
            this.txtdoanhthuthang.Name = "txtdoanhthuthang";
            this.txtdoanhthuthang.ReadOnly = true;
            this.txtdoanhthuthang.Size = new System.Drawing.Size(262, 20);
            this.txtdoanhthuthang.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tỷ lệ doanh thu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng doanh thu thực tế :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng doanh thu trong tháng đã cho thuê:";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.BackgroundImage")));
            this.tabNavigationPage2.Caption = "Chiết Suất Phòng";
            this.tabNavigationPage2.Controls.Add(this.txtchisuatphong);
            this.tabNavigationPage2.Controls.Add(this.txtsoluongphong);
            this.tabNavigationPage2.Controls.Add(this.txttieledoanhthu1);
            this.tabNavigationPage2.Controls.Add(this.txtdoanthuthucte1);
            this.tabNavigationPage2.Controls.Add(this.txttongdoanhthuthang1);
            this.tabNavigationPage2.Controls.Add(this.label9);
            this.tabNavigationPage2.Controls.Add(this.label8);
            this.tabNavigationPage2.Controls.Add(this.label5);
            this.tabNavigationPage2.Controls.Add(this.label6);
            this.tabNavigationPage2.Controls.Add(this.label7);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(523, 193);
            // 
            // txtchisuatphong
            // 
            this.txtchisuatphong.Location = new System.Drawing.Point(251, 158);
            this.txtchisuatphong.Name = "txtchisuatphong";
            this.txtchisuatphong.ReadOnly = true;
            this.txtchisuatphong.Size = new System.Drawing.Size(257, 20);
            this.txtchisuatphong.TabIndex = 13;
            // 
            // txtsoluongphong
            // 
            this.txtsoluongphong.Location = new System.Drawing.Point(251, 121);
            this.txtsoluongphong.Name = "txtsoluongphong";
            this.txtsoluongphong.ReadOnly = true;
            this.txtsoluongphong.Size = new System.Drawing.Size(257, 20);
            this.txtsoluongphong.TabIndex = 12;
            // 
            // txttieledoanhthu1
            // 
            this.txttieledoanhthu1.Location = new System.Drawing.Point(251, 82);
            this.txttieledoanhthu1.Name = "txttieledoanhthu1";
            this.txttieledoanhthu1.ReadOnly = true;
            this.txttieledoanhthu1.Size = new System.Drawing.Size(257, 20);
            this.txttieledoanhthu1.TabIndex = 11;
            // 
            // txtdoanthuthucte1
            // 
            this.txtdoanthuthucte1.Location = new System.Drawing.Point(251, 43);
            this.txtdoanthuthucte1.Name = "txtdoanthuthucte1";
            this.txtdoanthuthucte1.ReadOnly = true;
            this.txtdoanthuthucte1.Size = new System.Drawing.Size(257, 20);
            this.txtdoanthuthucte1.TabIndex = 10;
            // 
            // txttongdoanhthuthang1
            // 
            this.txttongdoanhthuthang1.Location = new System.Drawing.Point(251, 12);
            this.txttongdoanhthuthang1.Name = "txttongdoanhthuthang1";
            this.txttongdoanhthuthang1.ReadOnly = true;
            this.txttongdoanhthuthang1.Size = new System.Drawing.Size(257, 20);
            this.txttongdoanhthuthang1.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Chiết Suất Phòng :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tổng số lượng phòng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tỷ lệ doanh thu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng doanh thu thực tế :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng doanh thu trong tháng đã cho thuê:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(21, 287);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 33);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Refresh";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(433, 287);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(111, 33);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Exit";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 332);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "ThongKe";
            this.Text = "Thống Kê";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.MaskedTextBox txttiledoanhthu;
        private System.Windows.Forms.MaskedTextBox txtdoanhthuthucte;
        private System.Windows.Forms.MaskedTextBox txtdoanhthuthang;
        private System.Windows.Forms.MaskedTextBox txttongdoanhthuthang1;
        private System.Windows.Forms.MaskedTextBox txtchisuatphong;
        private System.Windows.Forms.MaskedTextBox txtsoluongphong;
        private System.Windows.Forms.MaskedTextBox txttieledoanhthu1;
        private System.Windows.Forms.MaskedTextBox txtdoanthuthucte1;
    }
}