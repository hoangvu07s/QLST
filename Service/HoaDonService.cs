using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class HoaDonService : BaseService
    {
        public HoaDonService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public IList<HoaDon> GetAll()
        {
            try
            {
                return Entities.HoaDons
                    .Include(_ => _.NhanVien1)
                    .Include(_=>_.KhachHang).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public HoaDon Add(HoaDon hoaDon)
        {
            try
            {
                return Entities.HoaDons.Add(hoaDon);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void Update(HoaDon hoaDon)
        {
            try
            {
                Entities.HoaDons.AddOrUpdate(hoaDon);
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
