using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(4514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(4080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(3571),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(3145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(2706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(2196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(1816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(1381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(6235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(948),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(494),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(9934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(9500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(9068),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(8715),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(7411),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(7043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(8279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(7767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(6529),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(6059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(4527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(3962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(3611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(3189),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(2835),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(2483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(2059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(1709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(1329),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(5440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(5007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(9552));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(71),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(7874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(2527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(7437),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(9450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(9015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(8579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(8236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(6989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(6471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(6009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(5439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(5001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(4631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(4168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(3645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(3267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(2628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(2236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(1873),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(1367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(1005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(92),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(9569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(8779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(8388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(7989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(7520),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(2149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(7112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(6640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(5596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(721));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(9389),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(8949),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(8499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(3571));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(7989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(7539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(7003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(6616),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(6235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(5685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(948));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(5226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 260, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(4647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(4206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(9500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(3833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(3363),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(2005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(1635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(2908),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(2381),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(1106),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(6059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(9049),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(4527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(8449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(8084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(7703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(7260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(6900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(6457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(6104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(5733),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(1329));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(5295),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 580, DateTimeKind.Utc).AddTicks(166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(9552),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(4934),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(4573),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 259, DateTimeKind.Utc).AddTicks(71));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(2527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(2075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(4111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(3729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(3341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(2903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(1625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(1163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 579, DateTimeKind.Utc).AddTicks(110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(5439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(9581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(9192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(8712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(7734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(7293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(6866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(6417),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(6045),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(1873));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(5599),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(5240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(4859),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(4410),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 258, DateTimeKind.Utc).AddTicks(92));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(3953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(3464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(3015),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(8388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(2637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(2149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(1764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(1335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 20, 13, 23, 41, 578, DateTimeKind.Utc).AddTicks(721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 20, 13, 26, 4, 257, DateTimeKind.Utc).AddTicks(5596));
        }
    }
}
