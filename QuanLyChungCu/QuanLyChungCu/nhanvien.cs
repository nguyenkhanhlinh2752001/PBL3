//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyChungCu
{
    using System;
    using System.Collections.Generic;
    
    public partial class nhanvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhanvien()
        {
            this.hoadondichvus = new HashSet<hoadondichvu>();
            this.hopdongs = new HashSet<hopdong>();
            this.taikhoans = new HashSet<taikhoan>();
        }
    
        public int manhanvien { get; set; }
        public Nullable<int> machucvu { get; set; }
        public string tennhanvien { get; set; }
        public bool gioitinh { get; set; }
        public string cmnd { get; set; }
        public string sdt { get; set; }
        public System.DateTime ngaysinh { get; set; }
    
        public virtual chucvu chucvu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoadondichvu> hoadondichvus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hopdong> hopdongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<taikhoan> taikhoans { get; set; }
    }
}
