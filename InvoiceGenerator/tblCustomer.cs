//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InvoiceGenerator
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCustomer()
        {
            this.tblInvoice = new HashSet<tblInvoice>();
            this.tblDescription = new HashSet<tblDescription>();
        }
    
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BusinessName { get; set; }
        public string BusinessAddress { get; set; }
        public string BusinessWebsite { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInvoice> tblInvoice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDescription> tblDescription { get; set; }
    }
}