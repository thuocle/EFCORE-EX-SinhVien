using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCORE_EX1.Entities;
using EFCORE_EX1.Helper;
namespace EFCORE_EX1.IServices
{
    public interface IHocSinhServices
    {
        errType ThemHS(HocSinh hs);
        errType ThemListHS(List<HocSinh> lstHS);
        List<HocSinh> LayDSHocSinh();
        /*errType SuaHS(HocSinh hs);
        errType XoaHS(int hsID);
        errType TimKiemHS(int hsID);*/
    }
}
