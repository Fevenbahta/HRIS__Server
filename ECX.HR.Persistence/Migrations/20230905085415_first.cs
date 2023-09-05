using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kebele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 828, DateTimeKind.Utc).AddTicks(8078)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 828, DateTimeKind.Utc).AddTicks(8608))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Allowance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowanceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Step = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<bool>(type: "bit", nullable: false),
                    RatePercent = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 828, DateTimeKind.Utc).AddTicks(8964)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 828, DateTimeKind.Utc).AddTicks(9275))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allowance", x => x.Id);
                });

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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(444)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(841))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignSupervisor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(1168)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(1541))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(1871)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(2177))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "DepositAutorizations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Bank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankAccount = table.Column<long>(type: "bigint", nullable: false),
                    TinNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(2559)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(2880))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositAutorizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EduactionLevel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(4039)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(4428))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EduactionLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmploeeStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(7437)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(7813))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploeeStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EcxId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBityh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceOfBith = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MartialStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salutation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PensionNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    crime = table.Column<bool>(type: "bit", nullable: false),
                    CrimeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(8135)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(8444))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmpId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePosition",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DivisionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StepId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(6784)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(7119))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePosition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequest",
                columns: table => new
                {
                    leaveRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    leaveTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApproveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaveStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkingDays = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SickStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SickEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(8839)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(9149))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequest", x => x.leaveRequestId);
                });

            migrationBuilder.CreateTable(
                name: "LeaveType",
                columns: table => new
                {
                    leaveTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maximum = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(9459)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(9837))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveType", x => x.leaveTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    LevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(159)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(527))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.LevelId);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationalProfile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    AltPhone = table.Column<int>(type: "int", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoBox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VatNumber = table.Column<int>(type: "int", nullable: false),
                    TinNumber = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(863)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(1168))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationalProfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalaryType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(3245)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(3626))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supervisor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SupervisorLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(5680)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(6002))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    DivisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(3193)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(3646))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.DivisionId);
                    table.ForeignKey(
                        name: "FK_Division_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnnualLeaveBalances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PreviousTwoYear = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PreviousYearAnnualBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalRemaining = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalRequest = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AnnualDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AnnualRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsExpired = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 828, DateTimeKind.Utc).AddTicks(9655)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(54))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnualLeaveBalances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnnualLeaveBalances_Employee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NameOfInstitute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FieldOfStudy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EductionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(4758)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(5138))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_Employee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyContact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kebele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(5587)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 829, DateTimeKind.Utc).AddTicks(6236))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmergencyContact_Employee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spouse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(3938)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(4313))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spouse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spouse_Employee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TypeOfTraining = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(6423)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(6902))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Training_Employee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperiences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostionHeld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    ReasonTermination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(7298)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(7750))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkExperiences_Employee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    SalaryTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(4813)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(5207))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Step_Level_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Level",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(2386)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(2855))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.PositionId);
                    table.ForeignKey(
                        name: "FK_Job_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "DivisionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtherLeaveBalance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SickDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SickRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaternityDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaternityRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaternityDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaternityRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompassinateDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompassinateRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EducationDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EducationRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarriageDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MarraiageRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LeaveWotPayDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LeaveWotPayRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CourtLeaveDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CourtLeaveRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AbortionLeaveDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AbortionLeaveRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SickEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SickStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsExpired = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    AnnualLeaveBalanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(1550)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 5, 8, 54, 14, 830, DateTimeKind.Utc).AddTicks(1971))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherLeaveBalance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtherLeaveBalance_AnnualLeaveBalances_AnnualLeaveBalanceId",
                        column: x => x.AnnualLeaveBalanceId,
                        principalTable: "AnnualLeaveBalances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OtherLeaveBalance_Employee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnnualLeaveBalances_EmpId",
                table: "AnnualLeaveBalances",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Division_DepartmentId",
                table: "Division",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_EmpId",
                table: "Education",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyContact_EmpId",
                table: "EmergencyContact",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_DivisionId",
                table: "Job",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherLeaveBalance_AnnualLeaveBalanceId",
                table: "OtherLeaveBalance",
                column: "AnnualLeaveBalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_OtherLeaveBalance_EmpId",
                table: "OtherLeaveBalance",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Spouse_EmpId",
                table: "Spouse",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Step_LevelId",
                table: "Step",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_EmpId",
                table: "Training",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_EmpId",
                table: "WorkExperiences",
                column: "EmpId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "Allowance");

            migrationBuilder.DropTable(
                name: "AssignSupervisor");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "DepositAutorizations");

            migrationBuilder.DropTable(
                name: "EduactionLevel");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "EmergencyContact");

            migrationBuilder.DropTable(
                name: "EmploeeStatus");

            migrationBuilder.DropTable(
                name: "EmployeePosition");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "LeaveRequest");

            migrationBuilder.DropTable(
                name: "LeaveType");

            migrationBuilder.DropTable(
                name: "OrganizationalProfile");

            migrationBuilder.DropTable(
                name: "OtherLeaveBalance");

            migrationBuilder.DropTable(
                name: "SalaryType");

            migrationBuilder.DropTable(
                name: "Spouse");

            migrationBuilder.DropTable(
                name: "Step");

            migrationBuilder.DropTable(
                name: "Supervisor");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "AnnualLeaveBalances");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
