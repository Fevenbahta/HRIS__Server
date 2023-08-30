using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class leaveBalance8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(2226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(1788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(1376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(1046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(434),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(44),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(9718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(9385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(9004),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(8742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(8409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(7418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(7154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(6875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(6546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(6273),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(5944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(5670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(5391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4705));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(4948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(4614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(8074),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(7746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(3134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(2824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(4333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(4013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(3734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(3409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(2431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(2111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(1774),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(1297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(1016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(676),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(338),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(9988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(9658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(9385),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(9040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(8772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(8109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(7833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(7559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(7212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(6913),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(6614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(6182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(4333));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(3537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(2226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(3155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(2713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(2327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(1187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 321, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 402, DateTimeKind.Utc).AddTicks(334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9601),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(9292),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(7121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(6823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(6512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(5009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4705),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(4948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8840),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(8466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(3134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(1612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(3209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(2596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(1185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 401, DateTimeKind.Utc).AddTicks(4),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(9706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(9398),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(676));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 320, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(8218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(7253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(6283),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5516),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(5183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(4852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 28, 7, 34, 17, 400, DateTimeKind.Utc).AddTicks(4333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 28, 8, 50, 15, 319, DateTimeKind.Utc).AddTicks(6182));
        }
    }
}
