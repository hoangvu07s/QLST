using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class KhachHangService: BaseService
    {
        public KhachHangService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public IList<KhachHang> GetAll()
        {
            try
            {
                return Entities.KhachHangs.Where(_ => _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<KhachHang> GetKhachHangsBySoDienThoai(string soDienThoai)
        {
            try
            {
                return
                    Entities.KhachHangs.Where(
                        _ => _.SoDienThoai == soDienThoai && _.HoatDong.HasValue && _.HoatDong == true).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public KhachHang Get(long khachHangId)
        {
            try
            {
                return Entities.KhachHangs.FirstOrDefault(_ => _.Id == khachHangId);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public KhachHang Add()
        {
            try
            {
                var khachHang = new KhachHang();

                return Entities.KhachHangs.Add(khachHang);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void Update(KhachHang khachHang)
        {
            try
            {
                Entities.KhachHangs.AddOrUpdate(khachHang);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public void Delete(KhachHang khachHang)
        {
            try
            {
                khachHang.HoatDong = false;

                Entities.KhachHangs.AddOrUpdate(khachHang);
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
