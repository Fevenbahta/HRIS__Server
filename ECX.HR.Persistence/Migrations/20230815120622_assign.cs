﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class assign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 616, DateTimeKind.Utc).AddTicks(1823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 616, DateTimeKind.Utc).AddTicks(1421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 616, DateTimeKind.Utc).AddTicks(930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 616, DateTimeKind.Utc).AddTicks(124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(9787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(9339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(8756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(8190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(7705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(7307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(6910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(6594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(5387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(4956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(4638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(4319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(6181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(5708),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(2432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(2102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(3921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(3597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(3265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(2848),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(1623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(1225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(356),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(32),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(9638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(9233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(8751),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(8436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(8113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(7707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(7390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(7051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(6609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(5570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3443));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(5242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(4820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(4393),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.CreateTable(
                name: "AssignSupervisor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FirstSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FourthSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FifthSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(5883)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(6271))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignSupervisor", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignSupervisor");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(7436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 616, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 616, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 616, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(6064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 616, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(5045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(4698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(4331),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3608),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(3240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(5387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(1179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(4319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(2517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(2102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 956, DateTimeKind.Utc).AddTicks(159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(9857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(8742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(8234),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(356));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(7083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 615, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(6753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(9638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(6239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(5182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4881),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(4166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(2821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 15, 7, 16, 28, 955, DateTimeKind.Utc).AddTicks(2310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 15, 12, 6, 22, 614, DateTimeKind.Utc).AddTicks(4393));
        }
    }
}
