using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Model;

namespace Service
{
    public class XuatKhoService: BaseService
    {
        public XuatKhoService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public XuatKho Add()
        {
            try
            {
                return Entities.XuatKhoes.Add(new XuatKho());
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<XuatKho> GetAll()
        {
            try
            {
                return Entities.XuatKhoes.Where(_ => _.HoatDong.HasValue && _.HoatDong == true).Include(_=>_.NhanVien).Include(_=>_.Kho).ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<XuatKho> GetByKhoId(long khoId)
        {
            try
            {
                return
                    Entities.XuatKhoes.Where(_ => _.KhoId == khoId && _.HoatDong.HasValue && _.HoatDong == true)
                        .Include(_ => _.CT_XuatKho)
                        .ToList();
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<XuatKho> GetByXuatKhoIds(IList<Guid> xuatKhoIds)
        {
            IList<XuatKho> xuatKhos = new List<XuatKho>();
            try
            {               
                foreach (var xuatKhoId in xuatKhoIds)
                {
                    var xuatKho =
                        Entities.XuatKhoes.Include(_ => _.Kho).FirstOrDefault(_ => _.PhieuXuatKhoId == xuatKhoId);
                    if (xuatKho != null)
                    {
                        xuatKhos.Add(xuatKho);
                    }
                }
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return xuatKhos.Distinct().ToList();
        }

        public override void Save()
        {
            Entities.SaveChanges();
        }
    }
}
