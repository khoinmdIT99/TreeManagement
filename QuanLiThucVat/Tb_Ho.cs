//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiThucVat
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Ho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Ho()
        {
            this.Tb_ThucVat = new HashSet<Tb_ThucVat>();
            this.Tb_ThucVat1 = new HashSet<Tb_ThucVat>();
        }
    
        public int ID { get; set; }
        public string TenHo { get; set; }
        public Nullable<int> IDBo { get; set; }
    
        public virtual Tb_Bo Tb_Bo { get; set; }
        public virtual Tb_Bo Tb_Bo1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_ThucVat> Tb_ThucVat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_ThucVat> Tb_ThucVat1 { get; set; }
    }
}
