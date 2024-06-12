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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
            txtKetQua.ReadOnly = true;
        }

        private void Cong_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtSoM.Text);
            int n = int.Parse(txtSoN.Text);
            int tong = n + m;

            txtKetQua.Text = tong.ToString();
        }

        private void Tru_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtSoM.Text);
            int n = int.Parse(txtSoN.Text);
            int hieu = n - m;

            txtKetQua.Text = hieu.ToString();
        }

        private void Nhan_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtSoM.Text);
            int n = int.Parse(txtSoN.Text);

            int tich = n * m;

            txtKetQua.Text = tich.ToString();
        }

        private void Chia_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txtSoM.Text);
            int n = int.Parse(txtSoN.Text);

            if(m == 0)
            {
                MessageBox.Show("Cannot divide by zero","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            double thuong = (double)n / m;
            txtKetQua.Text = thuong.ToString();
        }

        private void Xoa_Click(object sender,EventArgs e)
        {
            txtSoM.Clear();
            txtSoN.Clear();
            txtKetQua.Clear();
        }

        private void Thoat_Click(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
