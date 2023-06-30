using EFCORE_EX1.Entities;
using EFCORE_EX1.IServices;
using EFCORE_EX1.Services;
using EFCORE_EX1.Helper;
using System.Collections.Generic;
static void Main()
{
    ILopServices lopServices = new LopServices() { };
    IHocSinhServices hocSinhServices = new HocSinhServices() { };
    /* List<Lop> listLop = lopServices.LayDanhSachLop().ToList();*/
    /* List<HocSinh> lstHS = hocSinhServices.LayDSHocSinh();*/
    /*var selectLST = lstHS.Select(x => new { hocsinhid = x.HocSinhID, tenlop = x.Lop.TenLop, tenkhoi = x.Lop.Khoi.TenKhoi }

    );*/
    /*  Lop newlop = new Lop() { 
          TenLop = "A6",
          Khoi = new Khoi() { TenKhoi = "3"}
      };*/
    /*lopServices.Them(newlop);*/
    /*listLop.ForEach(lop =>
    {
        for (int i = 1; i < 6; i++)
        {
            HocSinh newHS = new HocSinh() 
            {
                HoTen = $"HS{i}Lop{lop.LopID}",
                Tuoi = 20,
                GioiTinh = "Nam",
                QueQuan = "ha noi",
                MaHS = $"MaHS{i}Lop{lop.LopID}",
                DiemTB = 10,
                LopID = lop.LopID
            };
            hocSinhServices.ThemHS(newHS);
        }
    }
    );*/
    List<HocSinh> lstHS = new List<HocSinh>()
    {
        new HocSinh(){
                HoTen = $"HS{3}Lop{6}",
                Tuoi = 20,
                GioiTinh = "Nam",
                QueQuan = "ha noi",
                MaHS = $"MaHS{1}Lop{6}",
                DiemTB = 10,
                LopID = 6
        },
        new HocSinh(){
                HoTen = $"HS{4}Lop{6}",
                Tuoi = 20,
                GioiTinh = "Nam",
                QueQuan = "ha noi",
                MaHS = $"MaHS{2}Lop{6}",
                DiemTB = 10,
                LopID = 6
        }
    };
    ErrorHelper.Log(hocSinhServices.ThemListHS(lstHS));
}
Main();