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
    
    public partial class Kho
    {
        public Kho()
        {
            this.TonKhoes = new HashSet<TonKho>();
            this.PhieuTraQuayHangs = new HashSet<PhieuTraQuayHang>();
            this.NhapKhoes = new HashSet<NhapKho>();
            this.XuatKhoes = new HashSet<XuatKho>();
        }
    
        public long Id { get; set; }
        public string TenKho { get; set; }
        public long NhanVienId { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<long> NguoiTaoId { get; set; }
        public Nullable<System.DateTime> NgayChinhSua { get; set; }
        public Nullable<long> NguoiChinhSuaId { get; set; }
        public Nullable<bool> HoatDong { get; set; }
    
        public virtual ICollection<TonKho> TonKhoes { get; set; }
        public virtual ICollection<PhieuTraQuayHang> PhieuTraQuayHangs { get; set; }
        public virtual ICollection<NhapKho> NhapKhoes { get; set; }
        public virtual ICollection<XuatKho> XuatKhoes { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual NhanVien NhanVien1 { get; set; }
        public virtual NhanVien NhanVien2 { get; set; }
    }
}
