using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class ChiTietHoaDonService : BaseService
    {
        public ChiTietHoaDonService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public IList<CT_HoaDon> GetByHoaDonId(Guid hoaDonId)
        {
            try
            {
                return Entities.CT_HoaDon.Where(_ => _.HoaDonId == hoaDonId).Include(_=>_.HangHoa).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public CT_HoaDon Add(CT_HoaDon chiTietHoaDon)
        {
            try
            {
                return Entities.CT_HoaDon.Add(chiTietHoaDon);
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
