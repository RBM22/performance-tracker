//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace performance_tracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class MachineDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MachineDetail()
        {
            this.ProjectDetails = new HashSet<ProjectDetail>();
        }
    
        public int MachId { get; set; }
        public string MachName { get; set; }
        public string MachDesc { get; set; }
        public Nullable<int> MachineID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectDetail> ProjectDetails { get; set; }
    }
}
