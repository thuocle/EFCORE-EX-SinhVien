using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_EX1.Migrations
{
    /// <inheritdoc />
    public partial class update_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocSinh_Lop_LopID",
                table: "HocSinh");

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

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    SinhVienID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSV = table.Column<int>(type: "int", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QueQuan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.SinhVienID);
                });

            migrationBuilder.CreateTable(
                name: "SinhVienLopMonHoc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinhVienID = table.Column<int>(type: "int", nullable: false),
                    LopID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVienLopMonHoc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinhVienLopMonHoc_SinhVien_SinhVienID",
                        column: x => x.SinhVienID,
                        principalTable: "SinhVien",
                        principalColumn: "SinhVienID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinhVienLopMonHoc_lop_LopID",
                        column: x => x.LopID,
                        principalTable: "lop",
                        principalColumn: "LopID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinhVienLopMonHoc_LopID",
                table: "SinhVienLopMonHoc",
                column: "LopID");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVienLopMonHoc_SinhVienID",
                table: "SinhVienLopMonHoc",
                column: "SinhVienID");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinh_lop_LopID",
                table: "HocSinh",
                column: "LopID",
                principalTable: "lop",
                principalColumn: "LopID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocSinh_lop_LopID",
                table: "HocSinh");

            migrationBuilder.DropTable(
                name: "SinhVienLopMonHoc");

            migrationBuilder.DropTable(
                name: "SinhVien");

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
        }
    }
}
