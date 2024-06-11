using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class empupdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentEmployee_Employees_EmployeeId",
                table: "AssignmentEmployee");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "AssignmentEmployee",
                newName: "EmployeesEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignmentEmployee_EmployeeId",
                table: "AssignmentEmployee",
                newName: "IX_AssignmentEmployee_EmployeesEmployeeId");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 11, 10, 5, 19, 795, DateTimeKind.Local).AddTicks(5031), new DateTime(2024, 6, 11, 9, 50, 19, 795, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 11, 10, 20, 19, 795, DateTimeKind.Local).AddTicks(5054), new DateTime(2024, 6, 11, 10, 5, 19, 795, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 11, 10, 30, 19, 795, DateTimeKind.Local).AddTicks(5115), new DateTime(2024, 6, 11, 10, 20, 19, 795, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentEmployee_Employees_EmployeesEmployeeId",
                table: "AssignmentEmployee",
                column: "EmployeesEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignmentEmployee_Employees_EmployeesEmployeeId",
                table: "AssignmentEmployee");

            migrationBuilder.RenameColumn(
                name: "EmployeesEmployeeId",
                table: "AssignmentEmployee",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignmentEmployee_EmployeesEmployeeId",
                table: "AssignmentEmployee",
                newName: "IX_AssignmentEmployee_EmployeeId");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 8, 14, 626, DateTimeKind.Local).AddTicks(8647), new DateTime(2024, 6, 4, 11, 53, 14, 626, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 23, 14, 626, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 6, 4, 12, 8, 14, 626, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 4, 12, 33, 14, 626, DateTimeKind.Local).AddTicks(8686), new DateTime(2024, 6, 4, 12, 23, 14, 626, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.AddForeignKey(
                name: "FK_AssignmentEmployee_Employees_EmployeeId",
                table: "AssignmentEmployee",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
