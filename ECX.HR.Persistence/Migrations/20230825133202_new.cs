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
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(3662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(3197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(2810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(2414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(1933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(1521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(63),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(9605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(9290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(8888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(7650),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(7323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(6847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(6469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(6146),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(5750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.AlterColumn<Guid>(
                name: "leaveTypeId",
                table: "LeaveRequest",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(5432),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.AlterColumn<Guid>(
                name: "EmpId",
                table: "LeaveRequest",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(5106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(4637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.AlterColumn<Guid>(
                name: "EmpId",
                table: "LeaveBalance",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(4245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.AddColumn<decimal>(
                name: "PreviousYearAnnualBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(8496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(8097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(2481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(2149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(3916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(3529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(3197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(2802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(1672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(1280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(853),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(9511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(8969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(8442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(7924),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(7515),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(7042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(6638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(6310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(5977),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(5586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(5265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(4936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(4542),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(4222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(3876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(3384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8248));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreviousYearAnnualBalance",
                table: "LeaveBalance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(4354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(4018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(2810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(3284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 14, DateTimeKind.Utc).AddTicks(63));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(6469));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.AlterColumn<Guid>(
                name: "leaveTypeId",
                table: "LeaveRequest",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(7742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.AlterColumn<Guid>(
                name: "EmpId",
                table: "LeaveRequest",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(7468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(7044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.AlterColumn<Guid>(
                name: "EmpId",
                table: "LeaveBalance",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(6658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(2149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(6382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(6022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(5747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(5471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 13, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(5265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 13, 32, 2, 12, DateTimeKind.Utc).AddTicks(3384));
        }
    }
}
