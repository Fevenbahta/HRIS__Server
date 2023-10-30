using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class gg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(7245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 687, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(6786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "WorkExperiences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(6385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(5925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(5524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(5126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(4736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(4401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(3929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(3533),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(3111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(2650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(2321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(1894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(5012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(1493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(1098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(9963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(3125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(9487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "PromotionRelations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(8201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(1451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(7712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.AddColumn<decimal>(
                name: "OtherLeaveRemainingBalance",
                table: "OtherLeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(7392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(7068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(6675),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(6357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(6013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(5595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(5272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(4946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(9086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(2225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(8629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(4560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(4246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(2422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(2092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(5345));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(3855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(3520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(3154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(6478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(2747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(1581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(1182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Education",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(9985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(9590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(9198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(8742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(8422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(8097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(7663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(7294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(6963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(6567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Attendances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(6246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Attendances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(5915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.AddColumn<decimal>(
                name: "TotalLE",
                table: "Attendances",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(5516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(5182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(4717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(4318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(3991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(7432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(3596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(3251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(2916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(2516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(2100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(5799));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "File",
                table: "PromotionRelations");

            migrationBuilder.DropColumn(
                name: "OtherLeaveRemainingBalance",
                table: "OtherLeaveBalance");

            migrationBuilder.DropColumn(
                name: "File",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "TotalLE",
                table: "Attendances");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 687, DateTimeKind.Utc).AddTicks(18),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(7245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(9649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(9197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(8829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(8442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(5524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(7947),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(7641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(6887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(6510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(6063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(3111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(5693),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(5382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(2321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(5012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(3872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(3564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(4628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(4184),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 240, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(3125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(2754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(1451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(9848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(9560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(9193),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(8907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(8521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(8158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(2225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 686, DateTimeKind.Utc).AddTicks(1862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(7769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(7475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(5713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(5345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(7130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(6833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(6478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(6106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(2747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(4973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(4595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(4167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(3708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 239, DateTimeKind.Utc).AddTicks(322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(3261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(2881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(2482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(1945),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(1648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(8422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(1295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(1004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(355),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 685, DateTimeKind.Utc).AddTicks(69),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Attendances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(9770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Attendances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(9324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(5915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(8928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(8624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(8183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(4717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(7790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(7432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(7141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(3596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(6837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(6482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(6181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 23, 10, 5, 47, 684, DateTimeKind.Utc).AddTicks(5799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 30, 7, 42, 48, 238, DateTimeKind.Utc).AddTicks(2100));
        }
    }
}
