using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonlibDAO.Migrations
{
    /// <inheritdoc />
    public partial class Employees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AllowFRSUpdate",
                table: "tbl_Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeactivateReason_ID",
                table: "tbl_Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deactivated_On",
                table: "tbl_Employee",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dept_EMP_ID",
                table: "tbl_Employee",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsTeachingORNon",
                table: "tbl_Employee",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LocationUpdatedOn",
                table: "tbl_Employee",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotificationStatus",
                table: "tbl_Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Profile_update_Counts",
                table: "tbl_Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Profile_update_Status",
                table: "tbl_Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "aadhar",
                table: "tbl_Employee",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idHODLevel",
                table: "tbl_Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isFAC",
                table: "tbl_Employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isHOD",
                table: "tbl_Employee",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "multiLocation",
                table: "tbl_Employee",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_on",
                table: "tbl_Employee",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowFRSUpdate",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "DeactivateReason_ID",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "Deactivated_On",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "Dept_EMP_ID",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "IsTeachingORNon",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "LocationUpdatedOn",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "NotificationStatus",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "Profile_update_Counts",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "Profile_update_Status",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "aadhar",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "idHODLevel",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "isFAC",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "isHOD",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "multiLocation",
                table: "tbl_Employee");

            migrationBuilder.DropColumn(
                name: "updated_on",
                table: "tbl_Employee");
        }
    }
}
