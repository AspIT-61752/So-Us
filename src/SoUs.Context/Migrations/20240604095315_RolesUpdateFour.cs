using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RolesUpdateFour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CareCenters_Employees_EmployeeId",
                table: "CareCenters");

            migrationBuilder.DropIndex(
                name: "IX_CareCenters_EmployeeId",
                table: "CareCenters");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "CareCenters");

            migrationBuilder.AddColumn<int>(
                name: "CareCenterId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "State", "Street", "Zip" },
                values: new object[] { 1, "Vejle", "Region Syddanmark", "Boulevarden 48", 7100 });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "DiagnosisId", "Description", "Name", "ResidentId" },
                values: new object[,]
                {
                    { 1, "Attention Deficit Hyperactivity Disorder", "ADHD", null },
                    { 2, "Autism Spectrum Disorder", "Autisme", null }
                });

            migrationBuilder.InsertData(
                table: "CareCenters",
                columns: new[] { "CareCenterId", "AddressId", "Name" },
                values: new object[] { 1, 1, "Vejle Kommune - Alderdomshjem" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CareCenterId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Mads Mikkelsen" },
                    { 2, 1, "Morten Bossen" },
                    { 3, 1, "Michael Jensen" }
                });

            migrationBuilder.InsertData(
                table: "Residents",
                columns: new[] { "ResidentId", "CareCenterId", "Name", "Notes", "RoomNumber" },
                values: new object[] { 1, 1, "Jens Hansen", "Jens er en stille og rolig mand, der elsker at læse bøger. Han har brug for hjælp til at komme ud af sengen og til at komme i bad.", "A1" });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "IsComplete", "Name", "ResidentId", "TimeEnd", "TimeStart" },
                values: new object[,]
                {
                    { 1, false, "Hjælp til at komme ud af sengen", 1, new DateTime(2024, 6, 4, 12, 8, 14, 626, DateTimeKind.Local).AddTicks(8647), new DateTime(2024, 6, 4, 11, 53, 14, 626, DateTimeKind.Local).AddTicks(8600) },
                    { 2, false, "Hjælp til at komme i bad", 1, new DateTime(2024, 6, 4, 12, 23, 14, 626, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 6, 4, 12, 8, 14, 626, DateTimeKind.Local).AddTicks(8668) },
                    { 3, false, "Give medicin", 1, new DateTime(2024, 6, 4, 12, 33, 14, 626, DateTimeKind.Local).AddTicks(8686), new DateTime(2024, 6, 4, 12, 23, 14, 626, DateTimeKind.Local).AddTicks(8684) }
                });

            migrationBuilder.InsertData(
                table: "Medicine",
                columns: new[] { "MedicineId", "Administered", "AssignmentId", "Dosage", "Name", "Unit" },
                values: new object[] { 1, false, 3, 1, "Panodil", "stk" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CareCenterId",
                table: "Employees",
                column: "CareCenterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_CareCenters_CareCenterId",
                table: "Employees",
                column: "CareCenterId",
                principalTable: "CareCenters",
                principalColumn: "CareCenterId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_CareCenters_CareCenterId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CareCenterId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "DiagnosisId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "DiagnosisId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicine",
                keyColumn: "MedicineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CareCenterId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "CareCenters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CareCenters_EmployeeId",
                table: "CareCenters",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CareCenters_Employees_EmployeeId",
                table: "CareCenters",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
