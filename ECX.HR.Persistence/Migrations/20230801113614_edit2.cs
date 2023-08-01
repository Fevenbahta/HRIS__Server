using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class edit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(5681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(5258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(3751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(3055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(2631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(2243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(1935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(1488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(5781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(5284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(4748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(4349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(3819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(3720));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(7620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(7206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(6758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(6295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(1617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(1313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(8635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(8322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(5284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(4791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(4457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(3720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(3819));
        }
    }
}
