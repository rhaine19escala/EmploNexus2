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
    
    public partial class Position
    {
        public Position()
        {
            this.UserAccounts = new HashSet<UserAccount>();
        }
    
        public int positionId { get; set; }
        public string positionName { get; set; }
        public string positionDescription { get; set; }
    
        public virtual ICollection<UserAccount> UserAccounts { get; set; }
    }
}
