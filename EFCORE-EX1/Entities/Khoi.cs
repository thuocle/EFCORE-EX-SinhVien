using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_EX1.Entities
{
    public class Khoi
    {
        public int KhoiID { get; set; }
        public string TenKhoi { get; set; }
        public IEnumerable<Lop> dsLop { get; set; }
    }
}
