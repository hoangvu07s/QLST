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
    
    public partial class ChucVu
    {
        public ChucVu()
        {
            this.NhanViens = new HashSet<NhanVien>();
        }
    
        public long Id { get; set; }
        public string TenChucVu { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<long> NguoiTaoId { get; set; }
        public Nullable<System.DateTime> NgayChinhSua { get; set; }
        public Nullable<long> NguoiChinhSuaId { get; set; }
        public Nullable<bool> HoatDong { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual NhanVien NhanVien1 { get; set; }
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}