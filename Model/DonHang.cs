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
    
    public partial class DonHang
    {
        public DonHang()
        {
            this.CT_DonHang = new HashSet<CT_DonHang>();
            this.NhapKhoes = new HashSet<NhapKho>();
        }
    
        public System.Guid DonHangId { get; set; }
        public long NhanVienId { get; set; }
        public long NhaCungCapId { get; set; }
        public System.DateTime NgayLap { get; set; }
        public Nullable<System.DateTime> NgayChinhSua { get; set; }
        public Nullable<long> NguoiChinhSuaId { get; set; }
        public Nullable<bool> HoatDong { get; set; }
    
        public virtual ICollection<CT_DonHang> CT_DonHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual NhanVien NhanVien1 { get; set; }
        public virtual ICollection<NhapKho> NhapKhoes { get; set; }
    }
}