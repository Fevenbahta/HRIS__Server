using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class @long : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(3045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(2670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(2220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(1491));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(9175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(4667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(4291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(2666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(2359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(3459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(3138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.AlterColumn<long>(
                name: "BankAccount",
                table: "DepositAutorizations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(2289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(8756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(7941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(161));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(4670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(4278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(3962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(3644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(3317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(3051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(2653),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(2335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(2003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(1491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(1217),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(9435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(9175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(8812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(8493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 508, DateTimeKind.Utc).AddTicks(387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(9757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(6938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(6676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(8222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(7945),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(7532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(7273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(6347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(5952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(5503),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(4446),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(4171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(3900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(2359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(3459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(3138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(2872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(2559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.AlterColumn<int>(
                name: "BankAccount",
                table: "DepositAutorizations",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(2289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(1963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(1701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(1438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(1110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 3, 11, 34, 56, 507, DateTimeKind.Utc).AddTicks(161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(7941));
        }
    }
}
