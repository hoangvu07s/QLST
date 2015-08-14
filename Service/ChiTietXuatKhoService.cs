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
    public class ChiTietXuatKhoService: BaseService
    {
        public ChiTietXuatKhoService(QuanLySieuThiEntities quanLySieuThiEntities)
        {
            Entities = quanLySieuThiEntities;
        }

        public CT_XuatKho Add()
        {
            try
            {
                return Entities.CT_XuatKho.Add(new CT_XuatKho());
            }
            catch (Exception ex)
            {
                QuanLySieuThiHelper.LogError(ex);
            }

            return null;
        }

        public IList<CT_XuatKho> Get(Guid xuatKhoId)
        {
            try
            {
                return Entities.CT_XuatKho.Where(_ => _.XuatKhoId == xuatKhoId).Include(_ => _.HangHoa).ToList();
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
