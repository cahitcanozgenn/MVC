//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rizeMetroTurizmMvc.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public person()
        {
            this.bus = new HashSet<bus>();
        }
    
        public int personId { get; set; }
        public string personIdentityNumber { get; set; }
        public string personFirstName { get; set; }
        public string personLastName { get; set; }
        public string personDriverLicenceNumber { get; set; }
        public Nullable<System.DateTime> personBirthDate { get; set; }
        public string personPlaceOfBirth { get; set; }
        public string personIBAN { get; set; }
        public string personImage { get; set; }
        public Nullable<int> personDegree { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bus> bus { get; set; }
        public virtual degree degree { get; set; }
    }
}
