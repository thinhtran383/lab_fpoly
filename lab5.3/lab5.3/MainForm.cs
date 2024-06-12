using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5._3
{
    public partial class MainForm:Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadInitialData();
        }

        private void LoadInitialData()
        {
            txtNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtGio.Text = DateTime.Now.ToString("hh:mm:ss tt");

            lstDanhSachMon.Items.AddRange(new object[]
            {
                "Bóng đá",
                "Bóng bàn",
                "Nhảy dù",
                "Bập bênh",
                "Cầu lông",
                "Bắn bi"
            });

            cmbHoTen.Items.AddRange(new object[]
            {
                "SV1",
                "SV2",
                "SV3",
                "SV4",
                "SV5"
            });
            cmbHoTen.SelectedIndex = 0;
        }

        private void btnChonTungPhan_Click(object sender,EventArgs e)
        {
            while(lstDanhSachMon.SelectedItems.Count > 0)
            {
                lstDanhSachDaChon.Items.Add(lstDanhSachMon.SelectedItems[0]);
                lstDanhSachMon.Items.Remove(lstDanhSachMon.SelectedItems[0]);
            }
        }

        private void btnChonHet_Click(object sender,EventArgs e)
        {
            foreach(var item in lstDanhSachMon.Items)
            {
                lstDanhSachDaChon.Items.Add(item);
            }
            lstDanhSachMon.Items.Clear();
        }

        private void btnBoTungPhan_Click(object sender,EventArgs e)
        {
            while(lstDanhSachDaChon.SelectedItems.Count > 0)
            {
                lstDanhSachMon.Items.Add(lstDanhSachDaChon.SelectedItems[0]);
                lstDanhSachDaChon.Items.Remove(lstDanhSachDaChon.SelectedItems[0]);
            }
        }

        private void btnBoHet_Click(object sender,EventArgs e)
        {
            foreach(var item in lstDanhSachDaChon.Items)
            {
                lstDanhSachMon.Items.Add(item);
            }
            lstDanhSachDaChon.Items.Clear();
        }

        private void btnNhap_Click(object sender,EventArgs e)
        {
            rtbKetQua.Clear();
            rtbKetQua.AppendText($"{cmbHoTen.Text}\n");
            rtbKetQua.AppendText($"{txtNgay.Text}. {txtGio.Text}\n");
            rtbKetQua.AppendText("Môn chọn:\n");

            foreach(var item in lstDanhSachDaChon.Items)
            {
                rtbKetQua.AppendText($"{item}, ");
            }
        }

        private void btnReset_Click(object sender,EventArgs e)
        {
            lstDanhSachMon.Items.Clear();

            LoadInitialData();
            lstDanhSachDaChon.Items.Clear();
            rtbKetQua.Clear();
        }

        private void btnThoat_Click(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
