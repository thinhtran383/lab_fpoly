namespace lab5
{
    partial class TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tBai1 = new System.Windows.Forms.TabPage();
            this.tBai2 = new System.Windows.Forms.TabPage();
            this.tBai3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tBai1);
            this.tabControl1.Controls.Add(this.tBai2);
            this.tabControl1.Controls.Add(this.tBai3);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1121, 952);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tBai1
            // 
            this.tBai1.Location = new System.Drawing.Point(10, 47);
            this.tBai1.Name = "tBai1";
            this.tBai1.Padding = new System.Windows.Forms.Padding(3);
            this.tBai1.Size = new System.Drawing.Size(1101, 895);
            this.tBai1.TabIndex = 0;
            this.tBai1.Text = "Bài 1";
            this.tBai1.UseVisualStyleBackColor = true;
            // 
            // tBai2
            // 
            this.tBai2.Location = new System.Drawing.Point(10, 47);
            this.tBai2.Name = "tBai2";
            this.tBai2.Padding = new System.Windows.Forms.Padding(3);
            this.tBai2.Size = new System.Drawing.Size(944, 895);
            this.tBai2.TabIndex = 1;
            this.tBai2.Text = "Bài 2";
            this.tBai2.UseVisualStyleBackColor = true;
            // 
            // tBai3
            // 
            this.tBai3.Location = new System.Drawing.Point(10, 47);
            this.tBai3.Name = "tBai3";
            this.tBai3.Size = new System.Drawing.Size(944, 895);
            this.tBai3.TabIndex = 2;
            this.tBai3.Text = "Bài 3";
            this.tBai3.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 976);
            this.Controls.Add(this.tabControl1);
            this.Name = "TabControl";
            this.Text = "TabControl";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tBai1;
        private System.Windows.Forms.TabPage tBai2;
        private System.Windows.Forms.TabPage tBai3;
    }
}