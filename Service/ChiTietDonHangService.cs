using System;
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

        public override void Save()
        {
            Entities.SaveChanges();
        }
    }
}
