namespace lab5
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBai1,
            this.menuBai2,
            this.menuBai3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 41);
            this.toolStripMenuItem1.Text = "Chọn Bài";
            // 
            // menuBai1
            // 
            this.menuBai1.Name = "menuBai1";
            this.menuBai1.Size = new System.Drawing.Size(403, 48);
            this.menuBai1.Text = "Bài 1";
            this.menuBai1.Click += new System.EventHandler(this.menuBai1_Click);
            // 
            // menuBai2
            // 
            this.menuBai2.Name = "menuBai2";
            this.menuBai2.Size = new System.Drawing.Size(403, 48);
            this.menuBai2.Text = "Bài 2";
            this.menuBai2.Click += new System.EventHandler(this.menuBai2_Click);
            // 
            // menuBai3
            // 
            this.menuBai3.Name = "menuBai3";
            this.menuBai3.Size = new System.Drawing.Size(403, 48);
            this.menuBai3.Text = "Bài 3";
            this.menuBai3.Click += new System.EventHandler(this.menuBai3_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 48);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1027, 948);
            this.panel.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 997);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuBai1;
        private System.Windows.Forms.ToolStripMenuItem menuBai2;
        private System.Windows.Forms.ToolStripMenuItem menuBai3;
        private System.Windows.Forms.Panel panel;
    }
}