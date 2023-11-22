using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECX.HR.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class hh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActingAssiment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequesterEmp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssignedEmp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Postion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstSupervisorStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondSupervisorStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdSupervisorStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(4887)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(5402))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActingAssiment", x => x.Id);
                });

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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(5768)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(6120))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(6540)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(6893))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(8175)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(8597))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignSupervisor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceId = table.Column<int>(type: "int", nullable: true),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeTable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OnDuty = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OffDuty = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClockIn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClockOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Normall = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RealTime = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Late = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Early = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    AttendanceStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbsentDays = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalLE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(8961)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(9305))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(9760)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(112))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckInOuts",
                columns: table => new
                {
                    USERID = table.Column<int>(type: "int", nullable: false),
                    CHECKTIME = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CHECKTYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VERIFYCODE = table.Column<int>(type: "int", nullable: true),
                    SENSORID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Memoinfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserExtFmt = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(535)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(962))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(1365)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(1791))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(3069)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(3426))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(6421)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(6780))
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
                    AttendanceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(7231)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(7587))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(5652)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(6059))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePosition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(7936)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(8374))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
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
                    Supervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkingDays = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SickStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SickEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    departmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    employeePositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(8733)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(9076))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(9549)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(9895))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(308)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(660))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.LevelId);
                });

            migrationBuilder.CreateTable(
                name: "NumOfRun",
                columns: table => new
                {
                    STARTDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NUM_RUNID = table.Column<int>(type: "int", nullable: false),
                    OLDID = table.Column<int>(type: "int", nullable: false),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CYLE = table.Column<short>(type: "smallint", nullable: false),
                    UNITS = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumOfRun", x => x.STARTDATE);
                });

            migrationBuilder.CreateTable(
                name: "NumRunDels",
                columns: table => new
                {
                    NUM_RUNID = table.Column<short>(type: "smallint", nullable: false),
                    STARTTIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ENDTIME = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SDAYS = table.Column<short>(type: "smallint", nullable: false),
                    EDAYS = table.Column<short>(type: "smallint", nullable: false),
                    SCHCLASSID = table.Column<int>(type: "int", nullable: false),
                    OverTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(1031)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(1997))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationalProfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromotionVacancys",
                columns: table => new
                {
                    VacancyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Requirement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(6710)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(7104))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionVacancys", x => x.VacancyId);
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(9064)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(9639))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "schClasses",
                columns: table => new
                {
                    schClassid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    schName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LateMinutes = table.Column<int>(type: "int", nullable: false),
                    EarlyMinutes = table.Column<int>(type: "int", nullable: false),
                    CheckIn = table.Column<int>(type: "int", nullable: false),
                    CheckOut = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    AutoBind = table.Column<short>(type: "smallint", nullable: false),
                    CheckInTime1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckInTime2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutTime1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutTime2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkDay = table.Column<double>(type: "float", nullable: false),
                    SensorID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkMins = table.Column<double>(type: "float", nullable: false),
                    upsize_ts = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schClasses", x => x.schClassid);
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(1843)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(2212))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userInformation",
                columns: table => new
                {
                    USERID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Badgenumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TITLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAGER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIRTHDAY = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HIREDDAY = table.Column<DateTime>(type: "datetime2", nullable: true),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CITY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STATE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OPHONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FPHONE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VERIFICATIONMETHOD = table.Column<short>(type: "smallint", nullable: true),
                    DEFAULTDEPTID = table.Column<short>(type: "smallint", nullable: true),
                    SECURITYFLAGS = table.Column<short>(type: "smallint", nullable: true),
                    ATT = table.Column<short>(type: "smallint", nullable: true),
                    INLATE = table.Column<short>(type: "smallint", nullable: true),
                    OUTEARLY = table.Column<short>(type: "smallint", nullable: true),
                    OVERTIME = table.Column<short>(type: "smallint", nullable: true),
                    SEP = table.Column<short>(type: "smallint", nullable: true),
                    HOLIDAY = table.Column<short>(type: "smallint", nullable: true),
                    MINZU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LUNCHDURATION = table.Column<short>(type: "smallint", nullable: true),
                    PHOTO = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    mverifypass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    privilege = table.Column<int>(type: "int", nullable: true),
                    InheritDeptSch = table.Column<short>(type: "smallint", nullable: true),
                    InheritDeptSchClass = table.Column<short>(type: "smallint", nullable: true),
                    AutoSchPlan = table.Column<short>(type: "smallint", nullable: true),
                    MinAutoSchInterval = table.Column<int>(type: "int", nullable: true),
                    RegisterOT = table.Column<short>(type: "smallint", nullable: true),
                    InheritDeptRule = table.Column<short>(type: "smallint", nullable: true),
                    EMPRIVILEGE = table.Column<short>(type: "smallint", nullable: true),
                    CardNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaceGroup = table.Column<int>(type: "int", nullable: true),
                    AccGroup = table.Column<int>(type: "int", nullable: true),
                    UseAccGroupTZ = table.Column<int>(type: "int", nullable: true),
                    VerifyCode = table.Column<int>(type: "int", nullable: true),
                    Expires = table.Column<int>(type: "int", nullable: true),
                    ValidCount = table.Column<int>(type: "int", nullable: true),
                    ValidTimeBegin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValidTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TimeZone1 = table.Column<int>(type: "int", nullable: true),
                    TimeZone2 = table.Column<int>(type: "int", nullable: true),
                    TimeZone3 = table.Column<int>(type: "int", nullable: true),
                    upsize_ts = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userInformation", x => x.USERID);
                });

            migrationBuilder.CreateTable(
                name: "UserOfNums",
                columns: table => new
                {
                    USERID = table.Column<int>(type: "int", nullable: false),
                    NUM_OF_RUN_ID = table.Column<int>(type: "int", nullable: false),
                    STARTDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ENDDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISNOTOF_RUN = table.Column<int>(type: "int", nullable: false),
                    ORDER_RUN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(2146)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(2568))
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
                    UnusedDays = table.Column<int>(type: "int", nullable: false),
                    IsExpired = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(7302)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 950, DateTimeKind.Utc).AddTicks(7744))
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
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(3838)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(4278))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(4715)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 951, DateTimeKind.Utc).AddTicks(5215))
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
                name: "PromotionRelations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacancyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PromotionStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Evaluation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(5655)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(6102))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PromotionRelations_Employee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacancyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(7473)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(8038))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promotions_Employee_EmpId",
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(47)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(485))
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
                name: "Terminations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PositionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TerminationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TerminationStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(2568)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(3018))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terminations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Terminations_Employee_EmpId",
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
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(3454)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(3887))
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
                    File = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(4354)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(4787))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(938)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 953, DateTimeKind.Utc).AddTicks(1398))
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(3929)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(5114))
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
                    MarriageRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LeaveWotPayDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LeaveWotPayRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CourtLeaveDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CourtLeaveRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AbortionLeaveDefaultBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AbortionLeaveRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherLeaveRemainingBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SickEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SickStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsExpired = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UnusedDays = table.Column<int>(type: "int", nullable: false),
                    AnnualLeaveBalanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(2655)),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 16, 8, 56, 56, 952, DateTimeKind.Utc).AddTicks(3136))
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
                name: "IX_PromotionRelations_EmpId",
                table: "PromotionRelations",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_EmpId",
                table: "Promotions",
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
                name: "IX_Terminations_EmpId",
                table: "Terminations",
                column: "EmpId");

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
                name: "ActingAssiment");

            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "Allowance");

            migrationBuilder.DropTable(
                name: "AssignSupervisor");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "CheckInOuts");

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
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "LeaveRequest");

            migrationBuilder.DropTable(
                name: "LeaveType");

            migrationBuilder.DropTable(
                name: "NumOfRun");

            migrationBuilder.DropTable(
                name: "NumRunDels");

            migrationBuilder.DropTable(
                name: "OrganizationalProfile");

            migrationBuilder.DropTable(
                name: "OtherLeaveBalance");

            migrationBuilder.DropTable(
                name: "PromotionRelations");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "PromotionVacancys");

            migrationBuilder.DropTable(
                name: "SalaryType");

            migrationBuilder.DropTable(
                name: "schClasses");

            migrationBuilder.DropTable(
                name: "Spouse");

            migrationBuilder.DropTable(
                name: "Step");

            migrationBuilder.DropTable(
                name: "Supervisor");

            migrationBuilder.DropTable(
                name: "Terminations");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "userInformation");

            migrationBuilder.DropTable(
                name: "UserOfNums");

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
