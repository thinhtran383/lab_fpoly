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
    public partial class Bai3:Form
    {
        public Bai3()
        {
            InitializeComponent();
            rB1.Checked=true;
        }

        private void giaiPTB1(float a,float b)
        {
            if(a==0)
            {
                if(b==0)
                {
                    txtResult.Text="Phuong trinh vo so nghiem";
                }
                else
                {
                    txtResult.Text="Phuong trinh vo nghiem";
                }
            }
            else
            {
                txtResult.Text="Phuong trinh co nghiem x="+(-b/a);
            }
        }

        private void giaiPTB2(float a,float b,float c)
        {
            float delta=b*b-4*a*c;
            if(delta<0)
            {
                txtResult.Text="Phuong trinh vo nghiem";
            }
            else if(delta==0)
            {
                txtResult.Text="Phuong trinh co nghiem kep x1=x2="+(-b/(2*a));
            }
            else
            {
                txtResult.Text="Phuong trinh co 2 nghiem phan biet \nx1="+((-b+Math.Sqrt(delta))/(2*a))+"\n x2="+((-b-Math.Sqrt(delta))/(2*a));
            }
        }

        private void rB1_CheckedChanged(object sender,EventArgs e)
        {
            txtC.Enabled=false;
        }

        private void rB2_CheckedChanged(object sender,EventArgs e)
        {
            txtC.Enabled=true;
        }

        private void btnSolve_Click(object sender,EventArgs e)
        {
            if(rB1.Checked)
            {
                giaiPTB1(float.Parse(txtA.Text),float.Parse(txtB.Text));
            }
            else
            {
                giaiPTB2(float.Parse(txtA.Text),float.Parse(txtB.Text),float.Parse(txtC.Text));
            }
        }

        private void btnExit_Click(object sender,EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?","Close",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
