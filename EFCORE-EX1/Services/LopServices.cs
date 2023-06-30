using EFCORE_EX1.Entities;
using EFCORE_EX1.IServices;
using EFCORE_EX1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCORE_EX1.Services
{
    public class LopServices : ILopServices
    {
        private readonly AppDbContext dbContext;

        public LopServices()
        {
            this.dbContext = new AppDbContext();
        }

        public errType Sua(Lop lopUpdate)
        {
            Lop lopcantim = dbContext.Lop.FirstOrDefault(x=>x.LopID == lopUpdate.LopID);
            if(dbContext.Lop.ToList().Count==0)
            {
                return errType.DuLieuTrong;
            }
            else
            {
                if (lopcantim != null)
                {
                    lopcantim.TenLop = lopUpdate.TenLop;
                    dbContext.Update(lopcantim);
                    dbContext.SaveChanges();
                    return errType.ThanhCong;
                }
                    return errType.ChuaTonTai;
            }
        }

        public errType Them(Lop lop)
        {
            dbContext.Add(lop);
            dbContext.SaveChanges();
            return errType.ThanhCong;
        }

        public errType Xoa(int lopID)
        {
            Lop lopcantim = dbContext.Lop.FirstOrDefault(x => x.LopID == lopID);
            if (dbContext.Lop.ToList().Count == 0)
            {
                return errType.DuLieuTrong;
            }
            else
            {
                if (lopcantim != null)
                {
                    dbContext.Remove(lopcantim);
                    dbContext.SaveChanges();
                    return errType.ThanhCong;
                }
                return errType.ChuaTonTai;
            }
        }
        public Lop TimKiemLop(int lopID)
        {
            Lop lopcantim = dbContext.Lop.FirstOrDefault(x => x.LopID == lopID);
            return lopcantim;
        }

        public IEnumerable<Lop> LayDanhSachLop()
        {
            return dbContext.Lop .AsQueryable();
        }

        public IEnumerable<Lop> LayDanhSachLopGomHS()
        {
            return dbContext.Lop.Include(x => x.ListHocSinh).AsQueryable();
        }
    }
}
