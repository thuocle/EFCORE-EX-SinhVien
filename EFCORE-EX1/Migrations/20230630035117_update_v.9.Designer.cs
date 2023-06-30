﻿// <auto-generated />
using EFCORE_EX1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCORE_EX1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230630035117_update_v.9")]
    partial class update_v9
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCORE_EX1.Entities.HocSinh", b =>
                {
                    b.Property<int>("HocSinhID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HocSinhID"));

                    b.Property<double>("DiemTB")
                        .HasColumnType("float");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LopID")
                        .HasColumnType("int");

                    b.Property<string>("MaHS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QueQuan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

                    b.HasKey("HocSinhID");

                    b.HasIndex("LopID");

                    b.ToTable("HocSinh");
                });

            modelBuilder.Entity("EFCORE_EX1.Entities.Khoi", b =>
                {
                    b.Property<int>("KhoiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KhoiID"));

                    b.Property<string>("TenKhoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KhoiID");

                    b.ToTable("Khoi");
                });

            modelBuilder.Entity("EFCORE_EX1.Entities.Lop", b =>
                {
                    b.Property<int>("LopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LopID"));

                    b.Property<int>("KhoiID")
                        .HasColumnType("int");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LopID");

                    b.HasIndex("KhoiID");

                    b.ToTable("Lop");
                });

            modelBuilder.Entity("EFCORE_EX1.Entities.SinhVien", b =>
                {
                    b.Property<int>("SinhVienID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SinhVienID"));

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaSV")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("QueQuan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

                    b.HasKey("SinhVienID");

                    b.ToTable("SinhVien");
                });

            modelBuilder.Entity("EFCORE_EX1.Entities.SinhVienLopMonHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LopID")
                        .HasColumnType("int");

                    b.Property<int>("SinhVienID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LopID");

                    b.HasIndex("SinhVienID");

                    b.ToTable("SinhVienLopMonHoc");
                });

            modelBuilder.Entity("EFCORE_EX1.Entities.HocSinh", b =>
                {
                    b.HasOne("EFCORE_EX1.Entities.Lop", "Lop")
                        .WithMany("ListHocSinh")
                        .HasForeignKey("LopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lop");
                });

            modelBuilder.Entity("EFCORE_EX1.Entities.Lop", b =>
                {
                    b.HasOne("EFCORE_EX1.Entities.Khoi", "Khoi")
                        .WithMany("dsLop")
                        .HasForeignKey("KhoiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khoi");
                });

            modelBuilder.Entity("EFCORE_EX1.Entities.SinhVienLopMonHoc", b =>
                {
                    b.HasOne("EFCORE_EX1.Entities.Lop", "Lop")
                        .WithMany("SinhVienLopMonHocs")
                        .HasForeignKey("LopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCORE_EX1.Entities.SinhVien", "SinhVien")
                        .WithMany("SinhVienLopMonHocs")
                        .HasForeignKey("SinhVienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lop");

                    b.Navigation("SinhVien");
                });

            modelBuilder.Entity("EFCORE_EX1.Entities.Khoi", b =>
                {
                    b.Navigation("dsLop");
                });

            modelBuilder.Entity("EFCORE_EX1.Entities.Lop", b =>
                {
                    b.Navigation("ListHocSinh");

                    b.Navigation("SinhVienLopMonHocs");
                });

            modelBuilder.Entity("EFCORE_EX1.Entities.SinhVien", b =>
                {
                    b.Navigation("SinhVienLopMonHocs");
                });
#pragma warning restore 612, 618
        }
    }
}
