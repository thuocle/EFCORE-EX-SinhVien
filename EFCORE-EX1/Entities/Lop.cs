using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_EX1.Entities
{
    public class Lop
    {
        public int LopID { get; set; }
        public string TenLop { get; set; }
        public IEnumerable<HocSinh> ListHocSinh { get; set; }
        public IEnumerable<SinhVienLopMonHoc> SinhVienLopMonHocs { get; set; }
        public int KhoiID { get; set; }
        public Khoi Khoi { get; set; }
    }
}
