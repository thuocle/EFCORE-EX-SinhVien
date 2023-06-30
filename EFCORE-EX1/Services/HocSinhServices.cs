using EFCORE_EX1.Entities;
using EFCORE_EX1.Helper;
using EFCORE_EX1.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_EX1.Services
{
    public class HocSinhServices : IHocSinhServices
    {
        private readonly AppDbContext dbContext;

        public HocSinhServices()
        {
            this.dbContext = new AppDbContext();
        }

        public List<HocSinh> LayDSHocSinh()
        {
            return dbContext.HocSinh.Include(x=>x.Lop).ThenInclude(x=>x.Khoi).ToList();
        }

        public errType ThemHS(HocSinh hs)
        {
            dbContext.HocSinh.Add(hs);
            dbContext.SaveChanges();
            return errType.ThanhCong;
        }

        public errType ThemListHS(List<HocSinh> lstHS)
        {
            using (var trans = dbContext.Database.BeginTransaction()) 
            {
                try
                {
                    foreach (var item in lstHS)
                    {
                        dbContext.Add(item);
                        dbContext.SaveChanges();
                    }
                    trans.Commit();
                    return errType.ThanhCong;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    return errType.ThatBai;
                }
            }
        }
    }
}
