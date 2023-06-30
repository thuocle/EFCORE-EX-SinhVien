using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EFCORE_EX1.Entities
{
    public abstract class Nguoi
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }

        public virtual void NhapThongTin()
        {
            
            Console.WriteLine("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap Tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap GioiTinh: ");
            GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhap QueQuan: ");
            QueQuan = Console.ReadLine();
        }
        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}\n" +
                $"Tuoi: {Tuoi}\n" +
                $"Gioi Tinh: {GioiTinh}\n" +
                $"Que quan: {QueQuan}");
        }
    }
}
