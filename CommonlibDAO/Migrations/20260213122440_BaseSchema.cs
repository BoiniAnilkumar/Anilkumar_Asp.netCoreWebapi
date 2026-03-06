using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonlibDAO.Migrations
{
    /// <inheritdoc />
    public partial class BaseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Attendance",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    DateOfAttend = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    OutTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    marked_by_employee_id = table.Column<int>(type: "int", nullable: true),
                    InTime_Latitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    InTime_longitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OutTime_Latitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OutTime_longitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Attendance", x => x.AttendanceID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Attendance_Extra",
                columns: table => new
                {
                    ExtraTimeAttendID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(type: "int", nullable: true),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<byte>(type: "tinyint", nullable: false),
                    DateOfAttend = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InTime_Latitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    InTime_Longitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OutTime_Latitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OutTime_Longitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DurationMinutes = table.Column<int>(type: "int", nullable: true),
                    place = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Attendance_Extra", x => x.ExtraTimeAttendID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Client",
                columns: table => new
                {
                    client_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    contact_email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    contact_phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Client", x => x.client_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_company",
                columns: table => new
                {
                    company_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_company", x => x.company_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_DeactivateReasons",
                columns: table => new
                {
                    DeactivateReason_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeactivateReason = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_DeactivateReasons", x => x.DeactivateReason_ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Department",
                columns: table => new
                {
                    department_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    department_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    created_on = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Department", x => x.department_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Designation",
                columns: table => new
                {
                    designation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    designation_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    reports_to_designation_id = table.Column<int>(type: "int", nullable: true),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    section_id = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    is_hod = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Designation", x => x.designation_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Dist",
                columns: table => new
                {
                    D_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    D_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Dist", x => x.D_ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Emp_FieldVisits",
                columns: table => new
                {
                    FieldVisitID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee_ID = table.Column<int>(type: "int", nullable: false),
                    Client_ID = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Emp_FieldVisits", x => x.FieldVisitID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EMP_FRS_History",
                columns: table => new
                {
                    History_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FRS_ID = table.Column<int>(type: "int", nullable: false),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    ImageTemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRSStatus = table.Column<byte>(type: "tinyint", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ImageFileName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    DeletedReason = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EMP_FRS_History", x => x.History_ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EMP_FRS_Registration",
                columns: table => new
                {
                    FRS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ImageFileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImageTemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FRSStatus = table.Column<byte>(type: "tinyint", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EMP_FRS_Registration", x => x.FRS_ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EMP_History",
                columns: table => new
                {
                    history_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    employee_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    email_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    doj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    section_id = table.Column<int>(type: "int", nullable: true),
                    designation_id = table.Column<int>(type: "int", nullable: false),
                    location_id = table.Column<int>(type: "int", nullable: true),
                    reports_to_employee_id = table.Column<int>(type: "int", nullable: true),
                    is_active = table.Column<bool>(type: "bit", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    allow_proxy_attendance = table.Column<bool>(type: "bit", nullable: false),
                    InTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    OutTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    StrInTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StrOutTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    work_location_type_id = table.Column<int>(type: "int", nullable: true),
                    changed_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EMP_History", x => x.history_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EMP_NotAttendedOffice",
                columns: table => new
                {
                    NotAttendedID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Place = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TotalDays = table.Column<int>(type: "int", nullable: true),
                    TypeOfNotAttende = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubTypeOfNotAttende = table.Column<byte>(type: "tinyint", nullable: false),
                    ModeOfTravelID = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EMP_NotAttendedOffice", x => x.NotAttendedID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EMP_TransferHistory",
                columns: table => new
                {
                    TransferID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    old_department_id = table.Column<int>(type: "int", nullable: true),
                    new_department_id = table.Column<int>(type: "int", nullable: false),
                    old_section_id = table.Column<int>(type: "int", nullable: true),
                    new_section_id = table.Column<int>(type: "int", nullable: true),
                    old_designation_id = table.Column<int>(type: "int", nullable: true),
                    new_designation_id = table.Column<int>(type: "int", nullable: true),
                    old_reports_to_employee_id = table.Column<int>(type: "int", nullable: true),
                    new_reports_to_employee_id = table.Column<int>(type: "int", nullable: true),
                    changed_by = table.Column<int>(type: "int", nullable: true),
                    changed_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EMP_TransferHistory", x => x.TransferID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EMP_Type",
                columns: table => new
                {
                    EmpTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMPType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EMP_Type", x => x.EmpTypeID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Employee",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    employee_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    email_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    gender = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    doj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    section_id = table.Column<int>(type: "int", nullable: true),
                    designation_id = table.Column<int>(type: "int", nullable: false),
                    location_id = table.Column<int>(type: "int", nullable: true),
                    reports_to_employee_id = table.Column<int>(type: "int", nullable: true),
                    is_active = table.Column<bool>(type: "bit", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    allow_proxy_attendance = table.Column<bool>(type: "bit", nullable: false),
                    InTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    OutTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    StrInTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StrOutTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    work_location_type_id = table.Column<int>(type: "int", nullable: true),
                    D_ID = table.Column<int>(type: "int", nullable: true),
                    EmpTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Employee", x => x.employee_id);
                    table.ForeignKey(
                        name: "FK_tbl_Employee_tbl_Employee_reports_to_employee_id",
                        column: x => x.reports_to_employee_id,
                        principalTable: "tbl_Employee",
                        principalColumn: "employee_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EmployeeReportingHistory",
                columns: table => new
                {
                    history_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    old_reports_to_employee_id = table.Column<int>(type: "int", nullable: false),
                    new_reports_to_employee_id = table.Column<int>(type: "int", nullable: false),
                    changed_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    changed_by = table.Column<int>(type: "int", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EmployeeReportingHistory", x => x.history_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_EmpMeetings",
                columns: table => new
                {
                    MeetingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    DateOfMeeting = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FromTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ToTime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MeetingTypeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_EmpMeetings", x => x.MeetingId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FAC_Dtls",
                columns: table => new
                {
                    FAC_Mapping_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    Section_ID = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AssignedBy = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FAC_Dtls", x => x.FAC_Mapping_ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FRS_Key",
                columns: table => new
                {
                    keyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Keyname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KeyValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FRS_Key", x => x.keyID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_HODLevel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HODLevel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_HODLevel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Holiday",
                columns: table => new
                {
                    holiday_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    holiday_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    holiday_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    is_public = table.Column<bool>(type: "bit", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    client_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Holiday", x => x.holiday_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_LeaveTypes",
                columns: table => new
                {
                    LeaveTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_LeaveTypes", x => x.LeaveTypeID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Location",
                columns: table => new
                {
                    location_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    location_name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    latitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    longitude = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Location", x => x.location_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_MeetingTypes",
                columns: table => new
                {
                    MeetingTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_MeetingTypes", x => x.MeetingTypeID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ModeOfTravel",
                columns: table => new
                {
                    ModeOfTravelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ModeOfTravel", x => x.ModeOfTravelID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_NotAttendSubType",
                columns: table => new
                {
                    NotAttendSubTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfNotAttend = table.Column<int>(type: "int", nullable: false),
                    NotAttendSubTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_NotAttendSubType", x => x.NotAttendSubTypeID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Notifications",
                columns: table => new
                {
                    NotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    Createddate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Notifications", x => x.NotificationID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PEER_EMP_Mapping",
                columns: table => new
                {
                    Peer_Mapping_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_ID = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Peer_EMP_ID = table.Column<int>(type: "int", nullable: true),
                    is_active = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PEER_EMP_Mapping", x => x.Peer_Mapping_ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PostContactSupport",
                columns: table => new
                {
                    supportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    Issue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ImageFileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PostContactSupport", x => x.supportID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Section",
                columns: table => new
                {
                    section_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    section_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Section", x => x.section_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_TourTypes",
                columns: table => new
                {
                    TourTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourTypeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TourTypes", x => x.TourTypeID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_UserLogin",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    password_hash = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    employee_id = table.Column<int>(type: "int", nullable: true),
                    is_active = table.Column<bool>(type: "bit", nullable: true),
                    created_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    failed_attempts = table.Column<int>(type: "int", nullable: true),
                    last_failed_attempt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    lockout_until = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_UserLogin", x => x.user_id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_WorkLocationType",
                columns: table => new
                {
                    work_location_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    work_location_type_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    created_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_on = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_WorkLocationType", x => x.work_location_type_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Employee_reports_to_employee_id",
                table: "tbl_Employee",
                column: "reports_to_employee_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Attendance");

            migrationBuilder.DropTable(
                name: "tbl_Attendance_Extra");

            migrationBuilder.DropTable(
                name: "tbl_Client");

            migrationBuilder.DropTable(
                name: "tbl_company");

            migrationBuilder.DropTable(
                name: "tbl_DeactivateReasons");

            migrationBuilder.DropTable(
                name: "tbl_Department");

            migrationBuilder.DropTable(
                name: "tbl_Designation");

            migrationBuilder.DropTable(
                name: "tbl_Dist");

            migrationBuilder.DropTable(
                name: "tbl_Emp_FieldVisits");

            migrationBuilder.DropTable(
                name: "tbl_EMP_FRS_History");

            migrationBuilder.DropTable(
                name: "tbl_EMP_FRS_Registration");

            migrationBuilder.DropTable(
                name: "tbl_EMP_History");

            migrationBuilder.DropTable(
                name: "tbl_EMP_NotAttendedOffice");

            migrationBuilder.DropTable(
                name: "tbl_EMP_TransferHistory");

            migrationBuilder.DropTable(
                name: "tbl_EMP_Type");

            migrationBuilder.DropTable(
                name: "tbl_Employee");

            migrationBuilder.DropTable(
                name: "tbl_EmployeeReportingHistory");

            migrationBuilder.DropTable(
                name: "tbl_EmpMeetings");

            migrationBuilder.DropTable(
                name: "tbl_FAC_Dtls");

            migrationBuilder.DropTable(
                name: "tbl_FRS_Key");

            migrationBuilder.DropTable(
                name: "tbl_HODLevel");

            migrationBuilder.DropTable(
                name: "tbl_Holiday");

            migrationBuilder.DropTable(
                name: "tbl_LeaveTypes");

            migrationBuilder.DropTable(
                name: "tbl_Location");

            migrationBuilder.DropTable(
                name: "tbl_MeetingTypes");

            migrationBuilder.DropTable(
                name: "tbl_ModeOfTravel");

            migrationBuilder.DropTable(
                name: "tbl_NotAttendSubType");

            migrationBuilder.DropTable(
                name: "tbl_Notifications");

            migrationBuilder.DropTable(
                name: "tbl_PEER_EMP_Mapping");

            migrationBuilder.DropTable(
                name: "tbl_PostContactSupport");

            migrationBuilder.DropTable(
                name: "tbl_Roles");

            migrationBuilder.DropTable(
                name: "tbl_Section");

            migrationBuilder.DropTable(
                name: "tbl_TourTypes");

            migrationBuilder.DropTable(
                name: "tbl_UserLogin");

            migrationBuilder.DropTable(
                name: "tbl_WorkLocationType");
        }
    }
}
