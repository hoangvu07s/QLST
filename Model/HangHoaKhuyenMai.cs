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
    
    public partial class HangHoaKhuyenMai
    {
        public long HangHoaId { get; set; }
        public long KhuyenMaiId { get; set; }
        public Nullable<System.DateTime> NgayChinhSua { get; set; }
        public Nullable<long> NguoiChinhSuaId { get; set; }
        public Nullable<bool> HoatDong { get; set; }
    
        public virtual HangHoa HangHoa { get; set; }
        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}