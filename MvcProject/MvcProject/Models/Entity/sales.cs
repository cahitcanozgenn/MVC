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

    public partial class sales
    {
        public int salesId { get; set; }
        [Required(ErrorMessage = "Bu alan bo� b�rak�lamaz!!!")]
        public int product { get; set; }
        [Required(ErrorMessage = "Bu alan bo� b�rak�lamaz!!!")]
        public int customer { get; set; }
        [Required(ErrorMessage = "Bu alan bo� b�rak�lamaz!!!")]
        public byte piece { get; set; }
        [Required(ErrorMessage = "Bu alan bo� b�rak�lamaz!!!")]
        public decimal unitPrice { get; set; }
    
        public virtual customer customer1 { get; set; }
        public virtual product product1 { get; set; }
    }
}
