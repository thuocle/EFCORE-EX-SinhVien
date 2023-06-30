using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_EX1.Entities
{
    public class SinhVienLopMonHoc
    {
        public int Id { get; set; }
        public int SinhVienID { get; set; }
        public SinhVien SinhVien { get; set; }
        public int LopID { get; set; }  
        public Lop Lop { get; set; }
    }
}
