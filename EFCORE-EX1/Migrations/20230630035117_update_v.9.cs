using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_EX1.Migrations
{
    /// <inheritdoc />
    public partial class update_v9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lop_Khoi_KhoiID",
                table: "Lop");

            migrationBuilder.AlterColumn<int>(
                name: "KhoiID",
                table: "Lop",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lop_Khoi_KhoiID",
                table: "Lop",
                column: "KhoiID",
                principalTable: "Khoi",
                principalColumn: "KhoiID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lop_Khoi_KhoiID",
                table: "Lop");

            migrationBuilder.AlterColumn<int>(
                name: "KhoiID",
                table: "Lop",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Lop_Khoi_KhoiID",
                table: "Lop",
                column: "KhoiID",
                principalTable: "Khoi",
                principalColumn: "KhoiID");
        }
    }
}
