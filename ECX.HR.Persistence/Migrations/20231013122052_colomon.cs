using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class colomon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(9497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(9107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(8731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(8347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7274),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(2377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5158),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3729),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4047),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(2673),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(5276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(497),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(177),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9572),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(2298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8333),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8041),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "File",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "File",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6493),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6196),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4778),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2711),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1537),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1253),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(379),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(2101));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9639),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(1634));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8764),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 195, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(7746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 195, DateTimeKind.Utc).AddTicks(9368));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(4942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(9497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(4481),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(4024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(3628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(3177),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Terminations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(2785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(2377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(2059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(1664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(1200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 198, DateTimeKind.Utc).AddTicks(233),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(9927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(9609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(8204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionVacancys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(7896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(9159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Promotions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(8690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(7521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PromotionRelations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(7057),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(5769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OtherLeaveBalance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(5276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(4882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "OrganizationalProfile",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(4569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(4232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(177));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(3846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(3530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(3145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(2841),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "LeaveRequest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(2439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(6618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(6161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 813, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(2012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Holidays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(1717),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "File",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(1409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "File",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(938),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(9187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmployeePosition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(8865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 197, DateTimeKind.Utc).AddTicks(210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(9897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(9584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(6196));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(8472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(8013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(7624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(7153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(6816),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(6358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(5901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(5532),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(5130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(4746),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(4336),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(3911),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(3611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(3310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(2824),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssignSupervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(2502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 812, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(2101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AnnualLeaveBalances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(1634),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(1319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(9054));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8764));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 196, DateTimeKind.Utc).AddTicks(285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 195, DateTimeKind.Utc).AddTicks(9775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ActingAssiment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 13, 12, 19, 0, 195, DateTimeKind.Utc).AddTicks(9368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 13, 12, 20, 51, 811, DateTimeKind.Utc).AddTicks(7746));
        }
    }
}
