using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class n : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 398, DateTimeKind.Utc).AddTicks(471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 398, DateTimeKind.Utc).AddTicks(71),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(9622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(8802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(8431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(6760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(6327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(3711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(3348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(1672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(1276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8859),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(6632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(6334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(3643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(3330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(9814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(9431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(6667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(2229));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "Holidays");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(7697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 398, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(7304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 398, DateTimeKind.Utc).AddTicks(71));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(6888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(6332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(3526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(3144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(1166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(1561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(9891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(8389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(9422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(8841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(4696),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(4382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(1751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(1326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(9693),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(5595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(5182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(4748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(4287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(2801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(2229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(6667));
        }
    }
}
