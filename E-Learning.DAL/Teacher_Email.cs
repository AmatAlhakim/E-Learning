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
    
    public partial class Teacher_Email
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher_Email()
        {
            this.Teacher_Student_Email = new HashSet<Teacher_Student_Email>();
        }
    
        public int id { get; set; }
        public Nullable<int> teacher_id { get; set; }
        public string email_to { get; set; }
        public string text { get; set; }
        public string title { get; set; }
        public Nullable<System.DateTime> send_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teacher_Student_Email> Teacher_Student_Email { get; set; }
    }
}
