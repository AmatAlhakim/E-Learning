//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Learning.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Feedback()
        {
            this.Admin_Feedback = new HashSet<Admin_Feedback>();
        }
    
        public int id { get; set; }
        public Nullable<int> enrollment_id { get; set; }
        public Nullable<int> rateing_score { get; set; }
        public string feedback_title { get; set; }
        public string feedback_text { get; set; }
        public Nullable<System.DateTime> submission_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Admin_Feedback> Admin_Feedback { get; set; }
        public virtual Enrollment Enrollment { get; set; }
    }
}
