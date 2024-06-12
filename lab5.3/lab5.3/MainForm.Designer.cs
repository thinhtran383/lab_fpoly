namespace lab5._3
{
    partial class MainForm
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
            if(disposing && (components != null))
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
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.lstDanhSachMon = new System.Windows.Forms.ListBox();
            this.lstDanhSachDaChon = new System.Windows.Forms.ListBox();
            this.btnChonTungPhan = new System.Windows.Forms.Button();
            this.btnChonHet = new System.Windows.Forms.Button();
            this.btnBoTungPhan = new System.Windows.Forms.Button();
            this.btnBoHet = new System.Windows.Forms.Button();
            this.rtbKetQua = new System.Windows.Forms.RichTextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(311, 72);
            this.cmbHoTen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(309, 37);
            this.cmbHoTen.TabIndex = 0;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(311, 148);
            this.txtNgay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(309, 35);
            this.txtNgay.TabIndex = 1;
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(808, 145);
            this.txtGio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGio.Name = "txtGio";
            this.txtGio.ReadOnly = true;
            this.txtGio.Size = new System.Drawing.Size(309, 35);
            this.txtGio.TabIndex = 2;
            // 
            // lstDanhSachMon
            // 
            this.lstDanhSachMon.FormattingEnabled = true;
            this.lstDanhSachMon.ItemHeight = 29;
            this.lstDanhSachMon.Location = new System.Drawing.Point(78, 290);
            this.lstDanhSachMon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstDanhSachMon.Name = "lstDanhSachMon";
            this.lstDanhSachMon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDanhSachMon.Size = new System.Drawing.Size(309, 294);
            this.lstDanhSachMon.TabIndex = 3;
            // 
            // lstDanhSachDaChon
            // 
            this.lstDanhSachDaChon.FormattingEnabled = true;
            this.lstDanhSachDaChon.ItemHeight = 29;
            this.lstDanhSachDaChon.Location = new System.Drawing.Point(700, 290);
            this.lstDanhSachDaChon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstDanhSachDaChon.Name = "lstDanhSachDaChon";
            this.lstDanhSachDaChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDanhSachDaChon.Size = new System.Drawing.Size(309, 294);
            this.lstDanhSachDaChon.TabIndex = 4;
            // 
            // btnChonTungPhan
            // 
            this.btnChonTungPhan.Location = new System.Drawing.Point(467, 319);
            this.btnChonTungPhan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnChonTungPhan.Name = "btnChonTungPhan";
            this.btnChonTungPhan.Size = new System.Drawing.Size(156, 58);
            this.btnChonTungPhan.TabIndex = 5;
            this.btnChonTungPhan.Text = ">";
            this.btnChonTungPhan.UseVisualStyleBackColor = true;
            this.btnChonTungPhan.Click += new System.EventHandler(this.btnChonTungPhan_Click);
            // 
            // btnChonHet
            // 
            this.btnChonHet.Location = new System.Drawing.Point(467, 392);
            this.btnChonHet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnChonHet.Name = "btnChonHet";
            this.btnChonHet.Size = new System.Drawing.Size(156, 58);
            this.btnChonHet.TabIndex = 6;
            this.btnChonHet.Text = ">>";
            this.btnChonHet.UseVisualStyleBackColor = true;
            this.btnChonHet.Click += new System.EventHandler(this.btnChonHet_Click);
            // 
            // btnBoTungPhan
            // 
            this.btnBoTungPhan.Location = new System.Drawing.Point(467, 464);
            this.btnBoTungPhan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBoTungPhan.Name = "btnBoTungPhan";
            this.btnBoTungPhan.Size = new System.Drawing.Size(156, 58);
            this.btnBoTungPhan.TabIndex = 7;
            this.btnBoTungPhan.Text = "<";
            this.btnBoTungPhan.UseVisualStyleBackColor = true;
            this.btnBoTungPhan.Click += new System.EventHandler(this.btnBoTungPhan_Click);
            // 
            // btnBoHet
            // 
            this.btnBoHet.Location = new System.Drawing.Point(467, 536);
            this.btnBoHet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBoHet.Name = "btnBoHet";
            this.btnBoHet.Size = new System.Drawing.Size(156, 58);
            this.btnBoHet.TabIndex = 8;
            this.btnBoHet.Text = "<<";
            this.btnBoHet.UseVisualStyleBackColor = true;
            this.btnBoHet.Click += new System.EventHandler(this.btnBoHet_Click);
            // 
            // rtbKetQua
            // 
            this.rtbKetQua.Location = new System.Drawing.Point(78, 652);
            this.rtbKetQua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rtbKetQua.Name = "rtbKetQua";
            this.rtbKetQua.Size = new System.Drawing.Size(931, 216);
            this.rtbKetQua.TabIndex = 9;
            this.rtbKetQua.Text = "";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(78, 899);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(156, 58);
            this.btnNhap.TabIndex = 10;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(467, 899);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 58);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(856, 899);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 58);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chọn họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Danh sách các môn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Danh sách các môn đã chọn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 619);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kết quả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(356, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(414, 55);
            this.label7.TabIndex = 19;
            this.label7.Text = "Danh sách thể thao";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 1015);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.rtbKetQua);
            this.Controls.Add(this.btnBoHet);
            this.Controls.Add(this.btnBoTungPhan);
            this.Controls.Add(this.btnChonHet);
            this.Controls.Add(this.btnChonTungPhan);
            this.Controls.Add(this.lstDanhSachDaChon);
            this.Controls.Add(this.lstDanhSachMon);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.cmbHoTen);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.Text = "Danh Sách Thể Thao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHoTen;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.ListBox lstDanhSachMon;
        private System.Windows.Forms.ListBox lstDanhSachDaChon;
        private System.Windows.Forms.Button btnChonTungPhan;
        private System.Windows.Forms.Button btnChonHet;
        private System.Windows.Forms.Button btnBoTungPhan;
        private System.Windows.Forms.Button btnBoHet;
        private System.Windows.Forms.RichTextBox rtbKetQua;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

