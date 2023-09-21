using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(7697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(7304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(6888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(6332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(3526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(3144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(1166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(2548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(2195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(1561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(9891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(1284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(8389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6470),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(9422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(8841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3974),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(1751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(1326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(2583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(1584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(9693),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(9319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8086),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(7792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(5595),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(5182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(4748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(4287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(2801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(2229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(4382)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(4696))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(9495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(9080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(8560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(8147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(7704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(7173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(6819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(6342),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(5937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(5511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(5007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(4597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(4161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(3822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(2548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(2195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(3397),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(2039));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(2887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(1699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 651, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(1284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(9714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(9168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(8808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(8313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(7960),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(7599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(7147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(6788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(6357),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(5928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 100, DateTimeKind.Utc).AddTicks(219),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(3941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(3578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(5569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(5122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(4762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(4401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(3115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(2583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(2126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(1584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 650, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(1226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 99, DateTimeKind.Utc).AddTicks(300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(9843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(9314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(8972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(8596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(8145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(7792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(7418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(6958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(6532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(6053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(5531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(5171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(4723),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(4371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(3994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(3523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 13, 20, 18, 98, DateTimeKind.Utc).AddTicks(3054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 7, 43, 57, 649, DateTimeKind.Utc).AddTicks(2229));
        }
    }
}
