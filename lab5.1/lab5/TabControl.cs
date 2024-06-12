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
    public partial class TabControl:Form
    {

        private Form bai1;
        private Form bai2;
        private Form bai3;

        public TabControl()
        {
            InitializeComponent();
            InitializeForms();
            LoadFormIntoTab(bai1,tBai1);
        }
        private void InitializeForms()
        {
            bai1 = new Bai1();
            bai2 = new Bai2();
            bai3 = new Bai3();
        }

        private void LoadFormIntoTab(Form form,TabPage tabPage)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tabPage.Controls.Clear();
            tabPage.Controls.Add(form);
            form.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender,EventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 0:
                LoadFormIntoTab(bai1,tBai1);
                break;
                case 1:
                LoadFormIntoTab(bai2,tBai2);
                break;
                case 2:
                LoadFormIntoTab(bai3,tBai3);
                break;
            }
        }
    }
}
