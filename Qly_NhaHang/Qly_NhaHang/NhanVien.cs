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
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.Bills = new HashSet<Bill>();
            this.Imports = new HashSet<Import>();
        }
    
        public string id_NV { get; set; }
        public string name_NV { get; set; }
        public string sex_NV { get; set; }
        public string address_NV { get; set; }
        public string CCCD_NV { get; set; }
        public string phone_NV { get; set; }
        public string pass_NV { get; set; }
        public byte[] image_NV { get; set; }
        public string type_NV { get; set; }
        public string condition_NV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Import> Imports { get; set; }
    }
}