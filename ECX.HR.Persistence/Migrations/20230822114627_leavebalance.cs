using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class leavebalance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExpired",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "LeaveTypeId",
                table: "LeaveBalance");

            migrationBuilder.RenameColumn(
                name: "RemainingBalance",
                table: "LeaveBalance",
                newName: "SickRemainingBalance");

            migrationBuilder.RenameColumn(
                name: "DefaultBalance",
                table: "LeaveBalance",
                newName: "SickDefaultBalance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(9265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(8884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(8548),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(8218),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(7809),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(7528),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(7122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(6707),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(6270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(5681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(5381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(4968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(3922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(3657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(3370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(3057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(2783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(2424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(2155),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(7264));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(1880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(1489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(1167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.AddColumn<decimal>(
                name: "AnnualDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AnnualRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CompassinateDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CompassinateRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CourtLeaveDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CourtLeaveRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "CurrentYear",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "EducationDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "EducationRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaveWotPayDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LeaveWotPayRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MarraiageRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MarriageDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MaternityDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MaternityRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PaternityDefaultBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PaternityRemainingBalance",
                table: "LeaveBalance",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(4637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(4304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(9689),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(9416),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(9959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(9025),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(8694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(8299),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(7978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(7704),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(2252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(7372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(7037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(6697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(1078));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(6371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(6097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(5699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(5417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(5137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(4810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(4538),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(4269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(3939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(3669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(3372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(2958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(7077));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnnualDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "AnnualRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "CompassinateDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "CompassinateRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "CourtLeaveDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "CourtLeaveRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "CurrentYear",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "EducationDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "EducationRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "LeaveWotPayDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "LeaveWotPayRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "MarraiageRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "MarriageDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "MaternityDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "MaternityRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "PaternityDefaultBalance",
                table: "LeaveBalance");

            migrationBuilder.DropColumn(
                name: "PaternityRemainingBalance",
                table: "LeaveBalance");

            migrationBuilder.RenameColumn(
                name: "SickRemainingBalance",
                table: "LeaveBalance",
                newName: "RemainingBalance");

            migrationBuilder.RenameColumn(
                name: "SickDefaultBalance",
                table: "LeaveBalance",
                newName: "DefaultBalance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(4458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(4040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(3672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(3247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(2946),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(7809));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(2632),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(2188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(1821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(1386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(1021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 405, DateTimeKind.Utc).AddTicks(323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(9214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(8910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(8540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(8244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(7932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(7574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(7264),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(6903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(6536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(6171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.AddColumn<int>(
                name: "IsExpired",
                table: "LeaveBalance",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "LeaveTypeId",
                table: "LeaveBalance",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(9950),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(9519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(4525),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(4161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(5799),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(5499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(5181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 941, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(4829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(9959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(3792),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(3422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(2951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(2586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(2252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(1889),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(1512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(1078),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(781),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 404, DateTimeKind.Utc).AddTicks(102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(5699));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(9803),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(9484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(9128),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(8817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(8448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(8149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(7841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(7460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 22, 7, 28, 43, 403, DateTimeKind.Utc).AddTicks(7077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 22, 11, 46, 26, 940, DateTimeKind.Utc).AddTicks(2958));
        }
    }
}
