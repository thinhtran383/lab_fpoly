namespace lab5
{
    partial class Bai2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBCNN = new System.Windows.Forms.RadioButton();
            this.rUCLN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(147, 128);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(287, 35);
            this.txtB.TabIndex = 3;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(147, 66);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(287, 35);
            this.txtA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBCNN);
            this.groupBox2.Controls.Add(this.rUCLN);
            this.groupBox2.Location = new System.Drawing.Point(643, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn tìm";
            // 
            // rBCNN
            // 
            this.rBCNN.AutoSize = true;
            this.rBCNN.Location = new System.Drawing.Point(28, 105);
            this.rBCNN.Name = "rBCNN";
            this.rBCNN.Size = new System.Drawing.Size(113, 33);
            this.rBCNN.TabIndex = 1;
            this.rBCNN.TabStop = true;
            this.rBCNN.Text = "BCNN";
            this.rBCNN.UseVisualStyleBackColor = true;
            // 
            // rUCLN
            // 
            this.rUCLN.AutoSize = true;
            this.rUCLN.Location = new System.Drawing.Point(28, 57);
            this.rUCLN.Name = "rUCLN";
            this.rUCLN.Size = new System.Drawing.Size(109, 33);
            this.rUCLN.TabIndex = 0;
            this.rUCLN.TabStop = true;
            this.rUCLN.Text = "UCLN";
            this.rUCLN.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnFind);
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Location = new System.Drawing.Point(24, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(929, 225);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(425, 140);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 48);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(256, 140);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 48);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Bỏ qua";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(89, 140);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(110, 48);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(147, 52);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(287, 35);
            this.txtResult.TabIndex = 0;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 510);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBCNN;
        private System.Windows.Forms.RadioButton rUCLN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtResult;
    }
}