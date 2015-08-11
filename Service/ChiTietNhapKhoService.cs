using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Helper;
using Model;

namespace Service
{
    public class ChiTietNhapKhoService: BaseService
    {
        public ChiTietNhapKhoService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public CT_NhapKho Add()
        {
            try
            {
                var ctNhapKho = new CT_NhapKho();
                return Entities.CT_NhapKho.Add(ctNhapKho);
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<CT_NhapKho> Get(Guid nhapKhoId)
        {
            try
            {
                return Entities.CT_NhapKho.Where(_ => _.NhapKhoId == nhapKhoId).Include(_=>_.HangHoa).ToList();
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
