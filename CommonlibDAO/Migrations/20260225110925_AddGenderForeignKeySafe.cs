using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonlibDAO.Migrations
{
    /// <inheritdoc />
    public partial class AddGenderForeignKeySafe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "tbl_Employee");

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "tbl_Employee",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tbl_Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Employee_GenderId",
                table: "tbl_Employee",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Employee_tbl_Gender_GenderId",
                table: "tbl_Employee",
                column: "GenderId",
                principalTable: "tbl_Gender",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Employee_tbl_Gender_GenderId",
                table: "tbl_Employee");

            migrationBuilder.DropTable(
                name: "tbl_Gender");

            migrationBuilder.DropIndex(
                name: "IX_tbl_Employee_GenderId",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "tbl_Employee");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "tbl_Employee",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }
    }
}
