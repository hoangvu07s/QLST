using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class DoiTraHangHoaService: BaseService
    {
        public DoiTraHangHoaService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public DoiTraHangHoa Add(DoiTraHangHoa doiTraHangHoa)
        {
            try
            {
                return Entities.DoiTraHangHoas.Add(doiTraHangHoa);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<HoaDon> GetHoaDons()
        {
            try
            {
                return Entities.DoiTraHangHoas.Include(_ => _.HoaDon).Select(_ => _.HoaDon).ToList().Distinct().ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<DoiTraHangHoa> GetAll()
        {
            try
            {
                return Entities.DoiTraHangHoas.Include(_ => _.NhanVien1).ToList();
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
