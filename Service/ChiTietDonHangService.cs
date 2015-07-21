using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class ChiTietDonHangService: BaseService
    {
        public ChiTietDonHangService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public CT_DonHang AddChiTietDonHang()
        {
            try
            {
                var chiTietDonHang = new CT_DonHang();
                return Entities.CT_DonHang.Add(chiTietDonHang);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<CT_DonHang> GetByDonHangId(Guid donHangId)
        {
            try
            {
                return
                    Entities.CT_DonHang.Where(_ => _.DonHangId == donHangId)
                        .Include(_ => _.HangHoa)
                        .Include(_ => _.HangHoa.LoaiHangHoa)
                        .Include(_ => _.HangHoa.NhaCungCap)
                        .Include(_ => _.HangHoa.QuayHang)
                        .ToList();
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
