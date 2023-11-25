﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmploNexus.AppData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EmploNexusu_uEntities : DbContext
    {
        public EmploNexusu_uEntities()
            : base("name=EmploNexusu_uEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<vw_all_attendance> vw_all_attendance { get; set; }
        public DbSet<vw_all_empID> vw_all_empID { get; set; }
        public DbSet<vw_all_empInfo> vw_all_empInfo { get; set; }
        public DbSet<vw_all_employee> vw_all_employee { get; set; }
        public DbSet<vw_all_salary> vw_all_salary { get; set; }
        public DbSet<vw_all_user_role> vw_all_user_role { get; set; }
    
        public virtual int sp_addAttendance(Nullable<int> attendanceEmp_ID, Nullable<System.DateTime> attendanceDate, string attendanceStatus)
        {
            var attendanceEmp_IDParameter = attendanceEmp_ID.HasValue ?
                new ObjectParameter("AttendanceEmp_ID", attendanceEmp_ID) :
                new ObjectParameter("AttendanceEmp_ID", typeof(int));
    
            var attendanceDateParameter = attendanceDate.HasValue ?
                new ObjectParameter("AttendanceDate", attendanceDate) :
                new ObjectParameter("AttendanceDate", typeof(System.DateTime));
    
            var attendanceStatusParameter = attendanceStatus != null ?
                new ObjectParameter("AttendanceStatus", attendanceStatus) :
                new ObjectParameter("AttendanceStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_addAttendance", attendanceEmp_IDParameter, attendanceDateParameter, attendanceStatusParameter);
        }
    
        public virtual int sp_addEmployee(Nullable<int> emp_ID, string emp_name, Nullable<int> emp_genderId, Nullable<System.DateTime> emp_DOB, string emp_email, Nullable<int> emp_departmentId, Nullable<int> emp_positionId)
        {
            var emp_IDParameter = emp_ID.HasValue ?
                new ObjectParameter("emp_ID", emp_ID) :
                new ObjectParameter("emp_ID", typeof(int));
    
            var emp_nameParameter = emp_name != null ?
                new ObjectParameter("emp_name", emp_name) :
                new ObjectParameter("emp_name", typeof(string));
    
            var emp_genderIdParameter = emp_genderId.HasValue ?
                new ObjectParameter("emp_genderId", emp_genderId) :
                new ObjectParameter("emp_genderId", typeof(int));
    
            var emp_DOBParameter = emp_DOB.HasValue ?
                new ObjectParameter("emp_DOB", emp_DOB) :
                new ObjectParameter("emp_DOB", typeof(System.DateTime));
    
            var emp_emailParameter = emp_email != null ?
                new ObjectParameter("emp_email", emp_email) :
                new ObjectParameter("emp_email", typeof(string));
    
            var emp_departmentIdParameter = emp_departmentId.HasValue ?
                new ObjectParameter("emp_departmentId", emp_departmentId) :
                new ObjectParameter("emp_departmentId", typeof(int));
    
            var emp_positionIdParameter = emp_positionId.HasValue ?
                new ObjectParameter("emp_positionId", emp_positionId) :
                new ObjectParameter("emp_positionId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_addEmployee", emp_IDParameter, emp_nameParameter, emp_genderIdParameter, emp_DOBParameter, emp_emailParameter, emp_departmentIdParameter, emp_positionIdParameter);
        }
    
        public virtual int sp_addSalary(Nullable<int> salaryemp_ID, Nullable<decimal> salary_Amount, Nullable<System.DateTime> salary_PayDate)
        {
            var salaryemp_IDParameter = salaryemp_ID.HasValue ?
                new ObjectParameter("Salaryemp_ID", salaryemp_ID) :
                new ObjectParameter("Salaryemp_ID", typeof(int));
    
            var salary_AmountParameter = salary_Amount.HasValue ?
                new ObjectParameter("salary_Amount", salary_Amount) :
                new ObjectParameter("salary_Amount", typeof(decimal));
    
            var salary_PayDateParameter = salary_PayDate.HasValue ?
                new ObjectParameter("salary_PayDate", salary_PayDate) :
                new ObjectParameter("salary_PayDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_addSalary", salaryemp_IDParameter, salary_AmountParameter, salary_PayDateParameter);
        }
    
        public virtual int sp_addUser(Nullable<int> user_empID, string username, string password, Nullable<int> roleId)
        {
            var user_empIDParameter = user_empID.HasValue ?
                new ObjectParameter("user_empID", user_empID) :
                new ObjectParameter("user_empID", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("roleId", roleId) :
                new ObjectParameter("roleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_addUser", user_empIDParameter, usernameParameter, passwordParameter, roleIdParameter);
        }
    
        public virtual int sp_deleteAttendance(Nullable<int> attendanceNo)
        {
            var attendanceNoParameter = attendanceNo.HasValue ?
                new ObjectParameter("AttendanceNo", attendanceNo) :
                new ObjectParameter("AttendanceNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_deleteAttendance", attendanceNoParameter);
        }
    
        public virtual int sp_deleteEmployee(Nullable<int> emp_ID)
        {
            var emp_IDParameter = emp_ID.HasValue ?
                new ObjectParameter("emp_ID", emp_ID) :
                new ObjectParameter("emp_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_deleteEmployee", emp_IDParameter);
        }
    
        public virtual int sp_deleteSalary(Nullable<int> salary_ID)
        {
            var salary_IDParameter = salary_ID.HasValue ?
                new ObjectParameter("salary_ID", salary_ID) :
                new ObjectParameter("salary_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_deleteSalary", salary_IDParameter);
        }
    
        public virtual int sp_deleteUser(Nullable<int> user_empID)
        {
            var user_empIDParameter = user_empID.HasValue ?
                new ObjectParameter("user_empID", user_empID) :
                new ObjectParameter("user_empID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_deleteUser", user_empIDParameter);
        }
    
        public virtual int sp_updateAttendance(Nullable<int> attendanceNo, Nullable<System.DateTime> attendanceDate, string attendanceStatus)
        {
            var attendanceNoParameter = attendanceNo.HasValue ?
                new ObjectParameter("AttendanceNo", attendanceNo) :
                new ObjectParameter("AttendanceNo", typeof(int));
    
            var attendanceDateParameter = attendanceDate.HasValue ?
                new ObjectParameter("AttendanceDate", attendanceDate) :
                new ObjectParameter("AttendanceDate", typeof(System.DateTime));
    
            var attendanceStatusParameter = attendanceStatus != null ?
                new ObjectParameter("AttendanceStatus", attendanceStatus) :
                new ObjectParameter("AttendanceStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateAttendance", attendanceNoParameter, attendanceDateParameter, attendanceStatusParameter);
        }
    
        public virtual int sp_updateEmployee(Nullable<int> emp_ID, string emp_name, Nullable<int> emp_genderId, Nullable<System.DateTime> emp_DOB, string emp_email, Nullable<int> emp_departmentId, Nullable<int> emp_positionId)
        {
            var emp_IDParameter = emp_ID.HasValue ?
                new ObjectParameter("emp_ID", emp_ID) :
                new ObjectParameter("emp_ID", typeof(int));
    
            var emp_nameParameter = emp_name != null ?
                new ObjectParameter("emp_name", emp_name) :
                new ObjectParameter("emp_name", typeof(string));
    
            var emp_genderIdParameter = emp_genderId.HasValue ?
                new ObjectParameter("emp_genderId", emp_genderId) :
                new ObjectParameter("emp_genderId", typeof(int));
    
            var emp_DOBParameter = emp_DOB.HasValue ?
                new ObjectParameter("emp_DOB", emp_DOB) :
                new ObjectParameter("emp_DOB", typeof(System.DateTime));
    
            var emp_emailParameter = emp_email != null ?
                new ObjectParameter("emp_email", emp_email) :
                new ObjectParameter("emp_email", typeof(string));
    
            var emp_departmentIdParameter = emp_departmentId.HasValue ?
                new ObjectParameter("emp_departmentId", emp_departmentId) :
                new ObjectParameter("emp_departmentId", typeof(int));
    
            var emp_positionIdParameter = emp_positionId.HasValue ?
                new ObjectParameter("emp_positionId", emp_positionId) :
                new ObjectParameter("emp_positionId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateEmployee", emp_IDParameter, emp_nameParameter, emp_genderIdParameter, emp_DOBParameter, emp_emailParameter, emp_departmentIdParameter, emp_positionIdParameter);
        }
    
        public virtual int sp_updateSalary(Nullable<int> salary_ID, Nullable<decimal> salary_Amount, Nullable<System.DateTime> salary_PayDate)
        {
            var salary_IDParameter = salary_ID.HasValue ?
                new ObjectParameter("salary_ID", salary_ID) :
                new ObjectParameter("salary_ID", typeof(int));
    
            var salary_AmountParameter = salary_Amount.HasValue ?
                new ObjectParameter("salary_Amount", salary_Amount) :
                new ObjectParameter("salary_Amount", typeof(decimal));
    
            var salary_PayDateParameter = salary_PayDate.HasValue ?
                new ObjectParameter("salary_PayDate", salary_PayDate) :
                new ObjectParameter("salary_PayDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateSalary", salary_IDParameter, salary_AmountParameter, salary_PayDateParameter);
        }
    
        public virtual int sp_updateUser(Nullable<int> user_empID, string username, string password, Nullable<int> roleId)
        {
            var user_empIDParameter = user_empID.HasValue ?
                new ObjectParameter("user_empID", user_empID) :
                new ObjectParameter("user_empID", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var roleIdParameter = roleId.HasValue ?
                new ObjectParameter("roleId", roleId) :
                new ObjectParameter("roleId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateUser", user_empIDParameter, usernameParameter, passwordParameter, roleIdParameter);
        }
    }
}
