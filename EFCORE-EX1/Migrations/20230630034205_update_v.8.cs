using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_EX1.Migrations
{
    /// <inheritdoc />
    public partial class update_v8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KhoiID",
                table: "Lop",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Khoi",
                columns: table => new
                {
                    KhoiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoi", x => x.KhoiID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lop_KhoiID",
                table: "Lop",
                column: "KhoiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Lop_Khoi_KhoiID",
                table: "Lop",
                column: "KhoiID",
                principalTable: "Khoi",
                principalColumn: "KhoiID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lop_Khoi_KhoiID",
                table: "Lop");

            migrationBuilder.DropTable(
                name: "Khoi");

            migrationBuilder.DropIndex(
                name: "IX_Lop_KhoiID",
                table: "Lop");

            migrationBuilder.DropColumn(
                name: "KhoiID",
                table: "Lop");
        }
    }
}
