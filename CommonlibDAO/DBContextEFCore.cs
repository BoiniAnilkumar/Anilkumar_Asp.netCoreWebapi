using CommonlibDAO.Modles;
using CommonlibDAO.Modles.Employee_History;
using CommonlibDAO.Modles.FR_System;
using CommonlibDAO.Modles.MasterTables;
using CommonlibDAO.Modles.Meetings_Fields_Tours;
using CommonlibDAO.Modles.Support;
using CommonlibDAO.Modles.User_Security;
using Microsoft.EntityFrameworkCore;

namespace CommonlibDAO
{
    public class DBContextEFCore : DbContext
    {
        public DBContextEFCore(DbContextOptions<DBContextEFCore> options)
            : base(options)
        {
        }

        // ================= CORE TABLES =================

        public DbSet<tbl_Employee> tbl_Employee { get; set; }
        public DbSet<tbl_Client> tbl_Client { get; set; }
        public DbSet<tbl_company> tbl_company { get; set; }
        public DbSet<tbl_Department> tbl_Department { get; set; }
        public DbSet<tbl_Section> tbl_Section { get; set; }
        public DbSet<tbl_Designation> tbl_Designation { get; set; }
        public DbSet<tbl_Dist> tbl_Dist { get; set; }
        public DbSet<tbl_Location> tbl_Location { get; set; }
        public DbSet<tbl_WorkLocationType> tbl_WorkLocationType { get; set; }
        public DbSet<tbl_EMP_Type> tbl_EMP_Type { get; set; }
        public DbSet<tbl_Gender> tbl_Gender { get; set; }

        // ================= ATTENDANCE =================

        public DbSet<tbl_Attendance> tbl_Attendance { get; set; }
        public DbSet<tbl_Attendance_Extra> tbl_Attendance_Extra { get; set; }
        public DbSet<tbl_Holiday> tbl_Holiday { get; set; }
        public DbSet<tbl_EMP_NotAttendedOffice> tbl_EMP_NotAttendedOffice { get; set; }
        public DbSet<tbl_LeaveTypes> tbl_LeaveTypes { get; set; }
        public DbSet<tbl_NotAttendSubType> tbl_NotAttendSubType { get; set; }

        // ================= FRS =================

        public DbSet<tbl_EMP_FRS_Registration> tbl_EMP_FRS_Registration { get; set; }
        public DbSet<tbl_EMP_FRS_History> tbl_EMP_FRS_History { get; set; }
        public DbSet<tbl_FRS_Key> tbl_FRS_Key { get; set; }
        public DbSet<tbl_FAC_Dtls> tbl_FAC_Dtls { get; set; }

        // ================= SECURITY =================

        public DbSet<tbl_UserLogin> tbl_UserLogin { get; set; }
        public DbSet<tbl_Roles> tbl_Roles { get; set; }
        public DbSet<tbl_HODLevel> tbl_HODLevel { get; set; }

        // ================= HISTORY =================

        public DbSet<tbl_EMP_History> tbl_EMP_History { get; set; }
        public DbSet<tbl_EMP_TransferHistory> tbl_EMP_TransferHistory { get; set; }
        public DbSet<tbl_EmployeeReportingHistory> tbl_EmployeeReportingHistory { get; set; }
        public DbSet<tbl_PEER_EMP_Mapping> tbl_PEER_EMP_Mapping { get; set; }

        // ================= MEETINGS =================

        public DbSet<tbl_EmpMeetings> tbl_EmpMeetings { get; set; }
        public DbSet<tbl_TourTypes> tbl_TourTypes { get; set; }
        public DbSet<tbl_ModeOfTravel> tbl_ModeOfTravel { get; set; }
        public DbSet<tbl_MeetingTypes> tbl_MeetingTypes { get; set; }
        public DbSet<tbl_Emp_FieldVisits> tbl_Emp_FieldVisits { get; set; }

        // ================= SUPPORT =================

        public DbSet<tbl_PostContactSupport> tbl_PostContactSupport { get; set; }
        public DbSet<tbl_DeactivateReasons> tbl_DeactivateReasons { get; set; }
        public DbSet<tbl_Notifications> tbl_Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<tbl_Employee>()
            .HasOne(e => e.ReportsToEmployee)
            .WithMany(e => e.Subordinates)
            .HasForeignKey(e => e.ReportsToEmployeeId)
            .OnDelete(DeleteBehavior.Restrict);

            //Gender
            modelBuilder.Entity<tbl_Employee>()
            .HasOne(e => e.Gender)
            .WithMany(g => g.Employees)
            .HasForeignKey(e => e.GenderId)
            .OnDelete(DeleteBehavior.Restrict);

            // Department
            modelBuilder.Entity<tbl_Employee>()
                .HasOne(e => e.Department)
                .WithMany()
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Section
            modelBuilder.Entity<tbl_Employee>()
                .HasOne(e => e.Section)
                .WithMany()
                .HasForeignKey(e => e.SectionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Designation
            modelBuilder.Entity<tbl_Employee>()
                .HasOne(e => e.Designation)
                .WithMany()
                .HasForeignKey(e => e.DesignationId)
                .OnDelete(DeleteBehavior.Restrict);

            // Location
            modelBuilder.Entity<tbl_Employee>()
                .HasOne(e => e.Location)
                .WithMany()
                .HasForeignKey(e => e.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            // WorkLocationType
            modelBuilder.Entity<tbl_Employee>()
                .HasOne(e => e.WorkLocationType)
                .WithMany()
                .HasForeignKey(e => e.WorkLocationTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // EmpType
            modelBuilder.Entity<tbl_Employee>()
                .HasOne(e => e.EmpType)
                .WithMany()
                .HasForeignKey(e => e.EmpTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // HodLevel
            modelBuilder.Entity<tbl_Employee>()
                .HasOne(e => e.HodLevel)
                .WithMany()
                .HasForeignKey(e => e.HodLevelId)
                .OnDelete(DeleteBehavior.Restrict);


        }

    }
}
