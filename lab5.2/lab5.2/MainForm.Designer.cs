namespace lab5._2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.txtChiSoCu = new System.Windows.Forms.TextBox();
            this.txtChiSoMoi = new System.Windows.Forms.TextBox();
            this.txtSoKWTieuThu = new System.Windows.Forms.TextBox();
            this.txtSoKWDinhMuc = new System.Windows.Forms.TextBox();
            this.txtSoKWVuotDinhMuc = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rtbKetQua = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Items.AddRange(new object[] {
            "SV1",
            "SV2",
            "SV3",
            "SV4",
            "SV5"});
            this.cmbKhachHang.Location = new System.Drawing.Point(284, 160);
            this.cmbKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(278, 37);
            this.cmbKhachHang.TabIndex = 0;
            // 
            // txtChiSoCu
            // 
            this.txtChiSoCu.Location = new System.Drawing.Point(284, 226);
            this.txtChiSoCu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChiSoCu.Name = "txtChiSoCu";
            this.txtChiSoCu.Size = new System.Drawing.Size(96, 35);
            this.txtChiSoCu.TabIndex = 1;
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.Location = new System.Drawing.Point(284, 293);
            this.txtChiSoMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.Size = new System.Drawing.Size(96, 35);
            this.txtChiSoMoi.TabIndex = 2;
            // 
            // txtSoKWTieuThu
            // 
            this.txtSoKWTieuThu.Location = new System.Drawing.Point(284, 354);
            this.txtSoKWTieuThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoKWTieuThu.Name = "txtSoKWTieuThu";
            this.txtSoKWTieuThu.ReadOnly = true;
            this.txtSoKWTieuThu.Size = new System.Drawing.Size(96, 35);
            this.txtSoKWTieuThu.TabIndex = 3;
            // 
            // txtSoKWDinhMuc
            // 
            this.txtSoKWDinhMuc.Location = new System.Drawing.Point(709, 229);
            this.txtSoKWDinhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoKWDinhMuc.Name = "txtSoKWDinhMuc";
            this.txtSoKWDinhMuc.ReadOnly = true;
            this.txtSoKWDinhMuc.Size = new System.Drawing.Size(83, 35);
            this.txtSoKWDinhMuc.TabIndex = 4;
            // 
            // txtSoKWVuotDinhMuc
            // 
            this.txtSoKWVuotDinhMuc.Location = new System.Drawing.Point(709, 296);
            this.txtSoKWVuotDinhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoKWVuotDinhMuc.Name = "txtSoKWVuotDinhMuc";
            this.txtSoKWVuotDinhMuc.ReadOnly = true;
            this.txtSoKWVuotDinhMuc.Size = new System.Drawing.Size(83, 35);
            this.txtSoKWVuotDinhMuc.TabIndex = 5;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(38, 529);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(278, 35);
            this.txtTongTien.TabIndex = 6;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(38, 601);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(140, 58);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(215, 601);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 58);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rtbKetQua
            // 
            this.rtbKetQua.BackColor = System.Drawing.SystemColors.Info;
            this.rtbKetQua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbKetQua.Location = new System.Drawing.Point(438, 565);
            this.rtbKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbKetQua.Name = "rtbKetQua";
            this.rtbKetQua.Size = new System.Drawing.Size(494, 181);
            this.rtbKetQua.TabIndex = 9;
            this.rtbKetQua.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Chỉ số cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(225, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 62);
            this.label3.TabIndex = 12;
            this.label3.Text = " Bảng Tính Tiền Điện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Chỉ số mới:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số kw tiêu thụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số kw trong định mức:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số kw vượt định mức";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tổng tiền phải trả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Định mức là 50kw";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(315, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Trong định mức là 500đ/1kw";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(311, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Vượt định mức là 1000đ/1kw";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 762);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtSoKWVuotDinhMuc);
            this.Controls.Add(this.txtSoKWDinhMuc);
            this.Controls.Add(this.txtSoKWTieuThu);
            this.Controls.Add(this.txtChiSoMoi);
            this.Controls.Add(this.txtChiSoCu);
            this.Controls.Add(this.cmbKhachHang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Bảng Tính Tiền Điện";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.TextBox txtChiSoCu;
        private System.Windows.Forms.TextBox txtChiSoMoi;
        private System.Windows.Forms.TextBox txtSoKWTieuThu;
        private System.Windows.Forms.TextBox txtSoKWDinhMuc;
        private System.Windows.Forms.TextBox txtSoKWVuotDinhMuc;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RichTextBox rtbKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
