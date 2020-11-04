//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineQuizSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.FriendListForStudnets = new HashSet<FriendListForStudnet>();
            this.Results = new HashSet<Result>();
            this.Resultshows = new HashSet<Resultshow>();
        }
    
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Passwords { get; set; }
        public string Email { get; set; }
        public string Institute { get; set; }
        public string Department { get; set; }
        public string Semester { get; set; }
        public Nullable<int> Contact { get; set; }
        public string ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FriendListForStudnet> FriendListForStudnets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Results { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resultshow> Resultshows { get; set; }
    }
}
