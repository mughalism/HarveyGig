//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HarveyJobs.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbAppInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbAppInfo()
        {
            this.tbScheduledJobs = new HashSet<tbScheduledJob>();
        }
    
        public int AppID { get; set; }
        public string AppName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbScheduledJob> tbScheduledJobs { get; set; }
    }
}