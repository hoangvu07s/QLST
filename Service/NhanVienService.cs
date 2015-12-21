using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class NhanVienService: BaseService
    {
        public NhanVienService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public IList<NhanVien> GetNhanVienNghis()
        {
            try
            {
                return
                    Entities.NhanViens.Where(_ => _.HoatDong.HasValue && _.HoatDong == false)
                        .Include(_ => _.ChucVu)
                        .Include(_ => _.NhanVien2)
                        .Include(_ => _.NhanVien3)
                        .ToList();
            }
            catch (Exception ex)
            {
                
                QuanLySieuThiHelper.LogError(ex);
            }
            return null;
        }
        public IList<NhanVien> GetNhanViens()
        {
            try
            {
                return
                    Entities.NhanViens.Where(_ => _.HoatDong.HasValue && _.HoatDong == true)
                        .Include(_ => _.ChucVu)
                        .Include(_=>_.NhanVien2)
                        .Include(_=>_.NhanVien3)
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public NhanVien GetNhanVien(long nhanVienId)
        {
            try
            {
                return
                    Entities.NhanViens.FirstOrDefault(
                        _ => _.Id == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true);}
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void DeleteNhanVien(long nhanVienId)
        {
            try
            {
                var nhanVien = GetNhanVien(nhanVienId);
                if (nhanVien != null)
                {
                    nhanVien.HoatDong = false;
                    Entities.NhanViens.AddOrUpdate(nhanVien);
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public NhanVien AddNhanVien()
        {
            try
            {
                var nhanVien = new NhanVien
                {
                    NgayThangNamSinh = DateTime.Now
                };
                return Entities.NhanViens.Add(nhanVien);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public NhanVien GetByTenDangNhap(string tenDangNhap)
        {
            try
            {
                return
                    Entities.NhanViens.FirstOrDefault(
                        _ => _.TenDangNhap == tenDangNhap && (_.HoatDong.HasValue && _.HoatDong == true));
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<ChucVu> GetChucVus(long nhanVienId)
        {
            try
            {
                return
                    Entities.ChucVus.Where(_ => _.NguoiTaoId == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true)
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<ChungLoaiHangHoa> GetChungLoaiHangHoas(long nhanVienId)
        {
            try
            {
                return
                    Entities.ChungLoaiHangHoas.Where(
                        _ => _.NguoiTaoId == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<DonHang> GetDonHangs(long nhanVienId)
        {
            try
            {
                return Entities.DonHangs.Where(
                        _ => _.NguoiTaoId == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<HangHoa> GetHangHoas(long nhanVienId)
        {
            try
            {
                return Entities.HangHoas.Where(
                        _ => _.NguoiTaoId == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<HoaDon> GetHoaDons(long nhanVienId)
        {
            try
            {
                return Entities.HoaDons.Where(
                        _ => _.NhanVienId == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<Kho> GetKhos(long nhanVienId)
        {
            try
            {
                return Entities.Khoes.Where(
                        _ => _.NguoiTaoId == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<LoaiHangHoa> GetLoaiHangHoas(long nhanVienId)
        {
            try
            {
                return Entities.LoaiHangHoas.Where(
                        _ => _.NguoiTaoId == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<NhaCungCap> GetNhaCungCaps(long nhanVienId)
        {
            try
            {
                return Entities.NhaCungCaps.Where(
                       _ => _.NguoiTaoId == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<NhapKho> GetNhapKhos(long nhanVienId)
        {
            try
            {
                return Entities.NhapKhoes.Where(
                       _ => _.NguoiTaoId == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<QuayHang> GetQuayHangs(long nhanVienId)
        {
            try
            {
                return Entities.QuayHangs.Where(
                      _ => _.NguoiTaoId == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<XuatKho> GetXuatKhos(long nhanVienId)
        {
            try
            {
                return Entities.XuatKhoes.Where(
                      _ => _.NhanVienId == nhanVienId && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<NhanVien> GetNhanViensBySoDitenThoai(string soDienThoai)
        {
            try
            {
                return
                    Entities.NhanViens.Where(
                        _ => _.SoDienThoai == soDienThoai && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void Update(NhanVien nhanVien)
        {
            try
            {
                Entities.NhanViens.AddOrUpdate(nhanVien);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public override void Save()
        {
            Entities.SaveChanges();
        }
    }
}
