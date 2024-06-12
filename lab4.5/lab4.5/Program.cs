using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._5
{
    class Program
    {
        public static void Main()
        {
            BookList bookList = new BookList();

            bookList.ThemSach(new Book("Sach A", "Tac gia B", "NXB X", 2020, "1234567890", new List<string> { "Chuong 1", "Chuong 2" }));
            bookList.ThemSach(new Book("Sach B", "Tac gia A", "NXB Y", 2019, "0987654321", new List<string> { "Chuong 1", "Chuong 2", "Chuong 3" }));

            Console.WriteLine("Danh sach sach ban dau:");
            bookList.XuatDanhSach();

            bookList.SapXepTheoTenTacGia();
            Console.WriteLine("Danh sach sach xep theo ten tac gia:");
            bookList.XuatDanhSach();

            bookList.SapXepTheoTenSach();
            Console.WriteLine("Danh sach sach sap xep theo ten sach:");
            bookList.XuatDanhSach();

            bookList.SapXepTheoNamXuatBan();
            Console.WriteLine("Danh sach sach sap xep theo nam xuat ban:");
            bookList.XuatDanhSach();

            Console.ReadKey();
        }
    }
}
