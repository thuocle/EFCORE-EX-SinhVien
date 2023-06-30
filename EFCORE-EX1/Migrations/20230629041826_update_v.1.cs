using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_EX1.Migrations
{
    /// <inheritdoc />
    public partial class update_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LopID",
                table: "HocSinh",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    LopID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.LopID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HocSinh_LopID",
                table: "HocSinh",
                column: "LopID");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinh_Lop_LopID",
                table: "HocSinh",
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

            migrationBuilder.DropTable(
                name: "Lop");

            migrationBuilder.DropIndex(
                name: "IX_HocSinh_LopID",
                table: "HocSinh");

            migrationBuilder.DropColumn(
                name: "LopID",
                table: "HocSinh");
        }
    }
}
