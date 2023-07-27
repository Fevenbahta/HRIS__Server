using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class delete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Division_Departments_DepartmentId",
                table: "Division");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_Employee_EmpId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_EmergencyContact_Employee_EmpId",
                table: "EmergencyContact");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Division_DivisionId",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Spouse_Employee_EmpId",
                table: "Spouse");

            migrationBuilder.DropForeignKey(
                name: "FK_Step_Level_LevelId",
                table: "Step");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Employee_EmpId",
                table: "Training");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(3482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(3095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(2630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(2249),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(1925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(1506),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(1109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(691),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(1157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(9812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(9399),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(9079),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(7860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(7474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(8666),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(8185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(7154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(6830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(6428),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(6105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(5694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(5226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(4624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(4141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(3830),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(3512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(3034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(2625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(3527));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(2192),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(1875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(1547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(1152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(111),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 261, DateTimeKind.Utc).AddTicks(9789),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 261, DateTimeKind.Utc).AddTicks(9429),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 261, DateTimeKind.Utc).AddTicks(8802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 765, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.AddForeignKey(
                name: "FK_Division_Departments_DepartmentId",
                table: "Division",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Employee_EmpId",
                table: "Education",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmergencyContact_Employee_EmpId",
                table: "EmergencyContact",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Division_DivisionId",
                table: "Job",
                column: "DivisionId",
                principalTable: "Division",
                principalColumn: "DivisionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Spouse_Employee_EmpId",
                table: "Spouse",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Step_Level_LevelId",
                table: "Step",
                column: "LevelId",
                principalTable: "Level",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Employee_EmpId",
                table: "Training",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Division_Departments_DepartmentId",
                table: "Division");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_Employee_EmpId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_EmergencyContact_Employee_EmpId",
                table: "EmergencyContact");

            migrationBuilder.DropForeignKey(
                name: "FK_Job_Division_DivisionId",
                table: "Job");

            migrationBuilder.DropForeignKey(
                name: "FK_Spouse_Employee_EmpId",
                table: "Spouse");

            migrationBuilder.DropForeignKey(
                name: "FK_Step_Level_LevelId",
                table: "Step");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Employee_EmpId",
                table: "Training");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(4294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(3921),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(3475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Training",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(3109),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(2798),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Supervisor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(2414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(2036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Step",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(1546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(1157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 263, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Spouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SalaryType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 767, DateTimeKind.Utc).AddTicks(105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(8929),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Level",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(8266),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(9712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Job",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(9268),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(7964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Employee",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(7657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(6969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmploeeStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(6662),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(6271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EmergencyContact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(5831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(5445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Education",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(4999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(4695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EduactionLevel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(4377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(3920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Division",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(3527),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(3103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(2192));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DepositAutorizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(2802),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(2483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(2108),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(1800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(1487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(1104),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 262, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Allowance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 261, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 766, DateTimeKind.Utc).AddTicks(457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 261, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Adress",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 26, 7, 42, 12, 765, DateTimeKind.Utc).AddTicks(9922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 27, 6, 40, 39, 261, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.AddForeignKey(
                name: "FK_Division_Departments_DepartmentId",
                table: "Division",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Employee_EmpId",
                table: "Education",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmergencyContact_Employee_EmpId",
                table: "EmergencyContact",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Division_DivisionId",
                table: "Job",
                column: "DivisionId",
                principalTable: "Division",
                principalColumn: "DivisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Spouse_Employee_EmpId",
                table: "Spouse",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "EmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_Step_Level_LevelId",
                table: "Step",
                column: "LevelId",
                principalTable: "Level",
                principalColumn: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Employee_EmpId",
                table: "Training",
                column: "EmpId",
                principalTable: "Employee",
                principalColumn: "EmpId");
        }
    }
}
