using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EFCORE_EX1.Entities
{
    public class HocSinh : Nguoi
    {
        [Key]
        public int HocSinhID { get; set; }
        public string MaHS { get; set; }
        public double DiemTB { get; set; }
        public int LopID { get; set; }
        public Lop Lop { get; set; }
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Ma hoc sinh :{MaHS}\n" +
                $"Diem TB: {DiemTB}");
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.WriteLine("Nhap ma hoc sinh: ");
            MaHS = Console.ReadLine();
            Console.WriteLine("Nhap DiemTB hoc sinh: ");
            DiemTB = double.Parse(Console.ReadLine());
        }
    }

}
