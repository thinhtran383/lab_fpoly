using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        public static void Main()
        {
            SanPham sp1 = new SanPham("San pham 1", 1000, 100);

            SanPham sp2 = new SanPham("San pham 2", 2000);

            Console.WriteLine("Thong tin san pham 1:");
            sp1.xuat();

            Console.WriteLine("\nThong tin san pham 2:");
            sp2.xuat();
        }
    }
}
