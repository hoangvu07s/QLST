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
    
    public partial class HangHoa
    {
        public HangHoa()
        {
            this.CT_DoiTraHangHoa = new HashSet<CT_DoiTraHangHoa>();
            this.CT_DonHang = new HashSet<CT_DonHang>();
            this.CT_HoaDon = new HashSet<CT_HoaDon>();
            this.TonKhoes = new HashSet<TonKho>();
            this.HangHoaKhuyenMais = new HashSet<HangHoaKhuyenMai>();
            this.HangHoaKhuyenMais1 = new HashSet<HangHoaKhuyenMai>();
            this.CT_XuatKho = new HashSet<CT_XuatKho>();
            this.CT_NhapKho = new HashSet<CT_NhapKho>();
            this.CT_PhieuTraQuayHang = new HashSet<CT_PhieuTraQuayHang>();
        }
    
        public long Id { get; set; }
        public string TenHangHoa { get; set; }
        public long LoaiHangHoaId { get; set; }
        public long NhaCungCapId { get; set; }
        public long QuayHangId { get; set; }
        public Nullable<long> SoLuongTonQuay { get; set; }
        public Nullable<bool> CoTheTraLai { get; set; }
        public decimal GiaNhapVao { get; set; }
        public decimal GiaBanRa { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<long> NguoiTaoId { get; set; }
        public Nullable<System.DateTime> NgayChinhSua { get; set; }
        public Nullable<long> NguoiChinhSuaId { get; set; }
        public Nullable<bool> HoatDong { get; set; }
    
        public virtual ICollection<CT_DoiTraHangHoa> CT_DoiTraHangHoa { get; set; }
        public virtual ICollection<CT_DonHang> CT_DonHang { get; set; }
        public virtual ICollection<CT_HoaDon> CT_HoaDon { get; set; }
        public virtual LoaiHangHoa LoaiHangHoa { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual QuayHang QuayHang { get; set; }
        public virtual ICollection<TonKho> TonKhoes { get; set; }
        public virtual ICollection<HangHoaKhuyenMai> HangHoaKhuyenMais { get; set; }
        public virtual ICollection<HangHoaKhuyenMai> HangHoaKhuyenMais1 { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual NhanVien NhanVien1 { get; set; }
        public virtual ICollection<CT_XuatKho> CT_XuatKho { get; set; }
        public virtual ICollection<CT_NhapKho> CT_NhapKho { get; set; }
        public virtual ICollection<CT_PhieuTraQuayHang> CT_PhieuTraQuayHang { get; set; }
    }
}
