using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._5
{
    public interface IBook
    {
        string TenSach { get; set; }
        string TacGia { get; set; }
        string NhaXuatBan { get; set; }
        int NamXuatBan { get; set; }
        string ISBN { get; set; }
        List<string> ChuongSach { get; set; }

        void XuatThongTin();
    }
}
