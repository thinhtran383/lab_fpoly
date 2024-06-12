using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._5
{
    public class Book : IBook, IComparable<Book>
    {
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public string ISBN { get; set; }
        public List<string> ChuongSach { get; set; }

        public Book(string tenSach, string tacGia, string nhaXuatBan, int namXuatBan, string isbn, List<string> chuongSach)
        {
            TenSach = tenSach;
            TacGia = tacGia;
            NhaXuatBan = nhaXuatBan;
            NamXuatBan = namXuatBan;
            ISBN = isbn;
            ChuongSach = chuongSach;
        }

        public void XuatThongTin()
        {
            Console.WriteLine($"Ten sach: {TenSach}");
            Console.WriteLine($"Tac gia: {TacGia}");
            Console.WriteLine($"Nha xuat ban: {NhaXuatBan}");
            Console.WriteLine($"Nam xuat ban: {NamXuatBan}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine("Cac chuong sach:");
            foreach (var chuong in ChuongSach)
            {
                Console.WriteLine($" - {chuong}");
            }
        }

        public int CompareTo(Book other)
        {
            return TenSach.CompareTo(other.TenSach);
        }
    }
}
