using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._5
{
    public class BookList
    {
        private List<Book> books;

        public BookList()
        {
            books = new List<Book>();
        }

        public void ThemSach(Book book)
        {
            books.Add(book);
        }

        public void XuatDanhSach()
        {
            foreach (var book in books)
            {
                book.XuatThongTin();
                Console.WriteLine();
            }
        }

        public void SapXepTheoTenTacGia()
        {
            books.Sort((x, y) => x.TacGia.CompareTo(y.TacGia));
        }

        public void SapXepTheoTenSach()
        {
            books.Sort((x, y) => x.TenSach.CompareTo(y.TenSach));
        }

        public void SapXepTheoNamXuatBan()
        {
            books.Sort((x, y) => x.NamXuatBan.CompareTo(y.NamXuatBan));
        }
    }
}
