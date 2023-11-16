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
    
    public partial class UserAccount
    {
        public UserAccount()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int userID { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int roleId { get; set; }
        public int departmentId { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Role Role { get; set; }
    }
}
