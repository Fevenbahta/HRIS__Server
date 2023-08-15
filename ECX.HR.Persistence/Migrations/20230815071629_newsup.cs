using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class newsup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstSupervisor",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SecondSupervisor",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "Supervisor",
                newName: "PositionId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(7436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(4698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(4331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.AddColumn<string>(
                name: "FifthSupervisor",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstSupervisor",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FourthSupervisor",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondSupervisor",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdSupervisor",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(8742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(8234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(6753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(2359));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(6239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(2821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(2310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(7941));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FifthSupervisor",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "FirstSupervisor",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "FourthSupervisor",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "SecondSupervisor",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "ThirdSupervisor",
                table: "Job");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "Supervisor",
                newName: "EmpId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(3045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(2670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(2220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(1168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 110, DateTimeKind.Utc).AddTicks(346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(9230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(7028),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(8017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(4667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6361),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(6050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.AddColumn<string>(
                name: "FirstSupervisor",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondSupervisor",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5665),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(5368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(4291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3413),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(3046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(2666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(2359),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(1189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 109, DateTimeKind.Utc).AddTicks(133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(9120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(8756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(8432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 7, 15, 3, 52, 108, DateTimeKind.Utc).AddTicks(7941),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(2310));
        }
    }
}
