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

        public IList<NhanVien> GetNhanViens()
        {
            try
            {
                return
                    Entities.NhanViens.Where(_ => _.HoatDong.HasValue && _.HoatDong == true)
                        .Include(_ => _.ChucVu)
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
                var nhanVien = new NhanVien();
                return Entities.NhanViens.Add(nhanVien);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public override void Save()
        {
            Entities.SaveChanges();
        }
    }
}
