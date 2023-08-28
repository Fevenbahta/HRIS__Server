using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class leaverequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(8776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(8449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(8016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(7645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(7372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(7048),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(6728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2316));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(6412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(6029),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1578));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(5712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(5390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(5124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(4117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(3847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(3527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(3267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(2943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(2685),
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
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(2411),
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
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(2085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.AddColumn<string>(
                name: "LeaveType",
                table: "LeaveRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(1764),
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
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(1439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(4793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(190));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(4382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(9993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(9669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(1117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(9348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(9020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(8613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(8277),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(7896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(7631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(7304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(6924),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(6656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(6337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(6064),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(5797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(5475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(5211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(4932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(4610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(4337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(4058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(3713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(3353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8248));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeaveType",
                table: "LeaveRequest");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(4354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(4018),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(3284),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(2316),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1578),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(1145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(4117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9238),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(8082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(2685));

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
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(2411));

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
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(7044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(1764));

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
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 683, DateTimeKind.Utc).AddTicks(190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(9857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4649),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(6382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(6022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(5747),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(5471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 276, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(4302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(3156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2614),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(7631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1559),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1297),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(1020),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 682, DateTimeKind.Utc).AddTicks(156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(4932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(9271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 23, 8, 12, 53, 681, DateTimeKind.Utc).AddTicks(8248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 25, 8, 13, 18, 275, DateTimeKind.Utc).AddTicks(3353));
        }
    }
}
