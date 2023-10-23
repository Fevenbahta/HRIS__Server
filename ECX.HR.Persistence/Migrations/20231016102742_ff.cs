using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(2596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(9497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(2169),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(1811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(1447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(992),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(268),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(9974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(9609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(9158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(8799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(8336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(8046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(7751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(6581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(6289),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(7299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(6947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(5928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(5504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(4331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(3935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(3540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(3251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(2947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(2599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(2302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(1950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(1661),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(1370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.AddColumn<Guid>(
                name: "departmentId",
                table: "LeaveRequest",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(5145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(4710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(1010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(730),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "File",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "File",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(74),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(8461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(8165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(9784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(9483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(9122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(8827),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(7802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(7373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(7011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(6543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(6256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(5957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(5523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(5174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(4878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(4531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(4230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(3879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(3590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(3295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(2926),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(2627),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(2264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(1843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(1547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(1185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 236, DateTimeKind.Utc).AddTicks(9819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(7746));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "LeaveRequest");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(9497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(9107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(2169));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(8731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(8347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7274),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 239, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4047),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(2673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(177),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(2599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(2298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "File",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "File",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 238, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(4878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(4531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(2264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(1843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 237, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(7746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 16, 10, 27, 41, 236, DateTimeKind.Utc).AddTicks(9819));
        }
    }
}
