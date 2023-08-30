using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class annualyear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompassinateDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "CompassinateRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "CourtLeaveDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "CourtLeaveRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "CurrentYear",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "EducationDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "EducationRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "LeaveWotPayDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "LeaveWotPayRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "MarraiageRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "MarriageDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "MaternityDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "MaternityRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "PaternityDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "SickEndDate",
                table: "LeaveBalance");

            migrationBuilder.RenameColumn(
                name: "SickRemainingBalance",
                table: "LeaveBalance",
                newName: "TotalRequest");

            migrationBuilder.RenameColumn(
                name: "SickDefaultBalance",
                table: "LeaveBalance",
                newName: "TotalRemaining");

            migrationBuilder.RenameColumn(
                name: "PaternityRemainingBalance",
                table: "LeaveBalance",
                newName: "PreviousTwoYear");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(9949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(9486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(9137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(8781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(8396),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(8104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(7612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(7259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(6902),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(6459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(6164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(5770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(4673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(4389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(4072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(3669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(3368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(2978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(2697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(2408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(4269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(3909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(5422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(5070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(745),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(2028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(1736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(1425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(1035),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(9996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(9652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(9195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(8855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(8557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(8153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(7806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(7330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(7040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(6743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(6297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(6007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(5695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(5315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(5016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(4615),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(3499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(3206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(2882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(2439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(4333));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalRequest",
                table: "LeaveBalance",
                newName: "SickRemainingBalance");

            migrationBuilder.RenameColumn(
                name: "TotalRemaining",
                table: "LeaveBalance",
                newName: "SickDefaultBalance");

            migrationBuilder.RenameColumn(
                name: "PreviousTwoYear",
                table: "LeaveBalance",
                newName: "PaternityRemainingBalance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(3537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(3155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(2713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(9137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(2327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(6823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(6512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(5009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(2697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.AddColumn<decimal>(
                name: "CompassinateDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CompassinateRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CourtLeaveDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CourtLeaveRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "CurrentYear",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "EducationDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "EducationRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaveWotPayDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaveWotPayRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MarraiageRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MarriageDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MaternityDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MaternityRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PaternityDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "SickEndDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(1612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(1425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 571, DateTimeKind.Utc).AddTicks(1035));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(1185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(9706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(9398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(5315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(3499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(4852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(4333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 30, 11, 47, 45, 570, DateTimeKind.Utc).AddTicks(2439));
        }
    }
}
