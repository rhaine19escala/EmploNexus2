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
        public int userNo { get; set; }
        public int user_empID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int roleId { get; set; }
        public int departmentId { get; set; }
        public int positionId { get; set; }
        public int genderId { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Position Position { get; set; }
        public virtual Role Role { get; set; }
    }
}
