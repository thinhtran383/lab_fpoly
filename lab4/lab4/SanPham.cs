using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class SanPham
    {
        private string tenSp { get; set; }
        private double donGia { get; set; }
        private double giamGia { get; set; }

        public SanPham(string tenSp, double donGia, double giamGia)
        {
            this.tenSp = tenSp;
            this.donGia = donGia;
            this.giamGia = giamGia;
        }

        public SanPham(string tenSp, double donGia)
        {
            this.tenSp = tenSp;
            this.donGia = donGia;
            this.giamGia = 0; 
        }

        private double getThueNhapKhau()
        {
            return donGia * 0.10;
        }

        public void xuat()
        {
            Console.WriteLine("Ten san pham: " + tenSp);
            Console.WriteLine("Don gia: " + donGia);
            Console.WriteLine("Giam gia: " + giamGia);
            Console.WriteLine("Thue nhau khau: " + getThueNhapKhau());
        }

        public void nhap()
        {
            Console.Write("Nhap ten san pham: ");
            tenSp = Console.ReadLine();

            Console.Write("Nhap don gia: ");
            donGia = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap giam gia: ");
            giamGia = Convert.ToDouble(Console.ReadLine());
        }
    }
}
