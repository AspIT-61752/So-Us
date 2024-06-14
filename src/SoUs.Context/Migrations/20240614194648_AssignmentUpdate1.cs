using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AssignmentUpdate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 14, 15, 1, 48, 169, DateTimeKind.Local).AddTicks(7288), new DateTime(2024, 6, 14, 14, 46, 48, 169, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 14, 15, 16, 48, 169, DateTimeKind.Local).AddTicks(7313), new DateTime(2024, 6, 14, 15, 1, 48, 169, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 14, 15, 26, 48, 169, DateTimeKind.Local).AddTicks(7331), new DateTime(2024, 6, 14, 15, 16, 48, 169, DateTimeKind.Local).AddTicks(7329) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
