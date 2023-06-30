using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_EX1.Entities
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<HocSinh> HocSinh { get; set; }
        public virtual DbSet<Lop> Lop { get; set; }
        public virtual DbSet<SinhVienLopMonHoc> SinhVienLopMonHoc { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }
        public virtual DbSet<Khoi> Khoi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server = THUOCLE\\THUOCLE; Database = QuanLyHocSinh; Trusted_Connection = True; " +
                $"TrustServerCertificate=True");
        }
    }
}
