using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_EX1.Entities
{
    public class SinhVien : Nguoi
    {
        public int SinhVienID { get; set; }
        [Required(ErrorMessage = "Ma Sinh Vien khong duoc trong!")]
        [MinLength(3)]
        [MaxLength(10)]
        public int MaSV { get; set; }
        public IEnumerable<SinhVienLopMonHoc> SinhVienLopMonHocs { get; set; }
    }
}
