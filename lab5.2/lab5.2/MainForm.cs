using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5._2
{
    public partial class MainForm:Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnTinh_Click(object sender,EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            int chiSoCu = int.Parse(txtChiSoCu.Text);
            int chiSoMoi = int.Parse(txtChiSoMoi.Text);

            // Tính số kWh tiêu thụ
            int soKWTieuThu = chiSoMoi - chiSoCu;
            txtSoKWTieuThu.Text = soKWTieuThu.ToString();

            // Tính số kWh trong định mức và vượt định mức
            int dinhMuc = 50;
            int giaTrongDinhMuc = 500;
            int giaVuotDinhMuc = 1000;

            int soKWDinhMuc = Math.Min(soKWTieuThu,dinhMuc);
            int soKWVuotDinhMuc = Math.Max(0,soKWTieuThu - dinhMuc);

            txtSoKWDinhMuc.Text = soKWDinhMuc.ToString();
            txtSoKWVuotDinhMuc.Text = soKWVuotDinhMuc.ToString();

            // Tính tổng tiền phải trả
            int tongTien = soKWDinhMuc * giaTrongDinhMuc + soKWVuotDinhMuc * giaVuotDinhMuc;
            txtTongTien.Text = tongTien.ToString();

            // Hiển thị thông tin trong RichTextBox
            rtbKetQua.Text = $"Khách hàng: {cmbKhachHang.Text}\n";
            rtbKetQua.Text += $"Số kWh tiêu thụ: {soKWTieuThu}\n";
            rtbKetQua.Text += $"Tổng tiền: {tongTien}";
        }

        private void btnThoat_Click(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}

