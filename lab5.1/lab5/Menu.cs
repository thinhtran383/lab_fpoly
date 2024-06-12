using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Menu:Form
    {
        private Form bai1;
        private Form bai2;
        private Form bai3;
        public Menu()
        {
            InitializeComponent();
            InitializeForms();
        }
        private void InitializeForms()
        {
            bai1 = new Bai1();
            bai2 = new Bai2();
            bai3 = new Bai3();
        }

        private void LoadFormIntoPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panel.Controls.Clear(); 
            this.panel.Controls.Add(form); 
            form.Show();
        }

        private void menuBai1_Click(object sender,EventArgs e)
        {
            LoadFormIntoPanel(bai1);
        }

        private void menuBai2_Click(object sender,EventArgs e)
        {
            LoadFormIntoPanel(bai2);
        }

        private void menuBai3_Click(object sender,EventArgs e)
        {
            LoadFormIntoPanel(bai3);
        }
    }
}