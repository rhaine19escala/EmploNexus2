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
    
    public partial class Gender
    {
        public Gender()
        {
            this.UserAccounts = new HashSet<UserAccount>();
        }
    
        public int genderId { get; set; }
        public string genderName { get; set; }
    
        public virtual ICollection<UserAccount> UserAccounts { get; set; }
    }
}
