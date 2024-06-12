namespace lab5
{
    partial class Bai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(204, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB2);
            this.groupBox1.Controls.Add(this.rB1);
            this.groupBox1.Location = new System.Drawing.Point(69, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn vui lòng chọn";
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(32, 127);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(290, 33);
            this.rB2.TabIndex = 1;
            this.rB2.TabStop = true;
            this.rB2.Text = "Giải phương trình bậc 2";
            this.rB2.UseVisualStyleBackColor = true;
            this.rB2.CheckedChanged += new System.EventHandler(this.rB2_CheckedChanged);
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Location = new System.Drawing.Point(32, 66);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(290, 33);
            this.rB1.TabIndex = 0;
            this.rB1.TabStop = true;
            this.rB1.Text = "Giải phương trình bậc 1";
            this.rB1.UseVisualStyleBackColor = true;
            this.rB1.CheckedChanged += new System.EventHandler(this.rB1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kết quả:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(181, 400);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(287, 35);
            this.txtA.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(181, 470);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(287, 35);
            this.txtB.TabIndex = 7;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(181, 541);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(287, 35);
            this.txtC.TabIndex = 8;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(181, 606);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(555, 35);
            this.txtResult.TabIndex = 9;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(517, 400);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(219, 100);
            this.btnSolve.TabIndex = 10;
            this.btnSolve.Text = "Giải";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(517, 533);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(219, 51);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 690);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnExit;
    }
}