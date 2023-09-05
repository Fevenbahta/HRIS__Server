using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class leaverequest3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileData",
                table: "LeaveRequest");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(9785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(9337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(8916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(8477),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(8106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(7809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(1940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(7441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(6753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(6376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(5835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(5544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(9755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(5242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(3169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(2385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(1810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(1339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(5257));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(9920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(9600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(4254));

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "LeaveRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(4709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(4151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(5886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(4350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(8946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(8545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(8159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(6425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(3940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(3408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(1730),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(1227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(9226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(9928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(9593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(9322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(9039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(7834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(8702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(8421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(8130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(7747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(7466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(7055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(6710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(5264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(6432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(6087),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(5798),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(5422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(3839));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "LeaveRequest");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(3847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(3464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(3007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(2634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(2318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(1940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(7809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(1550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(987),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(6376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 768, DateTimeKind.Utc).AddTicks(132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(9755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(9441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(7935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(6997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(2385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(6683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(6360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(1339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(5981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(5674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(5257),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(4952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(4630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(4254),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.AddColumn<byte[]>(
                name: "FileData",
                table: "LeaveRequest",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(9036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(8575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 842, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(2562),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(2186),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(3943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(3620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(3196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(2888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(6425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(1787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(1326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 767, DateTimeKind.Utc).AddTicks(12),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(9692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(9226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 841, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(8839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(8522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(8149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(9322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(7834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(7519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(7141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(6829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(6443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(6125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(5726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(5264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(4953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(4629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(4235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 2, 13, 29, 22, 766, DateTimeKind.Utc).AddTicks(3839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 2, 13, 37, 13, 840, DateTimeKind.Utc).AddTicks(5422));
        }
    }
}
