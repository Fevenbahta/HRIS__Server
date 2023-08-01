using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class edit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(2303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(1888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(1534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(1179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(523),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(9750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(9392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(8976),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(8673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(8368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(7236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(6948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(7959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(7596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(6647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(6269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(5964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(5639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(5180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(4814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(4386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(4027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(3719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(3371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(3005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(2536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(2236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(1935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(1568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(1272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(5284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 447, DateTimeKind.Utc).AddTicks(9862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 447, DateTimeKind.Utc).AddTicks(9546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.AlterColumn<int>(
                name: "PId",
                table: "Adress",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 447, DateTimeKind.Utc).AddTicks(8938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(3819));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2510),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(2079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(1008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(652),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 449, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 195, DateTimeKind.Utc).AddTicks(229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(9159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8872),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(8055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(7596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(7059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6394),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(6095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(5681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(5258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(4126),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(3751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(3055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(2631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(2536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(2243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(1935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(1488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 194, DateTimeKind.Utc).AddTicks(867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(5781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(5284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 448, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(4748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 447, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(4349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 447, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.AlterColumn<int>(
                name: "PId",
                table: "Adress",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 36, 14, 193, DateTimeKind.Utc).AddTicks(3819),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 13, 1, 24, 447, DateTimeKind.Utc).AddTicks(8938));
        }
    }
}
