using EFCORE_EX1.Entities;
using EFCORE_EX1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_EX1.IServices
{
    public interface ILopServices
    {
        errType Them(Lop lop);
        errType Sua(Lop lopUpdate);
        errType Xoa(int lopID);
        Lop TimKiemLop(int lopID);
        IEnumerable<Lop> LayDanhSachLop();
        IEnumerable<Lop> LayDanhSachLopGomHS();
    }
}
