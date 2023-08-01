using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(7620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 169, DateTimeKind.Utc).AddTicks(433));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(7206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 169, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(6758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(6295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(2845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4096),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(9975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2317),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(1617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(1313),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(3478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(2221));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(8635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(8322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5811),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(4791),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(4457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(3720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(6063));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 169, DateTimeKind.Utc).AddTicks(433),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 169, DateTimeKind.Utc).AddTicks(25),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(9377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(8062),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(6965),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(2845),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(1973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(1301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 168, DateTimeKind.Utc).AddTicks(303),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(9975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(9613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(6021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(5419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(7270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(6442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(5101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(4706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(1313));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(4387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(4057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(3478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 656, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(3085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(2679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(2221),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(1891),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(1480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(8322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(1077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(646),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 167, DateTimeKind.Utc).AddTicks(241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(9922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(9496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(9182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(8851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(8448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(8116),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(7691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(7147),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 8, 6, 17, 166, DateTimeKind.Utc).AddTicks(6063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 1, 11, 14, 19, 655, DateTimeKind.Utc).AddTicks(3720));
        }
    }
}
