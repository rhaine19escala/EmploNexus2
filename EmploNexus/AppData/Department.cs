//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Department
    {
        public Department()
        {
            this.UserAccounts = new HashSet<UserAccount>();
            this.Employees = new HashSet<Employee>();
        }
    
        public int departmentId { get; set; }
        public string departmentName { get; set; }
        public string departmentDescription { get; set; }
    
        public virtual ICollection<UserAccount> UserAccounts { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
