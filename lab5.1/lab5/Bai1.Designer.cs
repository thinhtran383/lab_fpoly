namespace lab5
{
    partial class Bai1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoM = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập số M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            // 
            // txtSoM
            // 
            this.txtSoM.Location = new System.Drawing.Point(313, 148);
            this.txtSoM.Name = "txtSoM";
            this.txtSoM.Size = new System.Drawing.Size(310, 35);
            this.txtSoM.TabIndex = 4;
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(313, 215);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(310, 35);
            this.txtSoN.TabIndex = 5;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(313, 274);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(310, 35);
            this.txtKetQua.TabIndex = 6;
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(90, 364);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(98, 53);
            this.btCong.TabIndex = 7;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.Cong_Click);
            // 
            // btTru
            // 
            this.btTru.Location = new System.Drawing.Point(194, 364);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(98, 53);
            this.btTru.TabIndex = 8;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.Tru_Click);
            // 
            // btNhan
            // 
            this.btNhan.Location = new System.Drawing.Point(298, 364);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(98, 53);
            this.btNhan.TabIndex = 9;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.Nhan_Click);
            // 
            // btChia
            // 
            this.btChia.Location = new System.Drawing.Point(402, 364);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(98, 53);
            this.btChia.TabIndex = 10;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.Chia_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(506, 364);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(98, 53);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(610, 364);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(97, 53);
            this.btThoat.TabIndex = 12;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoM;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
    }
}

