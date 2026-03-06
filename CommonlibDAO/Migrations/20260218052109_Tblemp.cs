using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonlibDAO.Migrations
{
    /// <inheritdoc />
    public partial class Tblemp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Employee_tbl_Employee_reports_to_employee_id",
                table: "tbl_Employee");

            migrationBuilder.RenameColumn(
                name: "work_location_type_name",
                table: "tbl_WorkLocationType",
                newName: "WorkLocationTypeName");

            migrationBuilder.RenameColumn(
                name: "modified_on",
                table: "tbl_WorkLocationType",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "tbl_WorkLocationType",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "tbl_WorkLocationType",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "work_location_type_id",
                table: "tbl_WorkLocationType",
                newName: "WorkLocationTypeId");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "tbl_UserLogin",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "tbl_UserLogin",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "tbl_UserLogin",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "lockout_until",
                table: "tbl_UserLogin",
                newName: "LockoutUntil");

            migrationBuilder.RenameColumn(
                name: "last_failed_attempt",
                table: "tbl_UserLogin",
                newName: "LastFailedAttempt");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "tbl_UserLogin",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "failed_attempts",
                table: "tbl_UserLogin",
                newName: "FailedAttempts");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "tbl_UserLogin",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "tbl_UserLogin",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "tbl_UserLogin",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "tbl_UserLogin",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "TourTypeID",
                table: "tbl_TourTypes",
                newName: "TourTypeId");

            migrationBuilder.RenameColumn(
                name: "section_name",
                table: "tbl_Section",
                newName: "SectionName");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "tbl_Section",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "tbl_Section",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "section_id",
                table: "tbl_Section",
                newName: "SectionId");

            migrationBuilder.RenameColumn(
                name: "supportID",
                table: "tbl_PostContactSupport",
                newName: "SupportId");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "tbl_PostContactSupport",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "tbl_PEER_EMP_Mapping",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "Peer_EMP_ID",
                table: "tbl_PEER_EMP_Mapping",
                newName: "PeerEmpId");

            migrationBuilder.RenameColumn(
                name: "EMP_ID",
                table: "tbl_PEER_EMP_Mapping",
                newName: "EmpId");

            migrationBuilder.RenameColumn(
                name: "Peer_Mapping_ID",
                table: "tbl_PEER_EMP_Mapping",
                newName: "PeerMappingId");

            migrationBuilder.RenameColumn(
                name: "Createddate",
                table: "tbl_Notifications",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "NotificationID",
                table: "tbl_Notifications",
                newName: "NotificationId");

            migrationBuilder.RenameColumn(
                name: "NotAttendSubTypeID",
                table: "tbl_NotAttendSubType",
                newName: "NotAttendSubTypeId");

            migrationBuilder.RenameColumn(
                name: "ModeOfTravelID",
                table: "tbl_ModeOfTravel",
                newName: "ModeOfTravelId");

            migrationBuilder.RenameColumn(
                name: "MeetingTypeID",
                table: "tbl_MeetingTypes",
                newName: "MeetingTypeId");

            migrationBuilder.RenameColumn(
                name: "longitude",
                table: "tbl_Location",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "tbl_Location",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "location_name",
                table: "tbl_Location",
                newName: "LocationName");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "tbl_Location",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "tbl_Location",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "tbl_Location",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "tbl_Location",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "location_id",
                table: "tbl_Location",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "LeaveTypeID",
                table: "tbl_LeaveTypes",
                newName: "LeaveTypeId");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "tbl_Holiday",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "is_public",
                table: "tbl_Holiday",
                newName: "IsPublic");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "tbl_Holiday",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "holiday_name",
                table: "tbl_Holiday",
                newName: "HolidayName");

            migrationBuilder.RenameColumn(
                name: "holiday_date",
                table: "tbl_Holiday",
                newName: "HolidayDate");

            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "tbl_Holiday",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "tbl_Holiday",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "tbl_Holiday",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "holiday_id",
                table: "tbl_Holiday",
                newName: "HolidayId");

            migrationBuilder.RenameColumn(
                name: "HODLevel",
                table: "tbl_HODLevel",
                newName: "HodLevel");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "tbl_HODLevel",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Keyname",
                table: "tbl_FRS_Key",
                newName: "KeyName");

            migrationBuilder.RenameColumn(
                name: "keyID",
                table: "tbl_FRS_Key",
                newName: "KeyId");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "tbl_FAC_Dtls",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "Section_ID",
                table: "tbl_FAC_Dtls",
                newName: "SectionId");

            migrationBuilder.RenameColumn(
                name: "FAC_Mapping_ID",
                table: "tbl_FAC_Dtls",
                newName: "FacMappingId");

            migrationBuilder.RenameColumn(
                name: "MeetingTypeID",
                table: "tbl_EmpMeetings",
                newName: "MeetingTypeId");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "tbl_EmpMeetings",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "remarks",
                table: "tbl_EmployeeReportingHistory",
                newName: "Remarks");

            migrationBuilder.RenameColumn(
                name: "old_reports_to_employee_id",
                table: "tbl_EmployeeReportingHistory",
                newName: "OldReportsToEmployeeId");

            migrationBuilder.RenameColumn(
                name: "new_reports_to_employee_id",
                table: "tbl_EmployeeReportingHistory",
                newName: "NewReportsToEmployeeId");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "tbl_EmployeeReportingHistory",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "tbl_EmployeeReportingHistory",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "tbl_EmployeeReportingHistory",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "changed_on",
                table: "tbl_EmployeeReportingHistory",
                newName: "ChangedOn");

            migrationBuilder.RenameColumn(
                name: "changed_by",
                table: "tbl_EmployeeReportingHistory",
                newName: "ChangedBy");

            migrationBuilder.RenameColumn(
                name: "history_id",
                table: "tbl_EmployeeReportingHistory",
                newName: "HistoryId");

            migrationBuilder.RenameColumn(
                name: "multiLocation",
                table: "tbl_Employee",
                newName: "MultiLocation");

            migrationBuilder.RenameColumn(
                name: "isHOD",
                table: "tbl_Employee",
                newName: "IsHod");

            migrationBuilder.RenameColumn(
                name: "isFAC",
                table: "tbl_Employee",
                newName: "IsFac");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "tbl_Employee",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "doj",
                table: "tbl_Employee",
                newName: "Doj");

            migrationBuilder.RenameColumn(
                name: "dob",
                table: "tbl_Employee",
                newName: "Dob");

            migrationBuilder.RenameColumn(
                name: "aadhar",
                table: "tbl_Employee",
                newName: "Aadhar");

            migrationBuilder.RenameColumn(
                name: "EmpTypeID",
                table: "tbl_Employee",
                newName: "EmpTypeId");

            migrationBuilder.RenameColumn(
                name: "AllowFRSUpdate",
                table: "tbl_Employee",
                newName: "AllowFrsUpdate");

            migrationBuilder.RenameColumn(
                name: "work_location_type_id",
                table: "tbl_Employee",
                newName: "WorkLocationTypeId");

            migrationBuilder.RenameColumn(
                name: "updated_on",
                table: "tbl_Employee",
                newName: "UpdatedOn");

            migrationBuilder.RenameColumn(
                name: "section_id",
                table: "tbl_Employee",
                newName: "SectionId");

            migrationBuilder.RenameColumn(
                name: "reports_to_employee_id",
                table: "tbl_Employee",
                newName: "ReportsToEmployeeId");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "tbl_Employee",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "location_id",
                table: "tbl_Employee",
                newName: "ProfileUpdateStatus");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "tbl_Employee",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "idHODLevel",
                table: "tbl_Employee",
                newName: "ProfileUpdateCounts");

            migrationBuilder.RenameColumn(
                name: "employee_name",
                table: "tbl_Employee",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "email_id",
                table: "tbl_Employee",
                newName: "EmailId");

            migrationBuilder.RenameColumn(
                name: "designation_id",
                table: "tbl_Employee",
                newName: "DesignationId");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "tbl_Employee",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "tbl_Employee",
                newName: "DeactivatedOn");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "tbl_Employee",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "allow_proxy_attendance",
                table: "tbl_Employee",
                newName: "AllowProxyAttendance");

            migrationBuilder.RenameColumn(
                name: "Profile_update_Status",
                table: "tbl_Employee",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "Profile_update_Counts",
                table: "tbl_Employee",
                newName: "HodLevelId");

            migrationBuilder.RenameColumn(
                name: "IsTeachingORNon",
                table: "tbl_Employee",
                newName: "TeachingOrNonTeaching");

            migrationBuilder.RenameColumn(
                name: "Dept_EMP_ID",
                table: "tbl_Employee",
                newName: "DeptEmpId");

            migrationBuilder.RenameColumn(
                name: "Deactivated_On",
                table: "tbl_Employee",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "DeactivateReason_ID",
                table: "tbl_Employee",
                newName: "DeactivateReasonId");

            migrationBuilder.RenameColumn(
                name: "D_ID",
                table: "tbl_Employee",
                newName: "DId");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "tbl_Employee",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Employee_reports_to_employee_id",
                table: "tbl_Employee",
                newName: "IX_tbl_Employee_ReportsToEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EmpTypeID",
                table: "tbl_EMP_Type",
                newName: "EmpTypeId");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "tbl_EMP_Type",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "EMPType",
                table: "tbl_EMP_Type",
                newName: "EmpTypeName");

            migrationBuilder.RenameColumn(
                name: "remarks",
                table: "tbl_EMP_TransferHistory",
                newName: "Remarks");

            migrationBuilder.RenameColumn(
                name: "TransferID",
                table: "tbl_EMP_TransferHistory",
                newName: "TransferId");

            migrationBuilder.RenameColumn(
                name: "old_section_id",
                table: "tbl_EMP_TransferHistory",
                newName: "OldSectionId");

            migrationBuilder.RenameColumn(
                name: "old_reports_to_employee_id",
                table: "tbl_EMP_TransferHistory",
                newName: "OldReportsToEmployeeId");

            migrationBuilder.RenameColumn(
                name: "old_designation_id",
                table: "tbl_EMP_TransferHistory",
                newName: "OldDesignationId");

            migrationBuilder.RenameColumn(
                name: "old_department_id",
                table: "tbl_EMP_TransferHistory",
                newName: "OldDepartmentId");

            migrationBuilder.RenameColumn(
                name: "new_section_id",
                table: "tbl_EMP_TransferHistory",
                newName: "NewSectionId");

            migrationBuilder.RenameColumn(
                name: "new_reports_to_employee_id",
                table: "tbl_EMP_TransferHistory",
                newName: "NewReportsToEmployeeId");

            migrationBuilder.RenameColumn(
                name: "new_designation_id",
                table: "tbl_EMP_TransferHistory",
                newName: "NewDesignationId");

            migrationBuilder.RenameColumn(
                name: "new_department_id",
                table: "tbl_EMP_TransferHistory",
                newName: "NewDepartmentId");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "tbl_EMP_TransferHistory",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "changed_on",
                table: "tbl_EMP_TransferHistory",
                newName: "ChangedOn");

            migrationBuilder.RenameColumn(
                name: "changed_by",
                table: "tbl_EMP_TransferHistory",
                newName: "ChangedBy");

            migrationBuilder.RenameColumn(
                name: "ModeOfTravelID",
                table: "tbl_EMP_NotAttendedOffice",
                newName: "ModeOfTravelId");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "tbl_EMP_NotAttendedOffice",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "NotAttendedID",
                table: "tbl_EMP_NotAttendedOffice",
                newName: "NotAttendedId");

            migrationBuilder.RenameColumn(
                name: "TypeOfNotAttende",
                table: "tbl_EMP_NotAttendedOffice",
                newName: "TypeOfNotAttended");

            migrationBuilder.RenameColumn(
                name: "SubTypeOfNotAttende",
                table: "tbl_EMP_NotAttendedOffice",
                newName: "SubTypeOfNotAttended");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "tbl_EMP_History",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "doj",
                table: "tbl_EMP_History",
                newName: "Doj");

            migrationBuilder.RenameColumn(
                name: "dob",
                table: "tbl_EMP_History",
                newName: "Dob");

            migrationBuilder.RenameColumn(
                name: "EmpTypeID",
                table: "tbl_EMP_History",
                newName: "EmpTypeId");

            migrationBuilder.RenameColumn(
                name: "work_location_type_id",
                table: "tbl_EMP_History",
                newName: "WorkLocationTypeId");

            migrationBuilder.RenameColumn(
                name: "section_id",
                table: "tbl_EMP_History",
                newName: "SectionId");

            migrationBuilder.RenameColumn(
                name: "reports_to_employee_id",
                table: "tbl_EMP_History",
                newName: "ReportsToEmployeeId");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "tbl_EMP_History",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "location_id",
                table: "tbl_EMP_History",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "is_active",
                table: "tbl_EMP_History",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "employee_name",
                table: "tbl_EMP_History",
                newName: "EmployeeName");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "tbl_EMP_History",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "email_id",
                table: "tbl_EMP_History",
                newName: "EmailId");

            migrationBuilder.RenameColumn(
                name: "designation_id",
                table: "tbl_EMP_History",
                newName: "DesignationId");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "tbl_EMP_History",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "tbl_EMP_History",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "tbl_EMP_History",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "changed_on",
                table: "tbl_EMP_History",
                newName: "ChangedOn");

            migrationBuilder.RenameColumn(
                name: "allow_proxy_attendance",
                table: "tbl_EMP_History",
                newName: "AllowProxyAttendance");

            migrationBuilder.RenameColumn(
                name: "history_id",
                table: "tbl_EMP_History",
                newName: "HistoryId");

            migrationBuilder.RenameColumn(
                name: "FRSStatus",
                table: "tbl_EMP_FRS_Registration",
                newName: "FrsStatus");

            migrationBuilder.RenameColumn(
                name: "FRS_ID",
                table: "tbl_EMP_FRS_Registration",
                newName: "Frs_Id");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "tbl_EMP_FRS_Registration",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "FRSStatus",
                table: "tbl_EMP_FRS_History",
                newName: "FrsStatus");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "tbl_EMP_FRS_History",
                newName: "FrsId");

            migrationBuilder.RenameColumn(
                name: "FRS_ID",
                table: "tbl_EMP_FRS_History",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "History_ID",
                table: "tbl_EMP_FRS_History",
                newName: "HistoryId");

            migrationBuilder.RenameColumn(
                name: "FieldVisitID",
                table: "tbl_Emp_FieldVisits",
                newName: "FieldVisitId");

            migrationBuilder.RenameColumn(
                name: "Employee_ID",
                table: "tbl_Emp_FieldVisits",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "Client_ID",
                table: "tbl_Emp_FieldVisits",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "D_Name",
                table: "tbl_Dist",
                newName: "DName");

            migrationBuilder.RenameColumn(
                name: "D_ID",
                table: "tbl_Dist",
                newName: "DId");

            migrationBuilder.RenameColumn(
                name: "section_id",
                table: "tbl_Designation",
                newName: "SectionId");

            migrationBuilder.RenameColumn(
                name: "reports_to_designation_id",
                table: "tbl_Designation",
                newName: "ReportsToDesignationId");

            migrationBuilder.RenameColumn(
                name: "is_hod",
                table: "tbl_Designation",
                newName: "IsHod");

            migrationBuilder.RenameColumn(
                name: "designation_name",
                table: "tbl_Designation",
                newName: "DesignationName");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "tbl_Designation",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "tbl_Designation",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "designation_id",
                table: "tbl_Designation",
                newName: "DesignationId");

            migrationBuilder.RenameColumn(
                name: "department_name",
                table: "tbl_Department",
                newName: "DepartmentName");

            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "tbl_Department",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "tbl_Department",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "tbl_Department",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "DeactivateReason_ID",
                table: "tbl_DeactivateReasons",
                newName: "DeactivateReasonId");

            migrationBuilder.RenameColumn(
                name: "company_name",
                table: "tbl_company",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "company_id",
                table: "tbl_company",
                newName: "CompanyId");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "tbl_Client",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "created_on",
                table: "tbl_Client",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "contact_phone",
                table: "tbl_Client",
                newName: "ContactPhone");

            migrationBuilder.RenameColumn(
                name: "contact_email",
                table: "tbl_Client",
                newName: "ContactEmail");

            migrationBuilder.RenameColumn(
                name: "client_name",
                table: "tbl_Client",
                newName: "ClientName");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "tbl_Client",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "place",
                table: "tbl_Attendance_Extra",
                newName: "Place");

            migrationBuilder.RenameColumn(
                name: "TypeID",
                table: "tbl_Attendance_Extra",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "tbl_Attendance_Extra",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "tbl_Attendance_Extra",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "ExtraTimeAttendID",
                table: "tbl_Attendance_Extra",
                newName: "ExtraTimeAttendId");

            migrationBuilder.RenameColumn(
                name: "OutTime_Longitude",
                table: "tbl_Attendance_Extra",
                newName: "OutTimeLongitude");

            migrationBuilder.RenameColumn(
                name: "OutTime_Latitude",
                table: "tbl_Attendance_Extra",
                newName: "OutTimeLatitude");

            migrationBuilder.RenameColumn(
                name: "InTime_Longitude",
                table: "tbl_Attendance_Extra",
                newName: "InTimeLongitude");

            migrationBuilder.RenameColumn(
                name: "InTime_Latitude",
                table: "tbl_Attendance_Extra",
                newName: "InTimeLatitude");

            migrationBuilder.RenameColumn(
                name: "AttendanceID",
                table: "tbl_Attendance",
                newName: "AttendanceId");

            migrationBuilder.RenameColumn(
                name: "marked_by_employee_id",
                table: "tbl_Attendance",
                newName: "MarkedByEmployeeId");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "tbl_Attendance",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "OutTime_longitude",
                table: "tbl_Attendance",
                newName: "OutTimeLongitude");

            migrationBuilder.RenameColumn(
                name: "OutTime_Latitude",
                table: "tbl_Attendance",
                newName: "OutTimeLatitude");

            migrationBuilder.RenameColumn(
                name: "InTime_longitude",
                table: "tbl_Attendance",
                newName: "InTimeLongitude");

            migrationBuilder.RenameColumn(
                name: "InTime_Latitude",
                table: "tbl_Attendance",
                newName: "InTimeLatitude");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Employee_tbl_Employee_ReportsToEmployeeId",
                table: "tbl_Employee",
                column: "ReportsToEmployeeId",
                principalTable: "tbl_Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_Employee_tbl_Employee_ReportsToEmployeeId",
                table: "tbl_Employee");

            migrationBuilder.RenameColumn(
                name: "WorkLocationTypeName",
                table: "tbl_WorkLocationType",
                newName: "work_location_type_name");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                table: "tbl_WorkLocationType",
                newName: "modified_on");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "tbl_WorkLocationType",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "tbl_WorkLocationType",
                newName: "created_on");

            migrationBuilder.RenameColumn(
                name: "WorkLocationTypeId",
                table: "tbl_WorkLocationType",
                newName: "work_location_type_id");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "tbl_UserLogin",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "tbl_UserLogin",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "tbl_UserLogin",
                newName: "password_hash");

            migrationBuilder.RenameColumn(
                name: "LockoutUntil",
                table: "tbl_UserLogin",
                newName: "lockout_until");

            migrationBuilder.RenameColumn(
                name: "LastFailedAttempt",
                table: "tbl_UserLogin",
                newName: "last_failed_attempt");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "tbl_UserLogin",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "FailedAttempts",
                table: "tbl_UserLogin",
                newName: "failed_attempts");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_UserLogin",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "tbl_UserLogin",
                newName: "created_on");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_UserLogin",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "tbl_UserLogin",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "TourTypeId",
                table: "tbl_TourTypes",
                newName: "TourTypeID");

            migrationBuilder.RenameColumn(
                name: "SectionName",
                table: "tbl_Section",
                newName: "section_name");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "tbl_Section",
                newName: "department_id");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_Section",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "tbl_Section",
                newName: "section_id");

            migrationBuilder.RenameColumn(
                name: "SupportId",
                table: "tbl_PostContactSupport",
                newName: "supportID");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_PostContactSupport",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "PeerEmpId",
                table: "tbl_PEER_EMP_Mapping",
                newName: "Peer_EMP_ID");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "tbl_PEER_EMP_Mapping",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "tbl_PEER_EMP_Mapping",
                newName: "EMP_ID");

            migrationBuilder.RenameColumn(
                name: "PeerMappingId",
                table: "tbl_PEER_EMP_Mapping",
                newName: "Peer_Mapping_ID");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "tbl_Notifications",
                newName: "Createddate");

            migrationBuilder.RenameColumn(
                name: "NotificationId",
                table: "tbl_Notifications",
                newName: "NotificationID");

            migrationBuilder.RenameColumn(
                name: "NotAttendSubTypeId",
                table: "tbl_NotAttendSubType",
                newName: "NotAttendSubTypeID");

            migrationBuilder.RenameColumn(
                name: "ModeOfTravelId",
                table: "tbl_ModeOfTravel",
                newName: "ModeOfTravelID");

            migrationBuilder.RenameColumn(
                name: "MeetingTypeId",
                table: "tbl_MeetingTypes",
                newName: "MeetingTypeID");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "tbl_Location",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "tbl_Location",
                newName: "latitude");

            migrationBuilder.RenameColumn(
                name: "LocationName",
                table: "tbl_Location",
                newName: "location_name");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "tbl_Location",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "tbl_Location",
                newName: "created_on");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "tbl_Location",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_Location",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "tbl_Location",
                newName: "location_id");

            migrationBuilder.RenameColumn(
                name: "LeaveTypeId",
                table: "tbl_LeaveTypes",
                newName: "LeaveTypeID");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "tbl_Holiday",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "IsPublic",
                table: "tbl_Holiday",
                newName: "is_public");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "tbl_Holiday",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "HolidayName",
                table: "tbl_Holiday",
                newName: "holiday_name");

            migrationBuilder.RenameColumn(
                name: "HolidayDate",
                table: "tbl_Holiday",
                newName: "holiday_date");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "tbl_Holiday",
                newName: "created_on");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "tbl_Holiday",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_Holiday",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "HolidayId",
                table: "tbl_Holiday",
                newName: "holiday_id");

            migrationBuilder.RenameColumn(
                name: "HodLevel",
                table: "tbl_HODLevel",
                newName: "HODLevel");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tbl_HODLevel",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "KeyName",
                table: "tbl_FRS_Key",
                newName: "Keyname");

            migrationBuilder.RenameColumn(
                name: "KeyId",
                table: "tbl_FRS_Key",
                newName: "keyID");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_FAC_Dtls",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "tbl_FAC_Dtls",
                newName: "Section_ID");

            migrationBuilder.RenameColumn(
                name: "FacMappingId",
                table: "tbl_FAC_Dtls",
                newName: "FAC_Mapping_ID");

            migrationBuilder.RenameColumn(
                name: "MeetingTypeId",
                table: "tbl_EmpMeetings",
                newName: "MeetingTypeID");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_EmpMeetings",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "tbl_EmployeeReportingHistory",
                newName: "remarks");

            migrationBuilder.RenameColumn(
                name: "OldReportsToEmployeeId",
                table: "tbl_EmployeeReportingHistory",
                newName: "old_reports_to_employee_id");

            migrationBuilder.RenameColumn(
                name: "NewReportsToEmployeeId",
                table: "tbl_EmployeeReportingHistory",
                newName: "new_reports_to_employee_id");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_EmployeeReportingHistory",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "tbl_EmployeeReportingHistory",
                newName: "department_id");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_EmployeeReportingHistory",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "ChangedOn",
                table: "tbl_EmployeeReportingHistory",
                newName: "changed_on");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "tbl_EmployeeReportingHistory",
                newName: "changed_by");

            migrationBuilder.RenameColumn(
                name: "HistoryId",
                table: "tbl_EmployeeReportingHistory",
                newName: "history_id");

            migrationBuilder.RenameColumn(
                name: "MultiLocation",
                table: "tbl_Employee",
                newName: "multiLocation");

            migrationBuilder.RenameColumn(
                name: "IsHod",
                table: "tbl_Employee",
                newName: "isHOD");

            migrationBuilder.RenameColumn(
                name: "IsFac",
                table: "tbl_Employee",
                newName: "isFAC");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "tbl_Employee",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "EmpTypeId",
                table: "tbl_Employee",
                newName: "EmpTypeID");

            migrationBuilder.RenameColumn(
                name: "Doj",
                table: "tbl_Employee",
                newName: "doj");

            migrationBuilder.RenameColumn(
                name: "Dob",
                table: "tbl_Employee",
                newName: "dob");

            migrationBuilder.RenameColumn(
                name: "AllowFrsUpdate",
                table: "tbl_Employee",
                newName: "AllowFRSUpdate");

            migrationBuilder.RenameColumn(
                name: "Aadhar",
                table: "tbl_Employee",
                newName: "aadhar");

            migrationBuilder.RenameColumn(
                name: "WorkLocationTypeId",
                table: "tbl_Employee",
                newName: "work_location_type_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "tbl_Employee",
                newName: "updated_on");

            migrationBuilder.RenameColumn(
                name: "TeachingOrNonTeaching",
                table: "tbl_Employee",
                newName: "IsTeachingORNon");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "tbl_Employee",
                newName: "section_id");

            migrationBuilder.RenameColumn(
                name: "ReportsToEmployeeId",
                table: "tbl_Employee",
                newName: "reports_to_employee_id");

            migrationBuilder.RenameColumn(
                name: "ProfileUpdateStatus",
                table: "tbl_Employee",
                newName: "location_id");

            migrationBuilder.RenameColumn(
                name: "ProfileUpdateCounts",
                table: "tbl_Employee",
                newName: "idHODLevel");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "tbl_Employee",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "tbl_Employee",
                newName: "Profile_update_Status");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "tbl_Employee",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "HodLevelId",
                table: "tbl_Employee",
                newName: "Profile_update_Counts");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "tbl_Employee",
                newName: "employee_name");

            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "tbl_Employee",
                newName: "email_id");

            migrationBuilder.RenameColumn(
                name: "DesignationId",
                table: "tbl_Employee",
                newName: "designation_id");

            migrationBuilder.RenameColumn(
                name: "DeptEmpId",
                table: "tbl_Employee",
                newName: "Dept_EMP_ID");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "tbl_Employee",
                newName: "department_id");

            migrationBuilder.RenameColumn(
                name: "DeactivatedOn",
                table: "tbl_Employee",
                newName: "created_on");

            migrationBuilder.RenameColumn(
                name: "DeactivateReasonId",
                table: "tbl_Employee",
                newName: "DeactivateReason_ID");

            migrationBuilder.RenameColumn(
                name: "DId",
                table: "tbl_Employee",
                newName: "D_ID");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "tbl_Employee",
                newName: "Deactivated_On");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_Employee",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "AllowProxyAttendance",
                table: "tbl_Employee",
                newName: "allow_proxy_attendance");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_Employee",
                newName: "employee_id");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_Employee_ReportsToEmployeeId",
                table: "tbl_Employee",
                newName: "IX_tbl_Employee_reports_to_employee_id");

            migrationBuilder.RenameColumn(
                name: "EmpTypeId",
                table: "tbl_EMP_Type",
                newName: "EmpTypeID");

            migrationBuilder.RenameColumn(
                name: "EmpTypeName",
                table: "tbl_EMP_Type",
                newName: "EMPType");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_EMP_Type",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "tbl_EMP_TransferHistory",
                newName: "remarks");

            migrationBuilder.RenameColumn(
                name: "TransferId",
                table: "tbl_EMP_TransferHistory",
                newName: "TransferID");

            migrationBuilder.RenameColumn(
                name: "OldSectionId",
                table: "tbl_EMP_TransferHistory",
                newName: "old_section_id");

            migrationBuilder.RenameColumn(
                name: "OldReportsToEmployeeId",
                table: "tbl_EMP_TransferHistory",
                newName: "old_reports_to_employee_id");

            migrationBuilder.RenameColumn(
                name: "OldDesignationId",
                table: "tbl_EMP_TransferHistory",
                newName: "old_designation_id");

            migrationBuilder.RenameColumn(
                name: "OldDepartmentId",
                table: "tbl_EMP_TransferHistory",
                newName: "old_department_id");

            migrationBuilder.RenameColumn(
                name: "NewSectionId",
                table: "tbl_EMP_TransferHistory",
                newName: "new_section_id");

            migrationBuilder.RenameColumn(
                name: "NewReportsToEmployeeId",
                table: "tbl_EMP_TransferHistory",
                newName: "new_reports_to_employee_id");

            migrationBuilder.RenameColumn(
                name: "NewDesignationId",
                table: "tbl_EMP_TransferHistory",
                newName: "new_designation_id");

            migrationBuilder.RenameColumn(
                name: "NewDepartmentId",
                table: "tbl_EMP_TransferHistory",
                newName: "new_department_id");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_EMP_TransferHistory",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "ChangedOn",
                table: "tbl_EMP_TransferHistory",
                newName: "changed_on");

            migrationBuilder.RenameColumn(
                name: "ChangedBy",
                table: "tbl_EMP_TransferHistory",
                newName: "changed_by");

            migrationBuilder.RenameColumn(
                name: "ModeOfTravelId",
                table: "tbl_EMP_NotAttendedOffice",
                newName: "ModeOfTravelID");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_EMP_NotAttendedOffice",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "NotAttendedId",
                table: "tbl_EMP_NotAttendedOffice",
                newName: "NotAttendedID");

            migrationBuilder.RenameColumn(
                name: "TypeOfNotAttended",
                table: "tbl_EMP_NotAttendedOffice",
                newName: "TypeOfNotAttende");

            migrationBuilder.RenameColumn(
                name: "SubTypeOfNotAttended",
                table: "tbl_EMP_NotAttendedOffice",
                newName: "SubTypeOfNotAttende");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "tbl_EMP_History",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "EmpTypeId",
                table: "tbl_EMP_History",
                newName: "EmpTypeID");

            migrationBuilder.RenameColumn(
                name: "Doj",
                table: "tbl_EMP_History",
                newName: "doj");

            migrationBuilder.RenameColumn(
                name: "Dob",
                table: "tbl_EMP_History",
                newName: "dob");

            migrationBuilder.RenameColumn(
                name: "WorkLocationTypeId",
                table: "tbl_EMP_History",
                newName: "work_location_type_id");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "tbl_EMP_History",
                newName: "section_id");

            migrationBuilder.RenameColumn(
                name: "ReportsToEmployeeId",
                table: "tbl_EMP_History",
                newName: "reports_to_employee_id");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "tbl_EMP_History",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "tbl_EMP_History",
                newName: "location_id");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "tbl_EMP_History",
                newName: "is_active");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "tbl_EMP_History",
                newName: "employee_name");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_EMP_History",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "tbl_EMP_History",
                newName: "email_id");

            migrationBuilder.RenameColumn(
                name: "DesignationId",
                table: "tbl_EMP_History",
                newName: "designation_id");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "tbl_EMP_History",
                newName: "department_id");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "tbl_EMP_History",
                newName: "created_on");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_EMP_History",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "ChangedOn",
                table: "tbl_EMP_History",
                newName: "changed_on");

            migrationBuilder.RenameColumn(
                name: "AllowProxyAttendance",
                table: "tbl_EMP_History",
                newName: "allow_proxy_attendance");

            migrationBuilder.RenameColumn(
                name: "HistoryId",
                table: "tbl_EMP_History",
                newName: "history_id");

            migrationBuilder.RenameColumn(
                name: "FrsStatus",
                table: "tbl_EMP_FRS_Registration",
                newName: "FRSStatus");

            migrationBuilder.RenameColumn(
                name: "Frs_Id",
                table: "tbl_EMP_FRS_Registration",
                newName: "FRS_ID");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_EMP_FRS_Registration",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "FrsStatus",
                table: "tbl_EMP_FRS_History",
                newName: "FRSStatus");

            migrationBuilder.RenameColumn(
                name: "FrsId",
                table: "tbl_EMP_FRS_History",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_EMP_FRS_History",
                newName: "FRS_ID");

            migrationBuilder.RenameColumn(
                name: "HistoryId",
                table: "tbl_EMP_FRS_History",
                newName: "History_ID");

            migrationBuilder.RenameColumn(
                name: "FieldVisitId",
                table: "tbl_Emp_FieldVisits",
                newName: "FieldVisitID");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_Emp_FieldVisits",
                newName: "Employee_ID");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_Emp_FieldVisits",
                newName: "Client_ID");

            migrationBuilder.RenameColumn(
                name: "DName",
                table: "tbl_Dist",
                newName: "D_Name");

            migrationBuilder.RenameColumn(
                name: "DId",
                table: "tbl_Dist",
                newName: "D_ID");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "tbl_Designation",
                newName: "section_id");

            migrationBuilder.RenameColumn(
                name: "ReportsToDesignationId",
                table: "tbl_Designation",
                newName: "reports_to_designation_id");

            migrationBuilder.RenameColumn(
                name: "IsHod",
                table: "tbl_Designation",
                newName: "is_hod");

            migrationBuilder.RenameColumn(
                name: "DesignationName",
                table: "tbl_Designation",
                newName: "designation_name");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "tbl_Designation",
                newName: "department_id");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_Designation",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "DesignationId",
                table: "tbl_Designation",
                newName: "designation_id");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "tbl_Department",
                newName: "department_name");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "tbl_Department",
                newName: "created_on");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_Department",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "tbl_Department",
                newName: "department_id");

            migrationBuilder.RenameColumn(
                name: "DeactivateReasonId",
                table: "tbl_DeactivateReasons",
                newName: "DeactivateReason_ID");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "tbl_company",
                newName: "company_name");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "tbl_company",
                newName: "company_id");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "tbl_Client",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "tbl_Client",
                newName: "created_on");

            migrationBuilder.RenameColumn(
                name: "ContactPhone",
                table: "tbl_Client",
                newName: "contact_phone");

            migrationBuilder.RenameColumn(
                name: "ContactEmail",
                table: "tbl_Client",
                newName: "contact_email");

            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "tbl_Client",
                newName: "client_name");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_Client",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "tbl_Attendance_Extra",
                newName: "TypeID");

            migrationBuilder.RenameColumn(
                name: "Place",
                table: "tbl_Attendance_Extra",
                newName: "place");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_Attendance_Extra",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "tbl_Attendance_Extra",
                newName: "ClientID");

            migrationBuilder.RenameColumn(
                name: "ExtraTimeAttendId",
                table: "tbl_Attendance_Extra",
                newName: "ExtraTimeAttendID");

            migrationBuilder.RenameColumn(
                name: "OutTimeLongitude",
                table: "tbl_Attendance_Extra",
                newName: "OutTime_Longitude");

            migrationBuilder.RenameColumn(
                name: "OutTimeLatitude",
                table: "tbl_Attendance_Extra",
                newName: "OutTime_Latitude");

            migrationBuilder.RenameColumn(
                name: "InTimeLongitude",
                table: "tbl_Attendance_Extra",
                newName: "InTime_Longitude");

            migrationBuilder.RenameColumn(
                name: "InTimeLatitude",
                table: "tbl_Attendance_Extra",
                newName: "InTime_Latitude");

            migrationBuilder.RenameColumn(
                name: "AttendanceId",
                table: "tbl_Attendance",
                newName: "AttendanceID");

            migrationBuilder.RenameColumn(
                name: "OutTimeLongitude",
                table: "tbl_Attendance",
                newName: "OutTime_longitude");

            migrationBuilder.RenameColumn(
                name: "OutTimeLatitude",
                table: "tbl_Attendance",
                newName: "OutTime_Latitude");

            migrationBuilder.RenameColumn(
                name: "MarkedByEmployeeId",
                table: "tbl_Attendance",
                newName: "marked_by_employee_id");

            migrationBuilder.RenameColumn(
                name: "InTimeLongitude",
                table: "tbl_Attendance",
                newName: "InTime_longitude");

            migrationBuilder.RenameColumn(
                name: "InTimeLatitude",
                table: "tbl_Attendance",
                newName: "InTime_Latitude");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "tbl_Attendance",
                newName: "employee_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_Employee_tbl_Employee_reports_to_employee_id",
                table: "tbl_Employee",
                column: "reports_to_employee_id",
                principalTable: "tbl_Employee",
                principalColumn: "employee_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
