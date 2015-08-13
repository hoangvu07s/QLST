using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Model;

namespace Service
{
    public class QuayHangService: BaseService
    {
        public QuayHangService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public QuayHang Add()
        {
            try
            {
                return Entities.QuayHangs.Add(new QuayHang());
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void Delete(long quayHangId)
        {
            try
            {
                var quayHang =
                    Entities.QuayHangs.FirstOrDefault(
                        _ => _.Id == quayHangId && _.HoatDong.HasValue && _.HoatDong == true);

                if (quayHang != null)
                {
                    quayHang.HoatDong = false;
                    Entities.QuayHangs.AddOrUpdate(quayHang);
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }
        }

        public QuayHang Get(long quayHangId)
        {
            try
            {
                return Entities.QuayHangs.FirstOrDefault(
                        _ => _.Id == quayHangId && _.HoatDong.HasValue && _.HoatDong == true);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<QuayHang> GetAll()
        {
            try
            {
                return Entities.QuayHangs.Where(
                    _ => _.HoatDong.HasValue && _.HoatDong == true)
                    .Include(_ => _.NhanVien)
                    .Include(_ => _.NhanVien1)
                    .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public QuayHang GetByTenQuayHang(string tenQuayHang)
        {
            try
            {
                return Entities.QuayHangs.FirstOrDefault(
                        _ => _.TenQuay == tenQuayHang && _.HoatDong.HasValue && _.HoatDong == true);
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
