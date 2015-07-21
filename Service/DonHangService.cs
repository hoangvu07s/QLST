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
    public class DonHangService : BaseService
    {
        public DonHangService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public DonHang AddDonHang()
        {
            try
            {
                var donHang = new DonHang();
                return Entities.DonHangs.Add(donHang);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<DonHang> GetAll()
        {
            try
            {
                return
                    Entities.DonHangs.Where(_ => _.HoatDong.HasValue && _.HoatDong == true)
                        .Include(_ => _.NhanVien1)
                        .Include(_ => _.NhaCungCap)
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public DonHang Get(Guid donHangId)
        {
            try
            {
                return
                    Entities.DonHangs.FirstOrDefault(
                        _ => _.DonHangId == donHangId && _.HoatDong.HasValue && _.HoatDong == true);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public void Update(DonHang donHang)
        {
            try
            {
                Entities.DonHangs.AddOrUpdate(donHang);
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
