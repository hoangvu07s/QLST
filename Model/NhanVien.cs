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
    
    public partial class NhanVien
    {
        public NhanVien()
        {
            this.ChucVus = new HashSet<ChucVu>();
            this.ChucVus1 = new HashSet<ChucVu>();
            this.ChungLoaiHangHoas = new HashSet<ChungLoaiHangHoa>();
            this.ChungLoaiHangHoas1 = new HashSet<ChungLoaiHangHoa>();
            this.DoiTraHangHoas = new HashSet<DoiTraHangHoa>();
            this.DoiTraHangHoas1 = new HashSet<DoiTraHangHoa>();
            this.HangHoaKhuyenMais = new HashSet<HangHoaKhuyenMai>();
            this.HoaDons = new HashSet<HoaDon>();
            this.HoaDons1 = new HashSet<HoaDon>();
            this.Khoes = new HashSet<Kho>();
            this.Khoes1 = new HashSet<Kho>();
            this.Khoes2 = new HashSet<Kho>();
            this.LoaiHangHoas = new HashSet<LoaiHangHoa>();
            this.LoaiHangHoas1 = new HashSet<LoaiHangHoa>();
            this.NhaCungCaps = new HashSet<NhaCungCap>();
            this.NhaCungCaps1 = new HashSet<NhaCungCap>();
            this.NhanVien1 = new HashSet<NhanVien>();
            this.NhanVien11 = new HashSet<NhanVien>();
            this.NhapKhoes = new HashSet<NhapKho>();
            this.NhapKhoes1 = new HashSet<NhapKho>();
            this.PhieuTraQuayHangs = new HashSet<PhieuTraQuayHang>();
            this.PhieuTraQuayHangs1 = new HashSet<PhieuTraQuayHang>();
            this.XuatKhoes = new HashSet<XuatKho>();
            this.XuatKhoes1 = new HashSet<XuatKho>();
            this.QuayHangs = new HashSet<QuayHang>();
            this.QuayHangs1 = new HashSet<QuayHang>();
            this.TheKhachHangs = new HashSet<TheKhachHang>();
            this.KhachHangs = new HashSet<KhachHang>();
            this.KhachHangs1 = new HashSet<KhachHang>();
            this.KhuyenMais = new HashSet<KhuyenMai>();
            this.KhuyenMais1 = new HashSet<KhuyenMai>();
            this.DonHangs = new HashSet<DonHang>();
            this.HangHoas = new HashSet<HangHoa>();
            this.HangHoas1 = new HashSet<HangHoa>();
        }
    
        public long Id { get; set; }
        public string HoVaTen { get; set; }
        public bool GioiTinh { get; set; }
        public System.DateTime NgayThangNamSinh { get; set; }
        public long ChucVuId { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<long> NguoiTaoId { get; set; }
        public Nullable<System.DateTime> NgayChinhSua { get; set; }
        public Nullable<long> NguoiChinhSuaId { get; set; }
        public Nullable<bool> HoatDong { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
    
        public virtual ICollection<ChucVu> ChucVus { get; set; }
        public virtual ICollection<ChucVu> ChucVus1 { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        public virtual ICollection<ChungLoaiHangHoa> ChungLoaiHangHoas { get; set; }
        public virtual ICollection<ChungLoaiHangHoa> ChungLoaiHangHoas1 { get; set; }
        public virtual ICollection<DoiTraHangHoa> DoiTraHangHoas { get; set; }
        public virtual ICollection<DoiTraHangHoa> DoiTraHangHoas1 { get; set; }
        public virtual ICollection<HangHoaKhuyenMai> HangHoaKhuyenMais { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<HoaDon> HoaDons1 { get; set; }
        public virtual ICollection<Kho> Khoes { get; set; }
        public virtual ICollection<Kho> Khoes1 { get; set; }
        public virtual ICollection<Kho> Khoes2 { get; set; }
        public virtual ICollection<LoaiHangHoa> LoaiHangHoas { get; set; }
        public virtual ICollection<LoaiHangHoa> LoaiHangHoas1 { get; set; }
        public virtual ICollection<NhaCungCap> NhaCungCaps { get; set; }
        public virtual ICollection<NhaCungCap> NhaCungCaps1 { get; set; }
        public virtual ICollection<NhanVien> NhanVien1 { get; set; }
        public virtual NhanVien NhanVien2 { get; set; }
        public virtual ICollection<NhanVien> NhanVien11 { get; set; }
        public virtual NhanVien NhanVien3 { get; set; }
        public virtual ICollection<NhapKho> NhapKhoes { get; set; }
        public virtual ICollection<NhapKho> NhapKhoes1 { get; set; }
        public virtual ICollection<PhieuTraQuayHang> PhieuTraQuayHangs { get; set; }
        public virtual ICollection<PhieuTraQuayHang> PhieuTraQuayHangs1 { get; set; }
        public virtual ICollection<XuatKho> XuatKhoes { get; set; }
        public virtual ICollection<XuatKho> XuatKhoes1 { get; set; }
        public virtual ICollection<QuayHang> QuayHangs { get; set; }
        public virtual ICollection<QuayHang> QuayHangs1 { get; set; }
        public virtual ICollection<TheKhachHang> TheKhachHangs { get; set; }
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        public virtual ICollection<KhachHang> KhachHangs1 { get; set; }
        public virtual ICollection<KhuyenMai> KhuyenMais { get; set; }
        public virtual ICollection<KhuyenMai> KhuyenMais1 { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual ICollection<HangHoa> HangHoas { get; set; }
        public virtual ICollection<HangHoa> HangHoas1 { get; set; }
    }
}
