﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLySieuThiEntities : DbContext
    {
        public QuanLySieuThiEntities()
            : base("name=QuanLySieuThiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<ChungLoaiHangHoa> ChungLoaiHangHoas { get; set; }
        public virtual DbSet<CT_DoiTraHangHoa> CT_DoiTraHangHoa { get; set; }
        public virtual DbSet<CT_DonHang> CT_DonHang { get; set; }
        public virtual DbSet<CT_HoaDon> CT_HoaDon { get; set; }
        public virtual DbSet<DoiTraHangHoa> DoiTraHangHoas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
        public virtual DbSet<LoaiHangHoa> LoaiHangHoas { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<QuayHang> QuayHangs { get; set; }
        public virtual DbSet<TonKho> TonKhoes { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<CT_PhieuTraQuayHang> CT_PhieuTraQuayHang { get; set; }
        public virtual DbSet<CT_XuatKho> CT_XuatKho { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<PhieuTraQuayHang> PhieuTraQuayHangs { get; set; }
        public virtual DbSet<TheKhachHang> TheKhachHangs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<HangHoaKhuyenMai> HangHoaKhuyenMais { get; set; }
        public virtual DbSet<NhapKho> NhapKhoes { get; set; }
        public virtual DbSet<CT_NhapKho> CT_NhapKho { get; set; }
        public virtual DbSet<XuatKho> XuatKhoes { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
    }
}
