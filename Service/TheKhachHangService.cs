using System;
using System.Data.Entity.Migrations;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class TheKhachHangService: BaseService
    {
        public TheKhachHangService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public TheKhachHang Add()
        {
            try
            {
                var theKhachHang = new TheKhachHang();
                return Entities.TheKhachHangs.Add(theKhachHang);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public int CountTheKhachHang()
        {
            int countTheKhachHang = 0;
            try
            {
                countTheKhachHang = Entities.TheKhachHangs.Count();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return countTheKhachHang;
        }

        public TheKhachHang GetByKhachHangId(long khachHangId)
        {
            try
            {
                return
                    Entities.TheKhachHangs.FirstOrDefault(
                        _ => _.KhachHangId == khachHangId && _.HoatDong.HasValue && _.HoatDong == true);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void Delete(TheKhachHang theKhachHang)
        {
            try
            {
                theKhachHang.HoatDong = false;
                Entities.TheKhachHangs.AddOrUpdate(theKhachHang);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public void Update(TheKhachHang theKhachHang)
        {
            try
            {
                Entities.TheKhachHangs.AddOrUpdate(theKhachHang);
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
