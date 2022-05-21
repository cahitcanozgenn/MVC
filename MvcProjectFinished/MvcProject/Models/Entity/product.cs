//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcProject.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            this.sales = new HashSet<sales>();
        }
    
        public int productId { get; set; }
        [Required(ErrorMessage = "Bu alan bo� b�rak�lamaz!!!")]
        [StringLength(30, ErrorMessage = "L�tfen 30 karakterden fazla de�er girmeyiniz!!!")]
        public string productName { get; set; }
        [Required(ErrorMessage = "Bu alan bo� b�rak�lamaz!!!")]
        public int productCategory { get; set; }
        [Required(ErrorMessage = "Bu alan bo� b�rak�lamaz!!!")]
        public decimal productUnitPrice { get; set; }
    
        public virtual category category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sales> sales { get; set; }
    }
}
