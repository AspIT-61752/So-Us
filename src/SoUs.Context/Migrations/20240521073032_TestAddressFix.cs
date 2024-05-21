using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TestAddressFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Employee_EmployeeId",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Medicine_MedicineId",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Resident_ResidentId",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_CareCenter_Address_AddressId",
                table: "CareCenter");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnosis_Resident_ResidentId",
                table: "Diagnosis");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_CareCenter_CareCenterEmployeeId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Resident_ResidentId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Resident_CareCenter_CareCenterEmployeeId",
                table: "Resident");

            migrationBuilder.DropForeignKey(
                name: "FK_role_Employee_EmployeeId",
                table: "role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_role",
                table: "role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resident",
                table: "Resident");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescription",
                table: "Prescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diagnosis",
                table: "Diagnosis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CareCenter",
                table: "CareCenter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignment",
                table: "Assignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "Resident",
                newName: "Residents");

            migrationBuilder.RenameTable(
                name: "Prescription",
                newName: "Prescriptions");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Diagnosis",
                newName: "Diagnoses");

            migrationBuilder.RenameTable(
                name: "CareCenter",
                newName: "CareCenters");

            migrationBuilder.RenameTable(
                name: "Assignment",
                newName: "Assignments");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_role_EmployeeId",
                table: "Roles",
                newName: "IX_Roles_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Resident_CareCenterEmployeeId",
                table: "Residents",
                newName: "IX_Residents_CareCenterEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_ResidentId",
                table: "Prescriptions",
                newName: "IX_Prescriptions_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_CareCenterEmployeeId",
                table: "Employees",
                newName: "IX_Employees_CareCenterEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Diagnosis_ResidentId",
                table: "Diagnoses",
                newName: "IX_Diagnoses_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_CareCenter_AddressId",
                table: "CareCenters",
                newName: "IX_CareCenters_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_ResidentId",
                table: "Assignments",
                newName: "IX_Assignments_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_MedicineId",
                table: "Assignments",
                newName: "IX_Assignments_MedicineId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_EmployeeId",
                table: "Assignments",
                newName: "IX_Assignments_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Residents",
                table: "Residents",
                column: "ResidentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions",
                column: "PrescriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diagnoses",
                table: "Diagnoses",
                column: "DiagnosisId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CareCenters",
                table: "CareCenters",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments",
                column: "AssignmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Employees_EmployeeId",
                table: "Assignments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Medicine_MedicineId",
                table: "Assignments",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "MedicineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Residents_ResidentId",
                table: "Assignments",
                column: "ResidentId",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CareCenters_Addresses_AddressId",
                table: "CareCenters",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_Residents_ResidentId",
                table: "Diagnoses",
                column: "ResidentId",
                principalTable: "Residents",
                principalColumn: "ResidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_CareCenters_CareCenterEmployeeId",
                table: "Employees",
                column: "CareCenterEmployeeId",
                principalTable: "CareCenters",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Residents_ResidentId",
                table: "Prescriptions",
                column: "ResidentId",
                principalTable: "Residents",
                principalColumn: "ResidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_CareCenters_CareCenterEmployeeId",
                table: "Residents",
                column: "CareCenterEmployeeId",
                principalTable: "CareCenters",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Employees_EmployeeId",
                table: "Roles",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Employees_EmployeeId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Medicine_MedicineId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Residents_ResidentId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_CareCenters_Addresses_AddressId",
                table: "CareCenters");

            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_Residents_ResidentId",
                table: "Diagnoses");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_CareCenters_CareCenterEmployeeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Residents_ResidentId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_CareCenters_CareCenterEmployeeId",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Employees_EmployeeId",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Residents",
                table: "Residents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diagnoses",
                table: "Diagnoses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CareCenters",
                table: "CareCenters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "role");

            migrationBuilder.RenameTable(
                name: "Residents",
                newName: "Resident");

            migrationBuilder.RenameTable(
                name: "Prescriptions",
                newName: "Prescription");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Diagnoses",
                newName: "Diagnosis");

            migrationBuilder.RenameTable(
                name: "CareCenters",
                newName: "CareCenter");

            migrationBuilder.RenameTable(
                name: "Assignments",
                newName: "Assignment");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_EmployeeId",
                table: "role",
                newName: "IX_role_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Residents_CareCenterEmployeeId",
                table: "Resident",
                newName: "IX_Resident_CareCenterEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_ResidentId",
                table: "Prescription",
                newName: "IX_Prescription_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_CareCenterEmployeeId",
                table: "Employee",
                newName: "IX_Employee_CareCenterEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Diagnoses_ResidentId",
                table: "Diagnosis",
                newName: "IX_Diagnosis_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_CareCenters_AddressId",
                table: "CareCenter",
                newName: "IX_CareCenter_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_ResidentId",
                table: "Assignment",
                newName: "IX_Assignment_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_MedicineId",
                table: "Assignment",
                newName: "IX_Assignment_MedicineId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_EmployeeId",
                table: "Assignment",
                newName: "IX_Assignment_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_role",
                table: "role",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resident",
                table: "Resident",
                column: "ResidentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescription",
                table: "Prescription",
                column: "PrescriptionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diagnosis",
                table: "Diagnosis",
                column: "DiagnosisId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CareCenter",
                table: "CareCenter",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignment",
                table: "Assignment",
                column: "AssignmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Employee_EmployeeId",
                table: "Assignment",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Medicine_MedicineId",
                table: "Assignment",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "MedicineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Resident_ResidentId",
                table: "Assignment",
                column: "ResidentId",
                principalTable: "Resident",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CareCenter_Address_AddressId",
                table: "CareCenter",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnosis_Resident_ResidentId",
                table: "Diagnosis",
                column: "ResidentId",
                principalTable: "Resident",
                principalColumn: "ResidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_CareCenter_CareCenterEmployeeId",
                table: "Employee",
                column: "CareCenterEmployeeId",
                principalTable: "CareCenter",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Resident_ResidentId",
                table: "Prescription",
                column: "ResidentId",
                principalTable: "Resident",
                principalColumn: "ResidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Resident_CareCenter_CareCenterEmployeeId",
                table: "Resident",
                column: "CareCenterEmployeeId",
                principalTable: "CareCenter",
                principalColumn: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_role_Employee_EmployeeId",
                table: "role",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId");
        }
    }
}
