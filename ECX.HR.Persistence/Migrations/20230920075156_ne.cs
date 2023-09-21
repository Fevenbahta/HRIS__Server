using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "date",
                table: "Holidays",
                newName: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(3522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 398, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(3047),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 398, DateTimeKind.Utc).AddTicks(71));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(2654),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(2197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(1808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(1032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(9861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(9469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(9019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(8702),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(8374),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(7144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(6739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(7924),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(7535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(6303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(5719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(4025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(3403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(3009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(2677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(2024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(1721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(1405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(1028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(5225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(4543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(9),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(9701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(7854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(7517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(9274),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(8966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(8642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(8259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(6994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(6378),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(5715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(5337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(5018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(4631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(4059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(3549),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(3163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(2837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(2380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(1641),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(1317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(9772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(9382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(8974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(8659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(8328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(7884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(7560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(7072),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(6667));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Holidays",
                newName: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 398, DateTimeKind.Utc).AddTicks(471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 398, DateTimeKind.Utc).AddTicks(71),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(9622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(2197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(8802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(8431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(7137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 670, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(6760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(6327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(5272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(3711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4893),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(4453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(3348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(1672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(1276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(2024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(9252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8859),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 397, DateTimeKind.Utc).AddTicks(2157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(4543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(8024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 669, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(7011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(6632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(6334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(5247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(4038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(3643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(3330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2507),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(2196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(1198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(1641));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 396, DateTimeKind.Utc).AddTicks(135),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(9814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 668, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(9431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(8269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(7061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 50, 53, 395, DateTimeKind.Utc).AddTicks(6667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 51, 55, 667, DateTimeKind.Utc).AddTicks(7072));
        }
    }
}
