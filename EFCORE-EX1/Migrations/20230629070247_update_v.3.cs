using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_EX1.Migrations
{
    /// <inheritdoc />
    public partial class update_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocSinh_lop_LopID",
                table: "HocSinh");

            migrationBuilder.DropForeignKey(
                name: "FK_SinhVienLopMonHoc_lop_LopID",
                table: "SinhVienLopMonHoc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lop",
                table: "lop");

            migrationBuilder.RenameTable(
                name: "lop",
                newName: "Lop");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lop",
                table: "Lop",
                column: "LopID");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinh_Lop_LopID",
                table: "HocSinh",
                column: "LopID",
                principalTable: "Lop",
                principalColumn: "LopID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SinhVienLopMonHoc_Lop_LopID",
                table: "SinhVienLopMonHoc",
                column: "LopID",
                principalTable: "Lop",
                principalColumn: "LopID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocSinh_Lop_LopID",
                table: "HocSinh");

            migrationBuilder.DropForeignKey(
                name: "FK_SinhVienLopMonHoc_Lop_LopID",
                table: "SinhVienLopMonHoc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lop",
                table: "Lop");

            migrationBuilder.RenameTable(
                name: "Lop",
                newName: "lop");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lop",
                table: "lop",
                column: "LopID");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinh_lop_LopID",
                table: "HocSinh",
                column: "LopID",
                principalTable: "lop",
                principalColumn: "LopID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SinhVienLopMonHoc_lop_LopID",
                table: "SinhVienLopMonHoc",
                column: "LopID",
                principalTable: "lop",
                principalColumn: "LopID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
