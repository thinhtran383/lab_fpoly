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
    public partial class Bai2:Form
    {
        public Bai2()
        {
            InitializeComponent();
            rBCNN.Checked = true;
            txtResult.ReadOnly = true;
        }

        private int UCLN(int a,int b)
        {
            if(a == 0 || b == 0)
            {
                return a + b;
            }
            while(a != b)
            {
                if(a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        private int BCNN(int a,int b)
        {
            return a * b / UCLN(a,b);
        }

        private void btnFind_Click(object sender,EventArgs e)
        {
            if(rBCNN.Checked)
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                txtResult.Text = BCNN(a,b).ToString();
            }
            else
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                txtResult.Text = UCLN(a,b).ToString();
            }
        }

        private void btnRefresh_Click(object sender,EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtResult.Text = "";
        }

        private void btnClose_Click(object sender,EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?","Close",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
