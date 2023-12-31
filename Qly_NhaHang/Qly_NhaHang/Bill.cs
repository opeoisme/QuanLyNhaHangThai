//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Qly_NhaHang
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            this.Bill_Info = new HashSet<Bill_Info>();
        }
    
        public int id_Bill { get; set; }
        public System.DateTime DateCheckIn { get; set; }
        public Nullable<System.DateTime> DateCheckOut { get; set; }
        public int id_Table { get; set; }
        public Nullable<int> discount_Bill { get; set; }
        public int status_Bill { get; set; }
        public string id_NV { get; set; }
        public Nullable<double> totalPrice_Bill { get; set; }
    
        public virtual Discount Discount { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual Tablee Tablee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill_Info> Bill_Info { get; set; }
    }
}
