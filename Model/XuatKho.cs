//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class XuatKho
    {
        public XuatKho()
        {
            this.CT_XuatKho = new HashSet<CT_XuatKho>();
        }
    
        public System.Guid PhieuXuatKhoId { get; set; }
        public long KhoId { get; set; }
        public long NhanVienId { get; set; }
        public System.DateTime NgayXuat { get; set; }
        public Nullable<bool> HoatDong { get; set; }
    
        public virtual Kho Kho { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual ICollection<CT_XuatKho> CT_XuatKho { get; set; }
    }
}
