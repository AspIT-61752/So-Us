using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesUpdated1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 22, 33, 518, DateTimeKind.Local).AddTicks(8998), new DateTime(2024, 6, 15, 16, 7, 33, 518, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 37, 33, 518, DateTimeKind.Local).AddTicks(9024), new DateTime(2024, 6, 15, 16, 22, 33, 518, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 47, 33, 518, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 6, 15, 16, 37, 33, 518, DateTimeKind.Local).AddTicks(9040) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
